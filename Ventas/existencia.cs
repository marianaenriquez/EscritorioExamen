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
    public partial class existencia : Form
    {
        public existencia()
        {
            InitializeComponent();
        }

        private void existencia_Load(object sender, EventArgs e)
        {
            dtgprod.Rows.Clear();
            var Consulta = new ValuesController();

            var ListaV = Consulta.ConsultaMasV();
            var ListaP = Consulta.ConsultaProducto();
            int v = ListaV.Count();
            int n = 0, p = 0;
           
            if (v != 0)
            {
                for (int i = 0; i <= v - 1; i++)
                {
                    p = ListaV[i].IDProductos;                
                    n = dtgprod.Rows.Add();
                    dtgprod.Rows[n].Cells[0].Value = i + 1;
                    dtgprod.Rows[n].Cells[1].Value = ListaP[p - 1].Titulo;
                    dtgprod.Rows[n].Cells[2].Value = ListaP[p - 1].Existencias;
                    dtgprod.Rows[n].Cells[3].Value = ListaV[i].CantidadVendida;
                }
            }
            else
            {
                MessageBox.Show("No hay ventas");
            }
        }
    }
}
