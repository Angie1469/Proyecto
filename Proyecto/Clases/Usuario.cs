using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OracleClient;
using System.Data;

namespace Proyecto
{
    public class Usuario
    {
        public string nombre;
        public string contraseña;
        public string rol;
        public string id_cliente;

        //Metodo constructor de usuario
        public Usuario()
        {
            this.nombre = "";
            this.contraseña = "";
            this.rol = null;
            this.id_cliente = null; 
        }

        //Metodo para validar credenciales
        public Usuario validarDatos(Usuario vUsuario)
        {               

            //se utiliza el metodo creado para la conexion de la base de datos y comporbar la valides de los usuario
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    // se inicia la conexion y se crea la tabla que llevara los datos traidos de la base de datos
                    connection.Open();
                    DataSet dt = new DataSet();

                    //Se envia la busqueda al oracle 
                    OracleCommand cmd = new OracleCommand("SELECT ROL, ID_CLIENTE FROM USUARIO WHERE NOMBRE='" + vUsuario.nombre.ToUpper() + "' AND CONTRASENA='" + vUsuario.contraseña + "'", connection);
                    cmd.CommandType = CommandType.Text;

                    // se traen los datos de la busqueda y se llena la tabla creada al inicio
                    using (OracleDataAdapter dataAdapter = new OracleDataAdapter())
                    {
                        dataAdapter.SelectCommand = cmd;
                        dataAdapter.Fill(dt);
                    }

                    DataTable myTable = dt.Tables[0];

                    //condicional que nos indica si la tabla trajo resultados y se retorna el resultado obtenido
                   if (myTable.Rows.Count == 1)
                    {
                        vUsuario.rol = myTable.Rows[0][0].ToString();
                        vUsuario.id_cliente = myTable.Rows[0][1].ToString();
                    }
                    else
                    {
                        vUsuario.rol = "INCORRECTO";
                    }

                    connection.Close();
                }
                catch (Exception e)
                {
                    vUsuario.rol = "INCORRECTO";
                }
                finally
                { 
                }
                return vUsuario;
            }
 
        }

    }
}
