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
    public partial class frmHistorialVentas : Form
    {
        public frmHistorialVentas()
        {
            InitializeComponent();
        }

        private void frmHistorialVentas_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void cargar()
        {
            VentaNegocio negocio = new VentaNegocio();
            try
            {
                dgvVentas.Rows.Clear();
                List<Venta> ventas = negocio.listar();
                foreach (Venta v in ventas)
                {
                    dgvVentas.Rows.Add(v.Id, v.Fecha.ToString("dd/MM/yyyy HH:mm"), v.Usuario.NombreUsuario, v.Total.ToString("C"));
                }

                decimal totalGeneral = ventas.Sum(v => v.Total);
                lblTotal.Text = "Total de ventas (" + ventas.Count + "): " + totalGeneral.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null)
            {
                MessageBox.Show("Seleccione una venta.");
                return;
            }

            int idVenta = (int)dgvVentas.CurrentRow.Cells[0].Value;
            VentaNegocio negocio = new VentaNegocio();
            try
            {
                List<DetalleVenta> detalle = negocio.listarDetalle(idVenta);
                StringBuilder texto = new StringBuilder();
                texto.AppendLine("Detalle de la venta #" + idVenta + ":");
                texto.AppendLine();
                foreach (DetalleVenta d in detalle)
                {
                    texto.AppendLine(d.Articulo.Nombre + " x " + d.Cantidad + " = " + d.Subtotal.ToString("C"));
                }
                MessageBox.Show(texto.ToString(), "Detalle de venta");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
