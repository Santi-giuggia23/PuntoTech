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
    public partial class frmVenta : Form
    {
        private List<Articulo> articulos;
        private List<DetalleVenta> carrito = new List<DetalleVenta>();

        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                articulos = negocio.listar();
                cboArticulo.DataSource = articulos;
                cboArticulo.DisplayMember = "Nombre";
                cboArticulo.ValueMember = "Id";
                numCantidad.Minimum = 1;
                numCantidad.Value = 1;
                actualizarStockDisponible();
                calcularTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cboArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarStockDisponible();
        }

        private void actualizarStockDisponible()
        {
            Articulo seleccionado = cboArticulo.SelectedItem as Articulo;
            if (seleccionado == null)
            {
                lblStockValor.Text = "-";
                return;
            }

            int yaEnCarrito = carrito.Where(d => d.Articulo.Id == seleccionado.Id).Sum(d => d.Cantidad);
            int disponible = seleccionado.Stock - yaEnCarrito;
            lblStockValor.Text = disponible.ToString();
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            Articulo seleccionado = cboArticulo.SelectedItem as Articulo;
            if (seleccionado == null)
            {
                MessageBox.Show("Seleccione un artículo.");
                return;
            }

            int cantidad = (int)numCantidad.Value;
            int yaEnCarrito = carrito.Where(d => d.Articulo.Id == seleccionado.Id).Sum(d => d.Cantidad);

            if (cantidad + yaEnCarrito > seleccionado.Stock)
            {
                MessageBox.Show("No hay stock suficiente. Stock disponible: " + (seleccionado.Stock - yaEnCarrito));
                return;
            }

            DetalleVenta existente = carrito.FirstOrDefault(d => d.Articulo.Id == seleccionado.Id);
            if (existente != null)
            {
                existente.Cantidad += cantidad;
            }
            else
            {
                DetalleVenta detalle = new DetalleVenta();
                detalle.Articulo = seleccionado;
                detalle.Cantidad = cantidad;
                detalle.PrecioUnitario = seleccionado.Precio;
                carrito.Add(detalle);
            }

            refrescarGrilla();
            calcularTotal();
            actualizarStockDisponible();
        }

        private void btnQuitarItem_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una línea de la grilla para quitar.");
                return;
            }

            int indice = dgvDetalle.CurrentRow.Index;
            if (indice >= 0 && indice < carrito.Count)
            {
                carrito.RemoveAt(indice);
                refrescarGrilla();
                calcularTotal();
                actualizarStockDisponible();
            }
        }

        private void refrescarGrilla()
        {
            dgvDetalle.Rows.Clear();
            foreach (DetalleVenta detalle in carrito)
            {
                dgvDetalle.Rows.Add(
                    detalle.Articulo.Nombre,
                    detalle.Cantidad,
                    detalle.PrecioUnitario.ToString("C"),
                    detalle.Subtotal.ToString("C"));
            }
        }

        private void calcularTotal()
        {
            decimal total = carrito.Sum(d => d.Subtotal);
            lblTotalValor.Text = total.ToString("C");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (carrito.Count == 0)
            {
                MessageBox.Show("Agregue al menos un artículo antes de confirmar la venta.");
                return;
            }

            try
            {
                Venta venta = new Venta();
                venta.Fecha = DateTime.Now;
                venta.Usuario = Sesion.UsuarioActual;
                venta.Detalle = carrito;
                venta.Total = carrito.Sum(d => d.Subtotal);

                VentaNegocio negocio = new VentaNegocio();
                negocio.registrar(venta);

                MessageBox.Show("Venta registrada con éxito. Total: " + venta.Total.ToString("C"));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la venta:\n" + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
