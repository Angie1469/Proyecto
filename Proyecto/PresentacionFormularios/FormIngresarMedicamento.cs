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


namespace Proyecto
{
    public partial class FormMedicamentoIngreso : Form
    {
        //Se genera una variable de tipo fomulario ingresar datos que es la que permite tener una conexion con el formulario de ingresos
        public FormIngresarDatos MiPadre;

        //Se especifica que recibira un datos ripo formularioIngresoDatos
        public FormMedicamentoIngreso(FormIngresarDatos formPadre)
        {
            InitializeComponent();
            //Se inicia el formulario que recibio en este caso eld e ingresar datos
            MiPadre = formPadre;
        }

        //Metodo de capturar el nuevo medicamento
        public Medicamento CapturarMedicamento()
        {
            Medicamento pMedicamento = new Medicamento();
            pMedicamento.nombreGenerico = textBoxNomGenerico.Text;
            pMedicamento.precio = int.Parse(textBoxPrecio.Text);
            pMedicamento.descripcion = textBoxDescipcion.Text;
            pMedicamento.NombreComercial = textBoxNomComercial.Text;
            MiPadre.AlmacenarMedicamento(pMedicamento);

            return pMedicamento;
        }


        // se añadira lo capturado en medicamento al datagridview
        public void buttonAñadir_Click(object sender, EventArgs e)
        {
            //Se llama el metodo de capturar
            Medicamento Nuevo = new Medicamento();
            Nuevo = CapturarMedicamento();
            //Se envian los datos al datagribviw especificando el formulario donde se encuentar
            MiPadre.dataGridViewMeidcamentoLote.Rows.Add(Nuevo.NombreComercial, Nuevo.nombreGenerico, Nuevo.precio);
            
            //Se vacian los datos que se encuentran en los texbox
            textBoxNomComercial.Clear();
            textBoxNomGenerico.Clear();
            textBoxPrecio.Clear();
            textBoxDescipcion.Clear();

        }
    }
}
