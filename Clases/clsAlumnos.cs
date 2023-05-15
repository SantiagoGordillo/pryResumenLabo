using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace pryResumenLabo.Clases
{
    internal class clsAlumnos
    {
        private string cadena;
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        private clsBarrios b;

        public clsAlumnos()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=COLEGIO.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Alumnos";
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);
            b = new clsBarrios();
        }
        public void ver(DataGridView dgv, string busco)
        {
            dgv.Rows.Clear();
            foreach (DataRow fila in tabla.Rows)
            {
                string sexo = "FEMENINO";
                if (fila["sexo"].ToString() == "M")
                {
                    sexo = "MASCULINO";
                }
                string nb = b.buscar(Convert.ToInt32(fila["barrio"]));
                int pos = fila["nombre"].ToString().IndexOf(busco);
                if (pos > -1)
                {
                    dgv.Rows.Add(fila["dni"], fila["nombre"], sexo, fila["foto"], nb);
                }
            }
        }
    }
}
