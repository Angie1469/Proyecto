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
    public partial class FormReportarMedicamento : Form
    {
        //Se declara la variable tipo tabla
        public static DataTable TablaLote;

        public FormReportarMedicamento()
        {
            InitializeComponent();
        }

        //Evento de radiobuton para activar el metodo de llenar combobox
        private void radioButtonVencido_CheckedChanged(object sender, EventArgs e)
        {
            llenarComboboxLote();
        }

        //Metodo para llenar el combobox 
        private void llenarComboboxLote()
        {
            //Se establece la conexion con oracle
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {

                connection.Open();

                //Se realiza la busqueda
                string BusquedaMedicamento = "SELECT * FROM LOTE_VENCIDO";
                OracleCommand comando = new OracleCommand(BusquedaMedicamento, connection);
                OracleDataReader lector = comando.ExecuteReader();

                //Se alamacenan los datos de la consulta en un datatable
                TablaLote = new DataTable();
                TablaLote.Load(lector);

                // se recorre cada dato en la datatable que se creo
                foreach (DataRow row in TablaLote.Rows)
                {
                    //LLena el combobox con los datos que se le indican
                    comboBoxLoteVencido.Items.Add(row[0] + "-" + row[2]);
                }

            }
        }

        //Evento de radiobuton para activar el metodo de llenar combobox
        private void radioButtonDañado_CheckedChanged(object sender, EventArgs e)
        {
            llenarComboboxDaños();
        }

        //Metodo para llenar el combobox 
        private void llenarComboboxDaños()
        {
            //Se establece la conexion con oracle
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {

                connection.Open();

                //Se realiza la busqueda
                string BusquedaMedicamento = "SELECT * FROM LOTE_VENCIDO";
                OracleCommand comando = new OracleCommand(BusquedaMedicamento, connection);
                OracleDataReader lector = comando.ExecuteReader();

                //Se alamacenan los datos de la consulta en un datatable
                TablaLote = new DataTable();
                TablaLote.Load(lector);

                // se recorre cada dato en la datatable que se creo
                foreach (DataRow row in TablaLote.Rows)
                {
                    //LLena el combobox con los datos que se le indican
                    comboBoxDañoslote.Items.Add(row[0] + "-" + row[3]);
                }

            }
        }

        //Evento boton añadir
        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            //Condicional para comprobar cual radio buton esta seleccionado
            if(radioButtonVencido.Checked == true)
            {
                string[] Fecha_Vencido = comboBoxLoteVencido.Text.Split('-');

                //se recorre todos los datos de la datatable
                foreach (DataRow row in TablaLote.Rows)
                {
                    //se buscan cada uno de los precios que se guardaron en la tabla y se compara con los valores guardados en el combobox  
                    if (row[0].Equals(Fecha_Vencido[0].Trim()))
                    {
                        //se envian los datos que apareceran en el datagridview
                        dataGridViewDatos.Rows.Add(row[0], row[2], row[4], row[1]);
                    }
                }
            }
            else if(radioButtonDañado.Checked == true)
            {
                string[] Fecha_Ingreso = comboBoxDañoslote.Text.Split('-');

                //se recorre todos los datos de la datatable
                foreach (DataRow row in TablaLote.Rows)
                {
                    //se buscan cada uno de los precios que se guardaron en la tabla y se compara con los valores guardados en el combobox  
                    if (row[0].Equals(Fecha_Ingreso[0].Trim()))
                    {
                        //se envian los datos que apareceran en el datagridview
                        dataGridViewDatos.Rows.Add(row[0], row[3], row[4], row[1]);
                    }
                }
            }

            
        }

        private void buttonReportar_Click(object sender, EventArgs e)
        {

        }


    }
}
