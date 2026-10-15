using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public Usuario Usuario { get; set; }
        public decimal Total { get; set; }
        public List<DetalleVenta> Detalle { get; set; }

        public Venta()
        {
            Detalle = new List<DetalleVenta>();
        }
    }
}
