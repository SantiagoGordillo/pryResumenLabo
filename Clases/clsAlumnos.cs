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

        private int dni;
        private string nombre;
        private string sexo;
        private string foto;
        private int barrio;

        public int Dni                  // public int Dni
        {                               // {
            get => dni;                 //   get { return dni; }
            set => dni = value;         //   set { dni = value; }
        }                               // }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Sexo
        {
            get => sexo;
            set => sexo = value;
        }

        public string Foto
        {
            get => foto;
            set => foto = value;
        }
        public int Barrio
        {
            get => barrio;
            set => barrio = value;
        }
        //public Alumnos()
        //{
        //    conector = new OleDbConnection(Properties.Settings.Default.CADENA);
        //    comando = new OleDbCommand();

        //    comando.Connection = conector;
        //    comando.CommandType = CommandType.TableDirect;
        //    comando.CommandText = "Alumnos";

        //    adaptador = new OleDbDataAdapter(comando);
        //    tabla = new DataTable();
        //    adaptador.Fill(tabla);
        //}
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
        public void grabar()
        {
            DataRow fila = tabla.NewRow();
            fila["dni"] = dni;
            fila["nombre"] = nombre;
            fila["sexo"] = sexo;
            fila["foto"] = foto;
            fila["barrio"] = barrio;
            tabla.Rows.Add(fila);

            OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador);
            adaptador.Update(tabla);
        }
    }
}
