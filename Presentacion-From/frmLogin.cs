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
using System.IO;

namespace Presentacion_From
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaLogo = Path.Combine(Application.StartupPath, "Recursos", "logo_marca.png");
                if (File.Exists(rutaLogo))
                    pbxLogo.Image = Image.FromFile(rutaLogo);
            }
            catch (Exception)
            {
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                if (txtUsuario.Text.Trim() == "" || txtContrasenia.Text.Trim() == "")
                {
                    MessageBox.Show("Ingrese usuario y contraseña.");
                    return;
                }

                Usuario usuario = negocio.validarLogin(txtUsuario.Text.Trim(), txtContrasenia.Text);

                if (usuario == null)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                    txtContrasenia.Text = "";
                    txtContrasenia.Focus();
                    return;
                }

                Sesion.UsuarioActual = usuario;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                btnIngresar_Click(sender, e);
            }
        }
    }
}
