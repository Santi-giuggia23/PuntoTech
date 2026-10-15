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

    public partial class frmArticulo : Form
    {
        private Articulo articulo = null;
        private bool soloLectura = false;

        public frmArticulo()
        {
            InitializeComponent();
        }

        public frmArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        public frmArticulo(Articulo articulo, bool soloLectura)
        {
            InitializeComponent();
            this.articulo = articulo;
            this.soloLectura = soloLectura;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtImagenUrl.Text;
                articulo.Precio = numPrecio.Value;
                articulo.Stock = (int)numStock.Value;

                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Operacion realizada con exito");
                }
                else
                { 
                   negocio.agregar(articulo);
                   MessageBox.Show("Operacion realizada con exito");
                }
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtImagenUrl.Text = articulo.ImagenUrl;
                    numPrecio.Value = articulo.Precio;
                    numStock.Value = articulo.Stock;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                }

                if (soloLectura)
                {
                    this.Text = "Detalle de Articulo";
                    txtCodigo.Enabled = false;
                    txtNombre.Enabled = false;
                    txtDescripcion.Enabled = false;
                    txtImagenUrl.Enabled = false;
                    numPrecio.Enabled = false;
                    numStock.Enabled = false;
                    cboMarca.Enabled = false;
                    cboCategoria.Enabled = false;
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
