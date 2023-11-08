using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OracleClient;

namespace Proyecto
{
    public partial class FormLoteIngreso : Form
    {
        //Se genera una variable de tipo fomulario ingresar datos que es la que permite tener una conexion con el formulario de ingresos
        public FormIngresarDatos MiPadre;
        //Se declaran dos tablas para almacenar los datos de las busquedas
        private static DataTable TablaMedicamento;
        private static DataTable TablaProveedor;
        private string Nombre;
        
        //Se especifica que recibira un datos ripo formularioIngresoDatos
        public FormLoteIngreso(FormIngresarDatos FormPadre)
        {
            InitializeComponent();
            //Se inician los metodos de llenar loscombobox 
            llenarComboboxMedicamento();
            llenarComboboxProveedor();
            //Se inicia el formulario que recibio en este caso eld e ingresar datos
            MiPadre = FormPadre;

        }

        //llenar el combo box de Medicamento
        private void llenarComboboxMedicamento()
        {
            //se establece la coenxion con oracle
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {

                connection.Open();
                
                //Se realiza la consulta
                string BusquedaMedicamento = "SELECT M.ID, N.NOMBRE FROM MEDICAMENTO M JOIN NOMBRECOMERCIAL N ON M.ID = N.IDMEDICAMENTO";
                OracleCommand comando = new OracleCommand(BusquedaMedicamento, connection);
                OracleDataReader lector = comando.ExecuteReader();

                //Se alamacenan los datos de la busqueda en la tabla
                TablaMedicamento = new DataTable();
                TablaMedicamento.Load(lector);

                // se recorre cada dato en la datatable que se creo
                foreach (DataRow row in TablaMedicamento.Rows)
                {
                    //LLena el combobox con los datos que se le indican
                    comboBoxMedicamento.Items.Add(row[1]);

                }

            }
        }

        //Metodo para llenar el combobox con los datos de la busqueda proveedor
        private void llenarComboboxProveedor()
        {
            //se establece la coenxion con oracle
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {

                connection.Open();

                //Se realiza la consulta
                string BusquedaMedicamento = "SELECT * FROM PROVEEDOR";
                OracleCommand comando = new OracleCommand(BusquedaMedicamento, connection);
                OracleDataReader lector = comando.ExecuteReader();

                //Se alamacenan los datos de la busqueda en la tabla
                TablaProveedor = new DataTable();
                TablaProveedor.Load(lector);

                // se recorre cada dato en la datatable que se creo
                foreach (DataRow row in TablaProveedor.Rows)
                {

                    //LLena el combobox con los datos que se le indican
                    comboBoxProveedor.Items.Add(row[1]);

                }

                connection.Close();

            }
        }

        //Metodo para capturar los datos del lote nuevo
        public Lote CapturarLote()
        {
            Lote pLote = new Lote();
            pLote.cantidad = int.Parse(textBoxCantidad.Text);
            pLote.fechaIngreso = DateTime.Now;
            pLote.fechaVencimiento = textBoxFechaVencimiento.Text;

            string[] IdentificadorMed = comboBoxMedicamento.Text.Split('-');
            string[] IdentificadorProv = comboBoxProveedor.Text.Split('-');

            //se recorren las tablas creadas en busca de el id de medicamento y proveedor
            foreach (DataRow row in TablaMedicamento.Rows)
            {
                if (row[1].Equals(IdentificadorMed[0].Trim()))
                {
                    pLote.id_medicamento = row[0].ToString();
                    Nombre = row[1].ToString();
                }
            }

            foreach (DataRow row in TablaProveedor.Rows)
            {
                if (row[1].Equals(IdentificadorProv[0].Trim()))
                {
                    pLote.id_proveedor = row[0].ToString();
                }
            }

            MiPadre.AlmacenartoLote(pLote);

            return pLote;
        }

        //Evento del boton añadir para enviar los datos al datagridview
        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            //Se llama capturar lote
            Lote AñadirLote = new Lote();
            AñadirLote = CapturarLote();
            //Se envian los datos al datagribviw especificando el formulario donde se encuentar
            MiPadre.dataGridViewMeidcamentoLote.Rows.Add(Nombre, AñadirLote.fechaVencimiento, AñadirLote.cantidad );

            //Se vacian losd atos de los tex y combobox despeus de añadir
            textBoxCantidad.Clear();
            textBoxFechaVencimiento.Clear();
            comboBoxMedicamento.Items.Clear();
            comboBoxProveedor.Items.Clear();
        }

    }
}
