using pryResumenLabo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryResumenLabo
{
    public partial class frmAgregarAlumno : Form
    {
        clsAlumnos a;
        clsBarrios b;
        public frmAgregarAlumno()
        {
            InitializeComponent();
        }

        private void frmAgregarAlumno_Load(object sender, EventArgs e)
        {
            b = new clsBarrios();
            b.cargarCombo(cbBarrio);
            a = new clsAlumnos();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                a.Dni = Convert.ToInt32(txtDni.Text);
                a.Nombre = txtNombre.Text;
                if (rbF.Checked == true)
                {
                    a.Sexo = "F";
                }
                else
                {
                    a.Sexo = "M";
                }
                a.Foto = txtFoto.Text;
                a.Barrio = Convert.ToInt32(cbBarrio.SelectedValue);

                a.grabar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("NO SE PUDO GRABAR EL REGISTRO", "ERROR");
            }
        }
    }
}
