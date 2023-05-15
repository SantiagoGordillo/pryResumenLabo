using System;
using System.Collections.Generic;
using System.Data.OleDb; // Libreria para usar comandos oleDb, Base de datos (B)
using System.Data; // (B)
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryResumenLabo.Clases
{
    internal class clsPaises
    {
        private string cadena; // String al que se le pasa la direccion de la base de datos
        private OleDbConnection conector; // Establece la conexion con la base de datos
        private OleDbCommand comando; // Intruccion para la base de datos
        private OleDbDataAdapter adaptador; //
        private DataTable tabla; // Carga una tabla en memoria

        private int pais; // Variable pais usada en las propiedades
        private string nombre; // Variable nombre usada en las propiedades
        private string capital; // Variable capital usada en las propiedades

        public int Pais // Propiedad de la variable Pais
        {
            get { return pais; } // Devuelve el valor de pais
            set { pais = value; } // Le asiga el valor a pais
        }
        public string Nombre // Propiedad de la variable Nombre
        {
            get { return nombre; } // Devuelve el valor de nombre
            set { nombre = value; } // Le asiga el valor a nombre
        }
        public string Capital // Propiedad de la variable Capital
        {
            get { return capital; } // Devuelve el valor de capital
            set { capital = value; } // Le asiga el valor a capital
        }
        public clsPaises() // Contructor
        {
            cadena = "provider=microsoft.jet.oledb.4.0;data source=MUNDO.mdb"; // Le pasamos la cadena de conexion a la variable "cadena"
            conector = new OleDbConnection(cadena); // Inicializamos el conector y le pasamos la cadena
            comando = new OleDbCommand(); // Inicializamos el comando                                               *EJECUTA*
            comando.Connection = conector; // Configuracion del comando para este ejercicio puntual (C)
            comando.CommandType = CommandType.TableDirect; //(C)
            comando.CommandText = "Paises"; // (C)
            adaptador = new OleDbDataAdapter(comando); // Inicializamos el adaptador y le pasamos el comando        *DIRECCIONA*
            tabla = new DataTable(); // Inicializamos la tabla
            adaptador.Fill(tabla); // Sube la tabla a memoria

            DataColumn[] vector = new DataColumn[1]; // Hacemos una busqueda por clave (H)
            vector[0] = tabla.Columns["pais"]; // (H)
            tabla.PrimaryKey = vector; // (H)
        }
        public void grabar() // Funcion para grabar un pais
        {
            DataRow filaBuscar = tabla.Rows.Find(pais); // Crea un DataRow y busca la fila pais

            if (filaBuscar is null) // Si no se encuentra la fila solicitada, se agrega una nueva con los datos de pais, nombre y capital
            {
                DataRow fila = tabla.NewRow(); // Crea una nueba fila
                fila["pais"] = pais; // Le pasa el dato pais a la nueva fila
                fila["nombre"] = nombre; // Le pasa el dato nombre a la nueva fila
                fila["capital"] = capital; // Le pasa el dato capital a la nueva fila
                tabla.Rows.Add(fila); // Agregamos la nueva fila a la tabla
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador); // Inicializamos un CommandBuilder
                adaptador.Update(tabla); // Subimos los cambios
            }
            else
            {
                pais = -1; // Si el pais existe, se devuelve -1
            }
        }
        public void eliminar() // Funcion para eliminar un pais
        {
            DataRow filaBuscar = tabla.Rows.Find(pais); // Crea un DataRow y busca la fila pais

            if (filaBuscar is null) // Si no se encuentra la fila solicitada devuelve una alerta
            {
                pais = -1; // Si el pais no existe, se devuelve -1
            }
            else // De lo contrario, borra la fila
            {
                filaBuscar.Delete(); // Elimina la fila encontrada
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador); // Inicializamos un CommandBuilder
                adaptador.Update(tabla); // Subimos los cambios
            }
        }
        public void modificar() // Funcion para modificar un pais
        {
            DataRow filaBuscar = tabla.Rows.Find(pais); // Crea un DataRow y busca la fila pais

            if (filaBuscar is null) // Si no se encuentra la fila solicitada devuelve una alerta
            {
                pais = -1; // Si el pais no existe, se devuelve -1
            }
            else // De lo contrario, borra la fila
            {
                filaBuscar.BeginEdit(); // Pone el DataRow en modo de edicion
                filaBuscar["nombre"] = nombre; // carga los nuevos valores de nombre
                filaBuscar["capital"] = capital; // carga los nuevos valores de capital
                filaBuscar.EndEdit(); // Saca el DataRow en modo de edicion
                OleDbCommandBuilder cb = new OleDbCommandBuilder(adaptador); // Inicializamos un CommandBuilder
                adaptador.Update(tabla); // Subimos los cambios
            }
        }
        public void buscar() // Funcion para buscar un pais
        {
            DataRow filaBuscar = tabla.Rows.Find(pais); // Crea un DataRow y busca la fila pais

            if (filaBuscar is null) // Si no se encuentra la fila solicitada devuelve una alerta
            {
                pais = -1; // Si el pais no existe, se devuelve -1
            }
            else // Si encuentra la fila:
            {
                nombre = filaBuscar["nombre"].ToString(); // Se le pasa el valor encontrado a la variable nombre
                capital = filaBuscar["capital"].ToString(); // Se le pasa el valor encontrado a la variable capital
            }
        }
        public DataTable getAll() // Funcion que devuelve la tabla completa
        {
            return tabla; // Devuelve la tabla
        }
    }
}
