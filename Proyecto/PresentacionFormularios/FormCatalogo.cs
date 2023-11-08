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

namespace Proyecto
{

    public partial class FormCatalogo : Form
    {
        //Se declara la variable datatable para almacenar los datos de la busqueda
        private static DataTable MedicamentoTabla;
        private static string ReferenciaNomComercial;

        public FormCatalogo()
        {
            InitializeComponent();
            llenarComboxMedicamento();
            labelNomComercial.Visible = false;
            labelNomGenerico.Visible = false;
        }

        // llenar el combo box con los datos de medicamento desde la base de datos
        private void llenarComboxMedicamento()
        {
            //Se realiza la conexion con oracle
            string connectionString = "DATA SOURCE=xe; PASSWORD=ProyectoCentroAcopio; USER ID=ProyectoCentroAcopio;";
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                connection.Open();

                //Se realiza la consulta
                string BusquedaMedicamento = "SELECT M.*, N.NOMBRE as NombreComercial from medicamento M join nombrecomercial N on m.id = n.idmedicamento";
                OracleCommand comando = new OracleCommand(BusquedaMedicamento, connection);
                OracleDataReader lector = comando.ExecuteReader();

                //Se almacenan los datos traidos por la consulta en la tabla 
                MedicamentoTabla = new DataTable();
                MedicamentoTabla.Load(lector);

                // se recorre cada dato en la datatable que se creo
                foreach (DataRow row in MedicamentoTabla.Rows)
                {
                    //LLena el combobox con los datos que se le indican
                    comboxMedicamento.Items.Add(row[4]);
                }

            }
        }

        // metodo para capturar los datos del medicamento traido por la consulta
        public Medicamento CapturarMedicamento(string Nombre)
        {

            Medicamento pMedicamento = new Medicamento();

            //se recorre todos los datos de la datatable para capturar cada dato 
            foreach (DataRow row in MedicamentoTabla.Rows)
            {
                if (row[4].Equals(Nombre))
                {
                    string Precio = row[3].ToString().Replace("$", "").Replace(".", "");
                    pMedicamento.id = row[0].ToString();
                    pMedicamento.nombreGenerico = row[1].ToString();
                    pMedicamento.descripcion = row[2].ToString();
                    pMedicamento.precio = int.Parse(Precio);
                    pMedicamento.NombreComercial = row[4].ToString();
                }       

                labelNomComercial.Visible = true;
                labelNomGenerico.Visible = true;

            }

            return pMedicamento;
        }

        //Se le asigna a cada label y texbos los datos a mostrar en el fromulario segun el medicamento seleccionado
        public void MostarMedicamento(Medicamento pMedicamento)
        {
            labelNomComercial.Text = pMedicamento.NombreComercial;
            labelNomGenerico.Text = pMedicamento.nombreGenerico;
            textBoxDescripcion.Text = pMedicamento.descripcion;
            labelPrecio.Text = pMedicamento.precio.ToString();

        }

