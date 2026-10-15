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
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
                dgvMarca.DataSource = negocio.listar();
                dgvMarca.Columns[0].Visible = false;

                dgvMarca.ReadOnly = true;
                dgvMarca.AllowUserToAddRows = false;
                dgvMarca.AllowUserToDeleteRows = false;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CargarMarca nuevaVentana = new CargarMarca();
            nuevaVentana.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Marca seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            CargarMarca nuevaVentana = new CargarMarca(seleccionado);
            nuevaVentana.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();
            Marca seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            try
            {
                if (MessageBox.Show("¿Seguro que quieres eliminar este articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Marca seleccionado = (Marca)dgvMarca.CurrentRow.DataBoundItem;
            CargarMarca detalle = new CargarMarca(seleccionado, true);
            detalle.Show();
        }
    }
}
