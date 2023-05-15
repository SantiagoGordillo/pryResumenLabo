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
    public partial class frmTemperaturaCiudad : Form
    {
        clsLocalidades Localidad = new clsLocalidades();
        clsTemperaturas Temperatura = new clsTemperaturas();
        public frmTemperaturaCiudad()
        {
            InitializeComponent();
        }
        private void frmTemperaturaCiudad_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string localidad = cbLocalidades.SelectedValue.ToString();
            string fechaUsuario = dtpFecha.Value.Date.ToString();

            buscar(fechaUsuario);
        }
        public void cargar()
        {
            cbLocalidades.DisplayMember = "nombre";
            cbLocalidades.ValueMember = "localidad";
            cbLocalidades.DataSource = Localidad.getAll();
        }
        public void buscar(string fechaBuscar)
        {
            foreach (DataRow fila in Temperatura.getAll().Rows)
            {
                if (fila["fecha"].ToString() == fechaBuscar && fila["localidad"].ToString() == cbLocalidades.SelectedValue.ToString())
                {
                    txtMinima.Text = fila["minima"].ToString();
                    txtMaxima.Text = fila["maxima"].ToString();
                }
            }
        }
    }
}
