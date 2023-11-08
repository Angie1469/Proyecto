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

namespace Proyecto
{
    public partial class GestionarPedido : Form
    {

        // se genera una variabel de tipo tabla pra almacenar los datos que trae la busqueda enviada a oracle
        private static DataTable TablaMedicamento;
        private static string nombreMedicamento;

        public GestionarPedido()
        {
            //A penas ingrese al formulario se inicia el llenado de datos de los combobox 
            InitializeComponent();
            llenarComboboxdireccion();
            llenarComboboxMedicamento();
        }

        
        // taer los datos de las direcciones que se encuentran en la base de datos para el combo box  
        private void llenarComboboxdireccion ()
        {
            //se itiliza la variable id_cliene creada en el sistema para saber con el id correcto del cliente
            string id_comprobar = Properties.Settings.Default.Id_cliente;

            //Se activa la conexion con el oracle y el ususario creado con la base de datos del centro de acopio
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();
                
                //Se envia la busqueda quese necesita al oracle especificando los datos del cliente que se debe traer
                OracleCommand comando = new OracleCommand("SELECT * FROM cliente_direccion where idcliente = '"+ id_comprobar +"'", connection);
                OracleDataReader lector = comando.ExecuteReader();
                
                while (lector.Read())
                {
                    //Se le ingresan los datos de direcciones del cliente al combobox
                    comboBoxDireccion.Items.Add(lector.GetString(2));
                }
                connection.Close();
            }
        }

        //Metodo para traer con los datos de medicamento e id del lote que se encuentran en la base de datos para el combo box 
        private void llenarComboboxMedicamento()
        {

            //Se activa la conexion con el oracle y el ususario creado
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {

                connection.Open();

                // se envia la busqueda al oracle
                string BusquedaMedicamento = "SELECT * FROM MEDICAMENTO_INFO";
                OracleCommand comando = new OracleCommand(BusquedaMedicamento, connection);
                OracleDataReader lector = comando.ExecuteReader();

                //Se activa la tabla creada al inicio y se llena con los datos de la busqueda
                TablaMedicamento = new DataTable();
                TablaMedicamento.Load(lector);

                // se recorre cada dato en la datatable que se creo
                foreach (DataRow row in TablaMedicamento.Rows)
                {
                    //LLena el combobox con los datos que se le indican
                    comboBoxMedicamento.Items.Add(row[0] + "-" +row[2] );
                }

            }
        }


        // Metodo para agregar los datos del combo box al datagridview
        public void buttonAñadirM_Click_1(object sender, EventArgs e)
        {
            string[] valores = comboBoxMedicamento.Text.Split('-');

            //se recorre todos los datos de la datatable
            foreach (DataRow row in TablaMedicamento.Rows)
            {
                //se buscan cada uno de los precios que se guardaron en la tabla y se compara con los valores guardados en el combobox  
                if(row[0].Equals(valores[0]))
                {
                    //se cambia los signos que tienen los precios para poder operar el precio con la cantidades ques e ingresaron
                    String MiValor = row[5].ToString().Replace("$", "").Replace(".", "");
                    int ValorTotal=int.Parse(MiValor) * int.Parse(IngresoCantidad.Text);

                    //se envian los datos que apareceran en el datagridview
                    dataGridViewPedido.Rows.Add(row[0],row[2],row[3],row[5], IngresoCantidad.Text, ValorTotal.ToString() );
                }
            }
            
        }

        //Metodo para capturar los datos del datagridview y pasarlos almetodo constructor Factura
        public Factura CapturarPedido( )
        {
            Factura pFactura = new Factura();
            pFactura.fechaDeCreacion = DateTime.Now;
            int ValorTotal = 0;

            //recorre los datos ingresados en el datagridview
            foreach (DataGridViewRow row in dataGridViewPedido.Rows)
            {
                //condicional encargado de evitar los datos vacios y poder obtener todos los precios y operarlos para obtener el total
                if (row.Cells["Column5"].Value != null)
                {
                    // se usa un replece para quitar los signos ($) y (.) de los precios guardados en la base de datos y porder utilizarlos 
                    string Precio = row.Cells[3].Value.ToString().Replace("$", "").Replace(".", "");

                    // operacion para obtener el total a pagar
                    int ValorTotalItem = int.Parse(Precio) * int.Parse(row.Cells["Column4"].Value.ToString());
                    ValorTotal = ValorTotal + ValorTotalItem;

                    //Se ingresan en el array item factura los datos de las cantidades y los id de los lotes
                    ItemFactura MiItem = new ItemFactura(int.Parse(row.Cells["Column4"].Value.ToString()), row.Cells["Column1"].Value.ToString());
                    pFactura.ItemsFactura.Add(MiItem);
                }

            }
            // se guarda el total a pagar
            pFactura.totalApagar = ValorTotal;
            return pFactura;
        }

        // boton aceptar se encarga de llamar los metodos a utilizar para capturar y registar el pedido
        public void buttonCrearPedido_Click(object sender, EventArgs e)
        {
            string EntregaDireccion = comboBoxDireccion.Text;
            Datos1 registro = new Datos1();
            Factura pFactura = CapturarPedido();
            registro.registrarFacturaPedido(pFactura, EntregaDireccion);

            //Se le indica al datagridview que quede nuevamente vacio
            dataGridViewPedido.Rows.Clear();

        }

        // Se requiere traer la candtidad exacta de cada medicamento
        public string ConsultarCantidad()
        {
            // se genera una varible para capturar el resultado
            string DatoCantidad;

            //se establece la conexion con el oracle
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                // se envia la busqueda
                OracleCommand comando = new OracleCommand("SELECT l.CANTIDAD FROM LOTE L JOIN MEDICAMENTO M ON M.ID = L.ID_MEDICAMENTO JOIN NOMBRECOMERCIAL N ON M.ID = N.IDMEDICAMENTO WHERE L.ID ='"+ nombreMedicamento +"'", connection);
                OracleDataReader lector = comando.ExecuteReader();

                //Condicional para darle un valor a la variable Datocantidad
                if (lector.Read())
                {
                    DatoCantidad = lector ["CANTIDAD"].ToString();
                }
                else
                {
                    DatoCantidad = "null";
                }

                return DatoCantidad;
            }
        }

        //Metodo para mostar la cantidad disponible en un texbox del medicamento selecionado
        private void comboBoxMedicamento_SelectedValueChanged(object sender, EventArgs e)
        {
            // se asigna el medicamento selecionado a la variable nombreMedicamento
            nombreMedicamento = comboBoxMedicamento.Text.Split('-')[0];
            //Se tare la cantidad solicitada
            String miValor = ConsultarCantidad();
            //Se muestra la cantidad en el texbox
            textMostrarCantidad.Text = miValor;
        }

        //Se elimina lo selecionado en el datagridview
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            dataGridViewPedido.Rows.Remove(dataGridViewPedido.CurrentRow);
        }

        //la opcion de salir del fromulario (boton cancelar)
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
