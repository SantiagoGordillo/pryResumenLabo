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
    public partial class frmArchivo : Form
    {
        public frmArchivo()
        {
            InitializeComponent();
        }
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Frutas.txt", true);
            sw.WriteLine(txtFrutas.Text);
            sw.Close();
            sw.Dispose();
        }
        private void btnFrutas_Click(object sender, EventArgs e)
        {
            string[] Frutas = { "Manzana", "Pera", "Naraja" };
            StreamWriter sw = new StreamWriter("Frutas.txt", false);

            foreach (string Fruta in Frutas)
            {
                sw.WriteLine(Fruta);
            }
            sw.Close();
            sw.Dispose();
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            string linea;
            StreamReader sr = new StreamReader("Frutas.txt");

            while (sr.EndOfStream != true)
            {
                linea = sr.ReadLine();
            }
            sr.Close();
            sr.Dispose();

            string[] Frutas = File.ReadAllLines("Frutas.txt");
            lvFrutas.Items.Clear();
            foreach (string fruta in Frutas)
            {
                ListViewItem item = new ListViewItem(fruta);
                lvFrutas.Items.Add(item);
            }
        }
    }
}
