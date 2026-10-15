using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public string Nombre { get; set; }
        public string Rol { get; set; }

        public Usuario()
        {
        }

        public Usuario(int id, string nombreUsuario, string contrasenia, string nombre, string rol)
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
            Nombre = nombre;
            Rol = rol;
        }

        public override string ToString()
        {
            return NombreUsuario;
        }
    }
}
