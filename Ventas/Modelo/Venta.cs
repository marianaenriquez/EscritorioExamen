using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelo
{
    class Venta
    {
        public int IDVentas { get; set; }
        public int IDProductos { get; set; }
        public int CantidadVendida { get; set; }
        public string Fecha { get; set; }
    }
}
