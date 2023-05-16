using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryResumenLabo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void btnClinica_Click(object sender, EventArgs e)
        {
            new frmClinica().ShowDialog();
        }
        private void btnTreeView_Click(object sender, EventArgs e)
        {
            new frmTreeView().ShowDialog();
        }
        private void btnArchivo_Click(object sender, EventArgs e)
        {
            new frmArchivo().ShowDialog();
        }
        private void btnDato_Click(object sender, EventArgs e)
        {
            new frmTemperaturaCiudad().ShowDialog();
        }
        private void btnFrutas_Click(object sender, EventArgs e)
        {
            new frmFrutas().ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new frmMundo().ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new frmGuardarArchivo().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new frmVentanasEmergentes().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new frmListView().ShowDialog();
        }
    }
}
