using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentaP ventap = new VentaP();
            ventap.ShowDialog();
        }

        private void existenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            existencia ex = new existencia();
            ex.ShowDialog();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ventasG vg = new ventasG();
            vg.ShowDialog();

        }

        private void masVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            masventas mv = new masventas();
            mv.ShowDialog();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compras com = new compras();
            com.ShowDialog();
        }
    }
}
