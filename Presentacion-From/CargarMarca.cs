using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Modelo;

namespace Presentacion_From
{
    public partial class CargarMarca : Form
    {
        private Marca marca = null;
        private bool soloLectura = false;
        public CargarMarca()
        {
            InitializeComponent();
        }
        public CargarMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
        }
        public CargarMarca(Marca marca, bool soloLectura)
        {
            InitializeComponent();
            this.marca = marca;
            this.soloLectura = soloLectura;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaNegocio negocio = new MarcaNegocio();

            try
            {
                if (marca == null)
                    marca = new Marca();

                marca.Descripcion = txtDescripcion.Text;


                if (marca.Id != 0)
                {
                    negocio.modificar(marca);
                    MessageBox.Show("Operacion realizada con exito");
                }
                else
                {
                    negocio.agregar(marca);
                    MessageBox.Show("Operacion realizada con exito");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarMarca_Load(object sender, EventArgs e)
        {
            try
            {
                if (marca != null)
                {
                    txtDescripcion.Text = marca.Descripcion;
                }

                if (soloLectura)
                {
                    this.Text = "Detalle de Marca";
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
