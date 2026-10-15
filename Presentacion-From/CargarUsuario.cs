using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Negocio;

namespace Presentacion_From
{
    public partial class CargarUsuario : Form
    {
        private Usuario usuario = null;

        public CargarUsuario()
        {
            InitializeComponent();
        }

        public CargarUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void CargarUsuario_Load(object sender, EventArgs e)
        {
            cboRol.Items.Add("Administrador");
            cboRol.Items.Add("Vendedor");

            if (usuario != null)
            {
                txtNombreUsuario.Text = usuario.NombreUsuario;
                txtContrasenia.Text = usuario.Contrasenia;
                txtNombre.Text = usuario.Nombre;
                cboRol.SelectedItem = usuario.Rol;
            }
            else
            {
                cboRol.SelectedIndex = 1;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                if (txtNombreUsuario.Text.Trim() == "" || txtContrasenia.Text.Trim() == "" || txtNombre.Text.Trim() == "" || cboRol.SelectedItem == null)
                {
                    MessageBox.Show("Complete todos los campos.");
                    return;
                }

                if (usuario == null)
                    usuario = new Usuario();

                usuario.NombreUsuario = txtNombreUsuario.Text.Trim();
                usuario.Contrasenia = txtContrasenia.Text;
                usuario.Nombre = txtNombre.Text.Trim();
                usuario.Rol = cboRol.SelectedItem.ToString();

                if (usuario.Id != 0)
                {
                    negocio.modificar(usuario);
                    MessageBox.Show("Operacion realizada con exito");
                }
                else
                {
                    negocio.agregar(usuario);
                    MessageBox.Show("Operacion realizada con exito");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
