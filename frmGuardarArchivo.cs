using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryResumenLabo
{
    public partial class frmGuardarArchivo : Form
    {
        public frmGuardarArchivo()
        {
            InitializeComponent();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sfdDatos.FileName = "";
            sfdDatos.ShowDialog();
            string archivo = sfdDatos.FileName;

            StreamWriter sw = new StreamWriter(archivo);
            sw.WriteLine(textBox1.Text);
            sw.Close();
            sw.Dispose();
        }
    }
}
