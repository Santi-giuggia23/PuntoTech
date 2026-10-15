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
using System.Net;
using System.Data.SqlClient;
using System.IO;


namespace Presentacion_From
{
    public partial class Control : Form
    {
        private List<Articulo> listaArticulos;

        private static readonly string carpetaRecursos = Path.Combine(Application.StartupPath, "Recursos");
        private static readonly string rutaLogo = Path.Combine(carpetaRecursos, "logo.png");
        private static readonly string rutaSinImagen = Path.Combine(carpetaRecursos, "sin_imagen.png");
        private static readonly string carpetaImagenesArticulos = Path.Combine(carpetaRecursos, "articulos");

        public Control()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(rutaLogo))
                    pbxLogo.Image = Image.FromFile(rutaLogo);
            }
            catch (Exception)
            {
            }

            cargar();
        }

        private void mostrarImagenNoDisponible()
        {
            try
            {
                if (File.Exists(rutaSinImagen))
                    pbxArticulo.Image = Image.FromFile(rutaSinImagen);
            }
            catch (Exception)
            {
            }
        }

        private void mostrarImagenDe(Articulo art)
        {
            if (art == null)
            {
                mostrarImagenNoDisponible();
                return;
            }

            if (!string.IsNullOrWhiteSpace(art.Codigo))
            {
                string rutaLocal = Path.Combine(carpetaImagenesArticulos, art.Codigo + ".png");
                if (File.Exists(rutaLocal))
                {
                    try
                    {
                        pbxArticulo.Image = Image.FromFile(rutaLocal);
                        return;
                    }
                    catch (Exception)
                    {
                    }
                }
            }

            cargarImagenArticulo(art.ImagenUrl);
        }

        private void cargarImagenArticulo(string url)
        {
            if (string.IsNullOrWhiteSpace(url))
            {
                mostrarImagenNoDisponible();
                return;
            }

            try
            {
                ServicePointManager.SecurityProtocol |= SecurityProtocolType.Tls12;

                using (WebClient cliente = new WebClient())
                {
                    cliente.Headers.Add(HttpRequestHeader.UserAgent,
                        "GestionDeArticulos-TP/1.0 (proyecto academico; escritorio WinForms)");
                    byte[] datos = cliente.DownloadData(url);
                    using (MemoryStream ms = new MemoryStream(datos))
                    using (Image imagenDescargada = Image.FromStream(ms))
                    {
                        pbxArticulo.Image = new Bitmap(imagenDescargada);
                    }
                }
            }
            catch (Exception)
            {
                mostrarImagenNoDisponible();
            }
        }

        private void cargar ()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulo.DataSource = listaArticulos;
                dgvArticulo.Columns[0].Visible = false;
                dgvArticulo.Columns[4].Visible = false;

                dgvArticulo.ReadOnly = true;
                dgvArticulo.AllowUserToAddRows = false;
                dgvArticulo.AllowUserToDeleteRows = false;

                if (listaArticulos.Count > 0)
                {
                    mostrarImagenDe(listaArticulos[0]);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulo.SelectedRows.Count == 0)
                return;

            Articulo art = dgvArticulo.CurrentRow.DataBoundItem as Articulo;
            mostrarImagenDe(art);
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            frmArticulo nuevaVentana = new frmArticulo();
            nuevaVentana.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;

            frmArticulo nuevaVentana = new frmArticulo(seleccionado);
            nuevaVentana.ShowDialog();
            cargar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            try
            {
                if (MessageBox.Show("¿Seguro que quieres eliminar este articulo?","Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                negocio.eliminarFisico(seleccionado.Id);
                cargar();
                }
            }
            catch (SqlException ex)
            {
              MessageBox.Show("No se pudo eliminar correctamente..." + ex.ToString());
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            filtro();
        }

        private void cmbBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            filtro();
        }

        private void filtro()
        {
            string buscar = txtBuscar.Text;

            if (buscar == "" || buscar.Length <=2)
            {
                dgvArticulo.DataSource = null;
                dgvArticulo.DataSource = listaArticulos;
            }
            else
            {
                List<Articulo> listaBuscar = listaArticulos.FindAll(x => x.Codigo.ToUpper().Contains(buscar.ToUpper()) || x.Nombre.ToUpper().Contains(buscar.ToUpper()) || x.Descripcion.ToUpper().Contains(buscar.ToUpper()));
                dgvArticulo.DataSource = null;
                dgvArticulo.DataSource = listaBuscar;
            }

            dgvArticulo.Columns[0].Visible = false;
            dgvArticulo.Columns[4].Visible = false;
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            frmArticulo detalle = new frmArticulo(seleccionado, true);
            detalle.Show();
        }

    }

}
