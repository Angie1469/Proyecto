using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OracleClient;
using Proyecto;
using System.Collections;


namespace Proyecto
{

    public partial class FormHistorial : Form
    {
        //se declara una variable de tipo datatable
        private static DataTable TablaPedido;

        public FormHistorial()
        {
            InitializeComponent();
            //Se inicia el metodo para llenar el combobox
            llenarComboboxPedidos();
        }

        //Metodo para llenar el combo box con datos de pedidos de la base de datos
        private void llenarComboboxPedidos()
        {
            //Se trae la variable del id del cliente guardada en el sistema
            string ID_comprobar = Properties.Settings.Default.Id_cliente;

            //se hace la conexion con oracle
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                //Se realiza la consulta
                String consulta = "SELECT * FROM PEDIDO_HISTORIAL WHERE ID_CLIENTE ='"+ ID_comprobar +"'";
                OracleCommand comando = new OracleCommand(consulta, connection);
                OracleDataReader lector = comando.ExecuteReader();
                
                //Se almacenan los datos traidos por la consulta en un datatable 
                TablaPedido = new DataTable();
                TablaPedido.Load(lector);

                //Se recorre la tabla para llenar el combobox
                foreach (DataRow row in TablaPedido.Rows)
                {
                    ComboPedidos.Items.Add(row[0] + " - " + row[1]);
                }
                connection.Close();
            }

        }

        // Metodo para agregar los datos de los pedidos hechos por el cliente del combobox al datagridview
        private void buttonVer_Click(object sender, EventArgs e)
        {
            //Se vacia el datagridview
            dataGridViewPedido.Rows.Clear();
            string[] valores = ComboPedidos.Text.Split('-');

            //se recorre la tabla con los datos de la busqueda anterior
            foreach (DataRow row in TablaPedido.Rows)
            {
                //Consicion para compara que los datos sean iguales 
                if (row[0].Equals(valores[0].Trim()))
                {
                    //se ingresan los datos en el datagridview
                    dataGridViewPedido.Rows.Add(row[0], row[1], row[2], row[3],row[4], row[5]);
                }
                    
            }

                   

                    
                    

        }

    }
}
