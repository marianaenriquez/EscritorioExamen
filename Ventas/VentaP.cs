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
    public partial class VentaP : Form
    {
        public VentaP()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var Consulta = new ValuesController();         
           
            var ListaV = Consulta.ConsultaVentaP(cmbProducto.SelectedIndex + 1);
            var ListaP = Consulta.ConsultaPro(cmbProducto.SelectedIndex + 1);
            int v = ListaV.Count();
            int n = 0;            
            if (v != 0)
            {
                for (int i = 0; i <= v - 1; i++)
                {

                    n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = i + 1;
                    dataGridView1.Rows[n].Cells[1].Value = ListaP[0].Titulo;
                    dataGridView1.Rows[n].Cells[2].Value = ListaV[i].CantidadVendida;
                    dataGridView1.Rows[n].Cells[3].Value = ListaV[i].Fecha;
                }
            }
            else
            {
                MessageBox.Show("No hay ventas con ese producto");
            }
            


        }
    }
}
