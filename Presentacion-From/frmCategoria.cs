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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
           
            try
            {             
                dgvCategoria.DataSource = negocio.listar();
                dgvCategoria.Columns[0].Visible = false;

                dgvCategoria.ReadOnly = true;
                dgvCategoria.AllowUserToAddRows = false;
                dgvCategoria.AllowUserToDeleteRows = false;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CargarCategoria nuevaVentana = new CargarCategoria();
            nuevaVentana.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Categoria seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
            CargarCategoria nuevaVentana = new CargarCategoria(seleccionado);
            nuevaVentana.ShowDialog();
            cargar();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Categoria seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
            CargarCategoria detalle = new CargarCategoria(seleccionado, true);
            detalle.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();
            Categoria seleccionado = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
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
    }
}