        // Metodo para capturar la elecion de medicamento del cliente 
        public void comboxMedicamento_SelectedValueChanged(object sender, EventArgs e)
        {
            ReferenciaNomComercial = comboxMedicamento.Text.Split('-')[0];
            //Se utlizan los metodos de capturar y mostar
            Medicamento DatosMedicamento = CapturarMedicamento(ReferenciaNomComercial);
            MostarMedicamento(DatosMedicamento);

            //Condiciones para mostar la imagen correspondiente a cada medicamento en la caja de imagen 
            if (ReferenciaNomComercial == "Ditogel PLUS")
            {
                pictureBoxMedicamento.Image = Properties.Resources.Digotel;
                pictureBoxMedicamento.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBoxMedicamento.Location = new Point(110, 108);
                pictureBoxMedicamento.Name = "pictureBoxMedicamento";
                pictureBoxMedicamento.Size = new Size(149, 165);
                pictureBoxMedicamento.TabIndex = 3;
            }
            else if (ReferenciaNomComercial == "Flemalis")
            {
                pictureBoxMedicamento.Image = Properties.Resources.Flemalis;
                pictureBoxMedicamento.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBoxMedicamento.Location = new Point(110, 108);
                pictureBoxMedicamento.Name = "pictureBoxMedicamento";
                pictureBoxMedicamento.Size = new Size(149, 165);
                pictureBoxMedicamento.TabIndex = 3;
            }
            else if (ReferenciaNomComercial == "Fitobremg")
            {
                pictureBoxMedicamento.Image = Properties.Resources.fitobrem;
                pictureBoxMedicamento.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBoxMedicamento.Location = new Point(110, 108);
                pictureBoxMedicamento.Name = "pictureBoxMedicamento";
                pictureBoxMedicamento.Size = new Size(149, 165);
                pictureBoxMedicamento.TabIndex = 3;
            }
            else if (ReferenciaNomComercial == "SoyCALkids")
            {
                pictureBoxMedicamento.Image = Properties.Resources.SOYCALKIDS;
                pictureBoxMedicamento.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBoxMedicamento.Location = new Point(110, 108);
                pictureBoxMedicamento.Name = "pictureBoxMedicamento";
                pictureBoxMedicamento.Size = new Size(149, 165);
                pictureBoxMedicamento.TabIndex = 3;
            }
            else if (ReferenciaNomComercial == "ZINVIT")
            {
                pictureBoxMedicamento.Image = Properties.Resources.ZINVIT;
                pictureBoxMedicamento.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBoxMedicamento.Location = new Point(110, 108);
                pictureBoxMedicamento.Name = "pictureBoxMedicamento";
                pictureBoxMedicamento.Size = new Size(149, 165);
                pictureBoxMedicamento.TabIndex = 3;
            }
            else if (ReferenciaNomComercial == "PROXANIDA")
            {
                pictureBoxMedicamento.Image = Properties.Resources.proxanida;
                pictureBoxMedicamento.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBoxMedicamento.Location = new Point(110, 108);
                pictureBoxMedicamento.Name = "pictureBoxMedicamento";
                pictureBoxMedicamento.Size = new Size(149, 165);
                pictureBoxMedicamento.TabIndex = 3;
            }
            else if (ReferenciaNomComercial == "MUCOZIP")
            {
                pictureBoxMedicamento.Image = Properties.Resources.Mucozip;
                pictureBoxMedicamento.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBoxMedicamento.Location = new Point(110, 108);
                pictureBoxMedicamento.Name = "pictureBoxMedicamento";
                pictureBoxMedicamento.Size = new Size(149, 165);
                pictureBoxMedicamento.TabIndex = 3;
            }
            else if (ReferenciaNomComercial == "Leuxicam")
            {
                pictureBoxMedicamento.Image = Properties.Resources.Leuxicam;
                pictureBoxMedicamento.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBoxMedicamento.Location = new Point(110, 108);
                pictureBoxMedicamento.Name = "pictureBoxMedicamento";
                pictureBoxMedicamento.Size = new Size(149, 165);
                pictureBoxMedicamento.TabIndex = 3;
            }
            else if (ReferenciaNomComercial == "Nitrofur")
            {
                pictureBoxMedicamento.Image = Properties.Resources.Nitrofur;
                pictureBoxMedicamento.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBoxMedicamento.Location = new Point(110, 108);
                pictureBoxMedicamento.Name = "pictureBoxMedicamento";
                pictureBoxMedicamento.Size = new Size(149, 165);
                pictureBoxMedicamento.TabIndex = 3;
            }
            else if (ReferenciaNomComercial == "Oxiclarine")
            {
                pictureBoxMedicamento.Image = Properties.Resources.OXICLARINE;
                pictureBoxMedicamento.BackgroundImageLayout = ImageLayout.Zoom;
                pictureBoxMedicamento.Location = new Point(110, 108);
                pictureBoxMedicamento.Name = "pictureBoxMedicamento";
                pictureBoxMedicamento.Size = new Size(149, 165);
                pictureBoxMedicamento.TabIndex = 3;
            }
            else
            {

            }
        }
    }
}
