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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            InitializeComponent();
        }

        private void frmListView_Load(object sender, EventArgs e)
        {
            string[] comidas = {
                "POLLO AL HORNO",
                "ALBONIDAS CON PURE",
                "PATO A LA NARANJA",
                "EMPANADAS ARABES",
                "SOPA DE VERDURAS",
                "POLLO AL HORNO",
                "ALBONIDAS CON PURE",
                "PATO A LA NARANJA",
                "EMPANADAS ARABES",
                "SOPA DE VERDURAS",
                "POLLO AL HORNO",
                "ALBONIDAS CON PURE",
                "PATO A LA NARANJA",
                "EMPANADAS ARABES",
                "SOPA DE VERDURAS",
                "POLLO AL HORNO",
                "ALBONIDAS CON PURE",
                "PATO A LA NARANJA",
                "EMPANADAS ARABES",
                "SOPA DE VERDURAS"

            };

            foreach (string comida in comidas)
            {
                ListViewItem lvi = lv.Items.Add(comida);
                lvi.Tag = "xxx";
            }
        }
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lv.Items)
            {
                if (lvi.Checked == true)
                {
                    MessageBox.Show(lvi.Text);
                }
            }
        }
    }
}
