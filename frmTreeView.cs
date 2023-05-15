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
    public partial class frmTreeView : Form
    {
        public frmTreeView()
        {
            InitializeComponent();
        }
        private void frmTreeView_Load(object sender, EventArgs e)
        {
            TreeNode Abuelo;
            TreeNode Padre;
            TreeNode Hijo;

            Abuelo = tvDatos.Nodes.Add("ALIMENTOS", "ALIMENTOS");

            Padre = Abuelo.Nodes.Add("FRUTAS", "FRUTAS");
            Hijo = Padre.Nodes.Add("UVA", "UVA");
            Hijo.Tag = "300";
            Hijo = Padre.Nodes.Add("PERA", "PERA");
            Hijo.Tag = "400";
            Hijo = Padre.Nodes.Add("NARANJA", "NARANJA");
            Hijo.Tag = "500";

            Padre = Abuelo.Nodes.Add("VERDURAS", "VERDURAS");

            Hijo = Padre.Nodes.Add("ACELGA", "ACELGA");
            Hijo.Tag = "600";
            Hijo = Padre.Nodes.Add("LECHUGA", "LECHUGA");
            Hijo.Tag = "700";
            Hijo = Padre.Nodes.Add("REPOLLO", "REPOLLO");
            Hijo.Tag = "700";
        }
        private void tvDatos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 2)
            {
                MessageBox.Show("El precio por kilo es :" + e.Node.Tag.ToString());
            }
        }
    }
}
