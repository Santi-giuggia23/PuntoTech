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
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                dgvUsuario.DataSource = negocio.listar();
                dgvUsuario.Columns[0].Visible = false;
                dgvUsuario.Columns[2].Visible = false;

                dgvUsuario.ReadOnly = true;
                dgvUsuario.AllowUserToAddRows = false;
                dgvUsuario.AllowUserToDeleteRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CargarUsuario nuevaVentana = new CargarUsuario();
            nuevaVentana.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }
            Usuario seleccionado = (Usuario)dgvUsuario.CurrentRow.DataBoundItem;
            CargarUsuario nuevaVentana = new CargarUsuario(seleccionado);
            nuevaVentana.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvUsuario.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un usuario.");
                return;
            }

            Usuario seleccionado = (Usuario)dgvUsuario.CurrentRow.DataBoundItem;

            if (Sesion.UsuarioActual != null && seleccionado.Id == Sesion.UsuarioActual.Id)
            {
                MessageBox.Show("No podés eliminar el usuario con el que iniciaste sesión.");
                return;
            }

            UsuarioNegocio negocio = new UsuarioNegocio();
            try
            {
                if (MessageBox.Show("¿Seguro que quieres eliminar este usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    negocio.eliminarFisico(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar correctamente..." + ex.ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
