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
    public partial class frmFrutas : Form
    {
        public frmFrutas()
        {
            InitializeComponent();
        }

        private void consultarAlumnosPorParteDeSuNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmBuscarNombre().ShowDialog();
        }
    }
}
