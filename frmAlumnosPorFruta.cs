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
    public partial class frmAlumnosPorFruta : Form
    {
        public frmAlumnosPorFruta()
        {
            InitializeComponent();
        }
        private void frmAlumnosPorFruta_Load(object sender, EventArgs e)
        {
            clsFrutas f = new clsFrutas();
            clsLeGustan lg = new clsLeGustan();

            DataTable tf = f.getFrutas();
            DataTable tlg = lg.getLeGustan();

            foreach (DataRow ff in tf.Rows)
            {
                int can = 0;
                foreach (DataRow flg in tlg.Rows)
                {
                    if (ff["fruta"].ToString() == flg["fruta"].ToString())
                    {
                        can++;
                    }
                }
                gv.Rows.Add(ff["nombre"], can);
            }
        }
    }
}
