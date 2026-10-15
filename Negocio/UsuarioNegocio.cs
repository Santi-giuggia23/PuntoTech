using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public List<Usuario> listar()
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, NombreUsuario, Contrasenia, Nombre, Rol from USUARIOS");
                datos.ejecutarConsulta();
                while (datos.Lector.Read())
                {
                    Usuario aux = new Usuario();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.NombreUsuario = (string)datos.Lector["NombreUsuario"];
                    aux.Contrasenia = (string)datos.Lector["Contrasenia"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Rol = (string)datos.Lector["Rol"];
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

        public Usuario validarLogin(string nombreUsuario, string contrasenia)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select Id, NombreUsuario, Contrasenia, Nombre, Rol from USUARIOS where NombreUsuario = @nombreUsuario and Contrasenia = @contrasenia");
                datos.agregarParametro("@nombreUsuario", nombreUsuario);
                datos.agregarParametro("@contrasenia", contrasenia);
                datos.ejecutarConsulta();

                Usuario usuario = null;
                if (datos.Lector.Read())
                {
                    usuario = new Usuario();
                    usuario.Id = (int)datos.Lector["Id"];
                    usuario.NombreUsuario = (string)datos.Lector["NombreUsuario"];
                    usuario.Contrasenia = (string)datos.Lector["Contrasenia"];
                    usuario.Nombre = (string)datos.Lector["Nombre"];
                    usuario.Rol = (string)datos.Lector["Rol"];
                }
                return usuario;
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

        public void agregar(Usuario nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into USUARIOS (NombreUsuario, Contrasenia, Nombre, Rol) Values (@NombreUsuario, @Contrasenia, @Nombre, @Rol)");
                datos.agregarParametro("@NombreUsuario", nuevo.NombreUsuario);
                datos.agregarParametro("@Contrasenia", nuevo.Contrasenia);
                datos.agregarParametro("@Nombre", nuevo.Nombre);
                datos.agregarParametro("@Rol", nuevo.Rol);

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

        public void modificar(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update USUARIOS set NombreUsuario = @NombreUsuario, Contrasenia = @Contrasenia, Nombre = @Nombre, Rol = @Rol where Id = @Id");
                datos.agregarParametro("@NombreUsuario", usuario.NombreUsuario);
                datos.agregarParametro("@Contrasenia", usuario.Contrasenia);
                datos.agregarParametro("@Nombre", usuario.Nombre);
                datos.agregarParametro("@Rol", usuario.Rol);
                datos.agregarParametro("@Id", usuario.Id);

                datos.ejecutarAccion();
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

        public void eliminarFisico(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Delete From USUARIOS Where Id = " + id);
                datos.ejecutarAccion();
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
