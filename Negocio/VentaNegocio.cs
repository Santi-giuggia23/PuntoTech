using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Negocio
{
    public class VentaNegocio
    {
        private readonly string cadenaConexion = "data source=.\\SQLEXPRESS; initial catalog=CATALOGO_DB; integrated security=true";

        public void registrar(Venta venta)
        {
            if (venta.Detalle == null || venta.Detalle.Count == 0)
                throw new Exception("La venta no tiene artículos cargados.");

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();
                SqlTransaction transaccion = conexion.BeginTransaction();
                try
                {
                    SqlCommand cmdVenta = new SqlCommand(
                        "insert into VENTAS (Fecha, IdUsuario, Total) output inserted.Id values (@Fecha, @IdUsuario, @Total)",
                        conexion, transaccion);
                    cmdVenta.Parameters.AddWithValue("@Fecha", venta.Fecha);
                    cmdVenta.Parameters.AddWithValue("@IdUsuario", venta.Usuario.Id);
                    cmdVenta.Parameters.AddWithValue("@Total", venta.Total);
                    int idVenta = (int)cmdVenta.ExecuteScalar();
                    venta.Id = idVenta;

                    foreach (DetalleVenta detalle in venta.Detalle)
                    {
                        SqlCommand cmdStock = new SqlCommand(
                            "select Stock from ARTICULOS where Id = @IdArticulo",
                            conexion, transaccion);
                        cmdStock.Parameters.AddWithValue("@IdArticulo", detalle.Articulo.Id);
                        object stockActualObj = cmdStock.ExecuteScalar();
                        int stockActual = stockActualObj == null || stockActualObj == DBNull.Value ? 0 : (int)stockActualObj;

                        if (stockActual < detalle.Cantidad)
                            throw new Exception("No hay stock suficiente de '" + detalle.Articulo.Nombre + "'. Stock disponible: " + stockActual);

                        SqlCommand cmdDetalle = new SqlCommand(
                            "insert into DETALLE_VENTA (IdVenta, IdArticulo, Cantidad, PrecioUnitario) values (@IdVenta, @IdArticulo, @Cantidad, @PrecioUnitario)",
                            conexion, transaccion);
                        cmdDetalle.Parameters.AddWithValue("@IdVenta", idVenta);
                        cmdDetalle.Parameters.AddWithValue("@IdArticulo", detalle.Articulo.Id);
                        cmdDetalle.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                        cmdDetalle.Parameters.AddWithValue("@PrecioUnitario", detalle.PrecioUnitario);
                        cmdDetalle.ExecuteNonQuery();

                        SqlCommand cmdActualizarStock = new SqlCommand(
                            "update ARTICULOS set Stock = Stock - @Cantidad where Id = @IdArticulo",
                            conexion, transaccion);
                        cmdActualizarStock.Parameters.AddWithValue("@Cantidad", detalle.Cantidad);
                        cmdActualizarStock.Parameters.AddWithValue("@IdArticulo", detalle.Articulo.Id);
                        cmdActualizarStock.ExecuteNonQuery();
                    }

                    transaccion.Commit();
                }
                catch (Exception ex)
                {
                    transaccion.Rollback();
                    throw ex;
                }
            }
        }

        public List<Venta> listar()
        {
            List<Venta> lista = new List<Venta>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select v.Id, v.Fecha, v.Total, u.Id as IdUsuario, u.NombreUsuario, u.Nombre, u.Rol from VENTAS v, USUARIOS u where v.IdUsuario = u.Id order by v.Fecha desc");
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Venta aux = new Venta();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Total = (decimal)datos.Lector["Total"];
                    aux.Usuario = new Usuario();
                    aux.Usuario.Id = (int)datos.Lector["IdUsuario"];
                    aux.Usuario.NombreUsuario = (string)datos.Lector["NombreUsuario"];
                    aux.Usuario.Nombre = (string)datos.Lector["Nombre"];
                    aux.Usuario.Rol = (string)datos.Lector["Rol"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<DetalleVenta> listarDetalle(int idVenta)
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select dv.Id, dv.Cantidad, dv.PrecioUnitario, a.Id as IdArticulo, a.Codigo, a.Nombre from DETALLE_VENTA dv, ARTICULOS a where dv.IdArticulo = a.Id and dv.IdVenta = @IdVenta");
                datos.agregarParametro("@IdVenta", idVenta);
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    DetalleVenta aux = new DetalleVenta();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Cantidad = (int)datos.Lector["Cantidad"];
                    aux.PrecioUnitario = (decimal)datos.Lector["PrecioUnitario"];
                    aux.Articulo = new Articulo();
                    aux.Articulo.Id = (int)datos.Lector["IdArticulo"];
                    aux.Articulo.Codigo = (string)datos.Lector["Codigo"];
                    aux.Articulo.Nombre = (string)datos.Lector["Nombre"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
