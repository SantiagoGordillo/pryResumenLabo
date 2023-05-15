using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryResumenLabo.Clases
{
    internal class clsLocalidades
    {
        private string cadena;
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        private int localidad;
        private string nombre;
        public int Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public clsLocalidades()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=CLIMA.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Localidades";
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] vector = new DataColumn[1];
            vector[0] = tabla.Columns["localidad"];
            tabla.PrimaryKey = vector;
        }
        public DataTable getAll()
        {
            return tabla;
        }
    }
}
