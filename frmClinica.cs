using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryResumenLabo
{
    public partial class frmClinica : Form
    {
        clsEspecialidades E;
        clsMedicos M;
        DataTable tabla;
        public frmClinica()
        {
            InitializeComponent();
        }
        private void frmClinica_Load(object sender, EventArgs e)
        {
            grillaMedicos.Columns.Add("MATRICULA", "MATRICULA");
            grillaMedicos.Columns.Add("NOMBRE", "NOMBRE");
            grillaMedicos.Columns.Add("CELULAR", "CELULAR");

            try
            {
                E = new clsEspecialidades();
                cbEspecialidad.DisplayMember = "nombre";
                cbEspecialidad.ValueMember = "especialidad";
                cbEspecialidad.DataSource = E.getAll();

                M = new clsMedicos();
                tabla = M.getAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("PROBLEMAS CON LA BASE DE DATOS", "ERROR");
                this.Close();
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            grillaMedicos.Rows.Clear();

            int especialidad = Convert.ToInt32(cbEspecialidad.SelectedValue);

            foreach (DataRow fila in tabla.Rows)
            {
                if (Convert.ToInt32(fila["especialidad"]) == especialidad)
                {
                    grillaMedicos.Rows.Add(fila["matricula"], fila["nombre"], fila["celular"]);
                }
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lbMedicos.DisplayMember = "nombre";
            lbMedicos.ValueMember = "matricula";
            lbMedicos.DataSource = M.getAll();
        }
    }
}
