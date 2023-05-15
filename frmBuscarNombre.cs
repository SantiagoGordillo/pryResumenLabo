using pryResumenLabo.Clases;
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
    public partial class frmBuscarNombre : Form
    {
        DataTable tabla;
        clsAlumnos a;
        public frmBuscarNombre()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDatos.Rows.Clear();

            a.ver(dgvDatos, txtBusco.Text);
        }
        private void frmBuscarNombre_Load(object sender, EventArgs e)
        {
            a = new clsAlumnos();
        }
    }
}
