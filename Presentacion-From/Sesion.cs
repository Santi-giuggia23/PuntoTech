using System;
using Modelo;

namespace Presentacion_From
{
    public static class Sesion
    {
        public static Usuario UsuarioActual { get; set; }

        public static bool EsAdministrador
        {
            get { return UsuarioActual != null && UsuarioActual.Rol == "Administrador"; }
        }
    }
}
