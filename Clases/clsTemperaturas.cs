using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryResumenLabo.Clases
{
    internal class clsTemperaturas
    {
        private string cadena;
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        private int localidad;
        private DateTime fecha;
        private int minima;
        private int maxima;
        public int Localidad
        {
            get { return localidad; }
            set { localidad = value; }
        }
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public int Minima
        {
            get { return minima; }
            set { minima = value; }
        }
        public int Maxima
        {
            get { return maxima; }
            set { maxima = value; }
        }
        public clsTemperaturas()
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=CLIMA.mdb";
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();
            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Temperaturas";
            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] vector = new DataColumn[2];
            vector[0] = tabla.Columns["localidad"];
            vector[1] = tabla.Columns["fecha"];
            tabla.PrimaryKey = vector;
        }
        public DataTable getAll()
        {
            return tabla;
        }
    }
}
