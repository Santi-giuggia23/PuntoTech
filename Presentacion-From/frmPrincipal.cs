using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_From
{
    public partial class frmPrincipal : Form
    {
        public static bool CerrandoSesion = false;

        public frmPrincipal()
        {
            InitializeComponent();
            CerrandoSesion = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (Sesion.UsuarioActual != null)
            {
                this.Text = "PuntoTech - " + Sesion.UsuarioActual.Nombre + " (" + Sesion.UsuarioActual.Rol + ")";
            }

            try
            {
                string rutaLogo = System.IO.Path.Combine(Application.StartupPath, "Recursos", "logo_marca.png");
                if (System.IO.File.Exists(rutaLogo))
                {
                    toolStripButton1.Image = Image.FromFile(rutaLogo);
                    toolStripButton1.Text = "PuntoTech";
                    toolStripButton1.ToolTipText = "Gestión de Artículos - PuntoTech";
                }
            }
            catch (Exception)
            {
            }

            if (!Sesion.EsAdministrador)
            {
                menArticulos.Visible = false;
                menMarca.Visible = false;
                menCategoria.Visible = false;
                menUsuarios.Visible = false;
                menHistorialVentas.Visible = false;
            }
        }

        private void menArticulos_Click(object sender, EventArgs e)
        {
            bool ventanaAbierta = false;
            foreach (var item in Application.OpenForms)
            {
                if (item is Control)
                    ventanaAbierta = true;
            }
            if (!ventanaAbierta)
            {
               Control ventana = new Control();
               ventana.MdiParent = this;
               ventana.Show();
            }
        }

        private void menMarca_Click(object sender, EventArgs e)
        {
            bool venataAbierta = false;
            foreach( var item in Application.OpenForms)
            {
                if (item is Control)
                    venataAbierta = true;
            }
            if (!venataAbierta)
            {
            frmMarca marca = new frmMarca();
            marca.MdiParent = this;
            marca.Show();
            }
        }

        private void menCategoria_Click(object sender, EventArgs e)
        {
            bool venataAbierta = false;
            foreach (var item in Application.OpenForms)
            {
                if (item is Control)
                    venataAbierta = true;
            }
            if (!venataAbierta)
            {
                frmCategoria categoria = new frmCategoria();
                categoria.MdiParent = this;
                categoria.Show();
            }
        }

        private void menRegistrarVenta_Click(object sender, EventArgs e)
        {
            frmVenta venta = new frmVenta();
            venta.ShowDialog();
        }

        private void menHistorialVentas_Click(object sender, EventArgs e)
        {
            frmHistorialVentas historial = new frmHistorialVentas();
            historial.ShowDialog();
        }

        private void menUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario usuarios = new frmUsuario();
            usuarios.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que querés cerrar la sesión?", "Cerrar sesión",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CerrandoSesion = true;
                Sesion.UsuarioActual = null;
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que querés cerrar la aplicación?", "Salir",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
