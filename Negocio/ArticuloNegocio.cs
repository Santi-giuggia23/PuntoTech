using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Negocio
{

    public class ArticuloNegocio
    {

        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Codigo, Nombre, a.Descripcion, m.Descripcion as Marcas, c.Descripcion as Categorias, ImagenUrl, Precio, Stock, IdMarca, IdCategoria, a.Id from ARTICULOS a, MARCAS m, CATEGORIAS c where a.IdMarca = m.Id and a.IdCategoria = c.Id");
                datos.ejecutarConsulta();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)datos.Lector["Marcas"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)datos.Lector["Categorias"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = datos.Lector["Stock"] == DBNull.Value ? 0 : (int)datos.Lector["Stock"];
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

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagenUrl, Precio = @precio, Stock = @stock where Id = @id");
                datos.agregarParametro("@codigo", articulo.Codigo);
                datos.agregarParametro("@nombre", articulo.Nombre);
                datos.agregarParametro("@descripcion", articulo.Descripcion);
                datos.agregarParametro("@idMarca", articulo.Marca.Id);
                datos.agregarParametro("@idCategoria", articulo.Categoria.Id);
                datos.agregarParametro("@imagenUrl", articulo.ImagenUrl);
                datos.agregarParametro("@precio", articulo.Precio);
                datos.agregarParametro("@stock", articulo.Stock);
                datos.agregarParametro("@id", articulo.Id);

                datos.ejecutarAccion();

            }
            catch (NullReferenceException ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarFisico(int id)
        {
               AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From ARTICULOS Where Id = " + id);
                datos.ejecutarAccion();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio, Stock) Values (@Codigo, @Nombre, @Descripcion, @idMarca, @idCategoria, @imagenUrl, @Precio, @Stock)");
                datos.agregarParametro("@Codigo", nuevo.Codigo);
                datos.agregarParametro("@Nombre", nuevo.Nombre);
                datos.agregarParametro("@Descripcion", nuevo.Descripcion);
                datos.agregarParametro("@idMarca", nuevo.Marca.Id);
                datos.agregarParametro("@idCategoria", nuevo.Categoria.Id);
                datos.agregarParametro("@imagenUrl", nuevo.ImagenUrl);
                datos.agregarParametro("@Precio", nuevo.Precio);
                datos.agregarParametro("@Stock", nuevo.Stock);

                datos.ejecutarConsulta();
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
