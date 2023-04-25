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
    }
}
