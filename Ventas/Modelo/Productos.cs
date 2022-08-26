using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Modelo
{
    class Productos
    {
        public int IDProductos { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnitario { get; set; }
        public int Existencias { get; set; }
    }
}
