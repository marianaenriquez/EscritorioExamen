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
    public partial class compras : Form
    {
        public compras()
        {
            InitializeComponent();
        }

        private void compras_Load(object sender, EventArgs e)
        {
            dtgcompras.Rows.Clear();
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
                    if (ListaP[p - 1].Existencias <= 100)
                    {                        
                        n = dtgcompras.Rows.Add();
                        dtgcompras.Rows[n].Cells[0].Value = n + 1;
                        dtgcompras.Rows[n].Cells[1].Value = ListaP[p - 1].Titulo;                        
                        dtgcompras.Rows[n].Cells[2].Value = ListaP[p - 1].Descripcion;
                        dtgcompras.Rows[n].Cells[3].Value = ListaP[p - 1].Existencias;
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("No hay ventas");
            }
        }
    }
    
}
