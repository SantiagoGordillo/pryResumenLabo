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
    public partial class frmVentanasEmergentes : Form
    {
        public frmVentanasEmergentes()
        {
            InitializeComponent();
        }

        private void btnFondo_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = colorDialog1.Color;
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            label1.Font = fontDialog1.Font;
        }

        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            MessageBox.Show(folderBrowserDialog1.SelectedPath);
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Archivos de texto|*.txt|Archivos Acrobat|*.pdf";
            openFileDialog1.ShowDialog();
            MessageBox.Show(openFileDialog1.FileName);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            MessageBox.Show(saveFileDialog1.FileName);
        }
    }
}
