using pryResumenLabo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryResumenLabo
{
    public partial class frmMundo : Form
    {
        clsPaises p = new clsPaises(); // Llamamos a la clase para poder usarla
        public bool estadoP, estadoN, estadoC; // Variables usadas para el estado de los botones
        public frmMundo()
        {
            InitializeComponent();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            p.Pais = Convert.ToInt32(txtPais.Text); // (P)
            p.buscar(); // Lamamos a la funcion buscar

            if (p.Pais == -1) // (NE)
            {
                MessageBox.Show("NO EXISTE EL PAIS QUE ESTA CONSULTANDO"); // (A)
                txtPais.Text = ""; // (L)
                txtNombre.Text = ""; // (L)
                txtCapital.Text = ""; // (L)
                txtPais.Focus(); // (T)
            }
            else // (SE)
            {
                txtNombre.Text = p.Nombre; // Se le pasa a la caja de texto el nombre del pais buscado
                txtCapital.Text = p.Capital; // Se le pasa a la caja de texto la capital del pais buscado
                txtPais.Focus(); // (T)
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            p.Pais = Convert.ToInt32(txtPais.Text); // (P)
            p.eliminar(); // Llama a la funcion eliminar

            if (p.Pais == -1) // (NE)
            {
                MessageBox.Show("PAIS NO EXISTENTE"); // (A)
                txtPais.Text = ""; // (L)
                txtNombre.Text = ""; // (L)
                txtCapital.Text = ""; // (L)
                txtPais.Focus(); // (T)
            }
            else // (SE)
            {
                txtPais.Text = ""; // (L)
                txtNombre.Text = ""; // (L)
                txtCapital.Text = ""; // (L)
                txtPais.Focus(); // (T)
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            p.Pais = Convert.ToInt32(txtPais.Text); // (P)
            p.Nombre = txtNombre.Text; // (P)
            p.Capital = txtCapital.Text; // (P)
            p.modificar(); // Llama a la funcion modificar

            if (p.Pais == -1) // (NE)
            {
                MessageBox.Show("PAIS NO EXISTENTE"); // (A)
                txtPais.Text = ""; // (L)
                txtNombre.Text = ""; // (L)
                txtCapital.Text = ""; // (L)
                txtPais.Focus(); // (T)
            }
            else // (SE)
            {
                txtPais.Text = ""; // (L)
                txtNombre.Text = ""; // (L)
                txtCapital.Text = ""; // (L)
                txtPais.Focus(); // (T)
            }
        }
        private void frmMundo_Load(object sender, EventArgs e)
        {
            grilla.DataSource = p.getAll(); // Llama a la funcion getAll y pasa la grilla al formulario
            grilla.AutoResizeColumns(); // Ajusta automaticamente el tamaño de la grilla

            btnGrabar.Enabled = false; // Deshabilita los botones al cargar el Form (F)
            btnModificar.Enabled = false; // (F)
            btnBuscar.Enabled = false; // (F)
            btnBorrar.Enabled = false; // (F)
        }
        private void txtPais_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtPais.Text))
            {
                estadoP = true;
            }
            else
            {
                estadoP = false;
            }

            estadoCajas(estadoP, estadoN, estadoC);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNombre.Text))
            {
                estadoN = true;
            }
            else
            {
                estadoN = false;
            }

            estadoCajas(estadoP, estadoN, estadoC);
        }

        private void txtCapital_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtCapital.Text))
            {
                estadoC = true;
            }
            else
            {
                estadoC = false;
            }

            estadoCajas(estadoP, estadoN, estadoC);
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            p.Pais = Convert.ToInt32(txtPais.Text); // Le pasamos los valores a la clase por medio de propiedades (P)
            p.Nombre = txtNombre.Text; // (P)
            p.Capital = txtCapital.Text; // (P)
            p.grabar(); // Llamamos a la funcion grabar

            if (p.Pais == -1) // Si el pais ya existe se ejecuta el siguiente codigo: (SE)
            {
                MessageBox.Show("PAIS REPETIDO, NO SE PUDO GRABAR"); // Mensaje de advertencia (A)
                txtPais.Text = ""; // Limpiamos las cajas de texto (L)
                txtNombre.Text = ""; // (L)
                txtCapital.Text = ""; // (L)
                txtPais.Focus(); // Centramos la caja de texto (T)
            }
            else // Si el pais no existe se ejecuta el siguiente codigo: (NE)
            {
                txtPais.Text = ""; // (L)
                txtNombre.Text = ""; // (L)
                txtCapital.Text = ""; // (L)
                txtPais.Focus(); // (T)
            }
        }
        public void estadoCajas(bool estado1, bool estado2, bool estado3)
        {
            if (estado1 && estado2 && estado3)
            {
                btnGrabar.Enabled = true;
                btnModificar.Enabled = true;
            }
            else
            {
                btnGrabar.Enabled = false;
                btnModificar.Enabled = false;
            }

            if (estado1)
            {
                btnBuscar.Enabled = true;
                btnBorrar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
                btnBorrar.Enabled = false;
            }
        }
    }
}
