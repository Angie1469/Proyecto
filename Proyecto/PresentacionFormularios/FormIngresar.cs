using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class FormIngresarDatos : Form
    {
        //se declara dos variables una tipo medicamento y otra tipo lote
        Medicamento NuevoRegistro = new Medicamento();
        Lote NuevoLote = new Lote();

        public FormIngresarDatos()
        {
            InitializeComponent();

        }

        // Metodo que permite abrir los formularios 
        private void AbrirFormulario(object formularioBase)
        {
            if (this.panelLoteMedicamento.Controls.Count > 0)
            {
                this.panelLoteMedicamento.Controls.RemoveAt(0);
            }
            Form FB = formularioBase as Form;
            FB.TopLevel = false;
            FB.Dock = DockStyle.Fill;
            this.panelLoteMedicamento.Controls.Add(FB);
            this.panelLoteMedicamento.Tag = FB;
            FB.Show();
        }

        private void FormIngresarDatos_Load(object sender, EventArgs e)
        {
            
        }

        //Ecnecto check de radiobutton para utilizar el metodo de abrir formulario y traer el formulario de medicamento
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panelLoteMedicamento.Visible = true;
            //Se le envia este formulario al nuevo formulario
            AbrirFormulario(new FormMedicamentoIngreso(this));
        }

        //Ecnecto check de radiobutton para utilizar el metodo de abrir formulario y traer el formulario de Lote
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panelLoteMedicamento.Visible = true;
            //Se le envia este formulario al nuevo formulario
            AbrirFormulario(new FormLoteIngreso(this));
        }

        // Metodo para almacenar el Medicamento enciado desde el formulario Medicamento
        public void AlmacenarMedicamento(Medicamento nMedicamento)
        {
            NuevoRegistro = nMedicamento;
        }

        // Metodo para almacenar el Lote enciado desde el formulario Lote
        public void AlmacenartoLote(Lote nLote)
        {
            NuevoLote = nLote;
        }

        //Boton que se encarga de verificar el tipo de variable a registar y enviarlos al metodo de registro en la base de datos
        private void buttonRegistar_Click(object sender, EventArgs e)
        {

            //Condicional apra saber que se desea registrar
            if (radioButton1.Checked == true)
            {

                Datos1 registro = new Datos1();
                registro.IngresarMedicamento(NuevoRegistro);
                dataGridViewMeidcamentoLote.Rows.Clear();

            }
            else if (radioButton2.Checked == true)
            {
                Datos1 registroLote = new Datos1();
                registroLote.IngresarLote(NuevoLote);
                dataGridViewMeidcamentoLote.Rows.Clear();
            }
            else
            {
                //Mensaje de error por si no hay ningun radiobutton seleccionado
                System.Windows.Forms.MessageBox.Show("No se registro ningun dato");
            }
        }
    }
}
