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

            Abuelo = tvDatos.Nodes.Add("ALIMENTOS", "ALIMENTOS", 0, 3);

            Padre = Abuelo.Nodes.Add("FRUTAS", "FRUTAS", 1, 3);
            Hijo = Padre.Nodes.Add("UVA", "UVA", 2, 3);
            Hijo.Tag = "300";
            Hijo = Padre.Nodes.Add("PERA", "PERA", 2, 3);
            Hijo.Tag = "400";
            Hijo = Padre.Nodes.Add("NARANJA", "NARANJA", 2, 3);
            Hijo.Tag = "500";

            Padre = Abuelo.Nodes.Add("VERDURAS", "VERDURAS", 1, 3);

            Hijo = Padre.Nodes.Add("ACELGA", "ACELGA", 2, 3);
            Hijo.Tag = "600";
            Hijo = Padre.Nodes.Add("LECHUGA", "LECHUGA", 2, 3);
            Hijo.Tag = "700";
            Hijo = Padre.Nodes.Add("REPOLLO", "REPOLLO", 2, 3);
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
