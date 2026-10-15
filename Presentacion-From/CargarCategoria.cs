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
    public partial class CargarCategoria : Form
    {
        private Categoria categoria = null;
        private bool soloLectura = false;
        public CargarCategoria()
        {
            InitializeComponent();
        }
        public CargarCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
        }
        public CargarCategoria(Categoria categoria, bool soloLectura)
        {
            InitializeComponent();
            this.categoria = categoria;
            this.soloLectura = soloLectura;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CategoriaNegocio negocio = new CategoriaNegocio();

            try
            {
                if (categoria == null)
                    categoria = new Categoria();

                categoria.Descripcion = txtDescripcion.Text;

                if (categoria.Id != 0)
                {
                    negocio.modificar(categoria);
                    MessageBox.Show("Operacion realizada con exito");
                }
                else
                {
                    negocio.agregar(categoria);
                    MessageBox.Show("Operacion realizada con exito");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                if (categoria != null)
                {
                    txtDescripcion.Text = categoria.Descripcion;
                }

                if (soloLectura)
                {
                    this.Text = "Detalle de Categoria";
                    txtDescripcion.Enabled = false;
                    btnAceptar.Visible = false;
                    btnCancelar.Text = "Cerrar";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
