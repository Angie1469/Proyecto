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
using System.Collections;
using Proyecto;

namespace Proyecto
{
    public partial class FormDevolucion : Form
    {
        //Se genero una variable tipo tabla apra almacenar los pedidos traidos en la busqueda
        private static DataTable TablaDevoluciones;

        public FormDevolucion()
        {
            InitializeComponent();
            // Se inicializa el metodo para llenar el combobox
            llenarComboboxPedidos();
        }

        // Metodo para llenar el combobox con los datos de los pedidos 
        private void llenarComboboxPedidos()
        {
            //se trae el id del cliente guardado en la variable del sistema
            string id_comprobar = Properties.Settings.Default.Id_cliente;

            //se inicia la conexion con la base de datos
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                //se realiza la consulta
                OracleCommand comando = new OracleCommand("SELECT * FROM PEDIDO_HISTORIAL WHERE ID_CLIENTE = '"+id_comprobar+"'", connection);
                OracleDataReader lector = comando.ExecuteReader();

                //Se almacena los datos traidos en la consulta en un datatable
                TablaDevoluciones = new DataTable();
                TablaDevoluciones.Load(lector);

                // se recorre el datatable para llenar el combobox
                foreach (DataRow row in TablaDevoluciones.Rows)
                {
                    //LLena el combobox con los datos que se le indican
                    comboBoxPedido.Items.Add(row[0] + "-" + row[1]);
                }

                connection.Close();
            }
        }


        // Metodo para la describir el motivo de la devolucion del pedido
        public Devolucion CapturarMotivoDevolucion()
        {
            Devolucion iDevolucion = new Devolucion();
            iDevolucion.MotivoDevolucion = textBox1.Text;
            string NumeroPedido = comboBoxPedido.Text;
            foreach (DataTable row in TablaDevoluciones.Rows)
            {

            }


            return iDevolucion;

        }

        private void buttonAñadirM_Click_1(object sender, EventArgs e)
        {
           

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
