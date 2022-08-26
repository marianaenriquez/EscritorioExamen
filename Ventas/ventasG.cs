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
    public partial class ventasG : Form
    {
        public ventasG()
        {
            InitializeComponent();
        }

        private void ventasG_Load(object sender, EventArgs e)
        {
            dtgventas.Rows.Clear();
            var Consulta = new ValuesController();

            var ListaV = Consulta.ConsultaVenta();
            var ListaP = Consulta.ConsultaProducto();
            int v = ListaV.Count();
            int n = 0;
            int p = 0;
            if (v != 0)
            {
                for (int i = 0; i <= v - 1; i++)
                {
                    p = ListaV[i].IDProductos;
                    n = dtgventas.Rows.Add();
                    dtgventas.Rows[n].Cells[0].Value = i + 1;
                    dtgventas.Rows[n].Cells[1].Value = ListaP[p - 1].Titulo;
                    dtgventas.Rows[n].Cells[2].Value = ListaV[i].CantidadVendida;
                    dtgventas.Rows[n].Cells[3].Value = ListaV[i].Fecha;
                }
            }
            else
            {
                MessageBox.Show("No hay ventas");
            }
        }
    }
}
