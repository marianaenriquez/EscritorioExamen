using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas.Servicio;

namespace Ventas
{
    public partial class masventas : Form
    {
        public masventas()
        {
            InitializeComponent();
        }

        private void masventas_Load(object sender, EventArgs e)
        {
            dtgmasv.Rows.Clear();
            var Consulta = new ValuesController();

            var ListaV = Consulta.ConsultaMasV();
            var ListaP = Consulta.ConsultaProducto();
            int v = ListaV.Count();
            int n = 0, p = 0;
            double pre = 0, tot=0;
            if (v != 0)
            {
                for (int i = 0; i <= v - 1; i++)
                {
                    p = ListaV[i].IDProductos;
                    pre = ListaP[p - 1].PrecioUnitario;
                    tot = ListaV[i].CantidadVendida * pre;
                    n = dtgmasv.Rows.Add();
                    dtgmasv.Rows[n].Cells[0].Value = i + 1;
                    dtgmasv.Rows[n].Cells[1].Value = ListaP[p - 1].Titulo;
                    dtgmasv.Rows[n].Cells[2].Value = ListaV[i].CantidadVendida;
                    dtgmasv.Rows[n].Cells[3].Value = tot;
                }
            }
            else
            {
                MessageBox.Show("No hay ventas");
            }
        }
    }
}
