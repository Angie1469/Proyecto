using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data;
using System.Data.OracleClient;
using System.Windows.Forms;
using Proyecto;

namespace Proyecto
{
    public class ConectarBD
    {
        //Conexion con el servidor de la UDI
        //string ConexionUDI = "(DESCRIPTION =(ADDRESS =(PROTOCOL =TCP)(HOST = 192.168.254.215)(PORT = 1521)) (CONNECT_DATA =(SERVICE_NAME = orcl)) )";
        //private string connectionString = "DATA SOURCE="+ConexionUDI+"; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";

        //Conexión con la base de datos local
        private string connectionString = "DATA SOURCE=XE; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
        private OracleConnection connection;

        public ConectarBD(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public OracleConnection OpenConnection()
        {
            if (connection == null)
            {
                connection = new OracleConnection(connectionString);
            }

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            return connection;
        }

        public void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
