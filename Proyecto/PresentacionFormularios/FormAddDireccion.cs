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
    public partial class FormDireccion : Form
    {
        public FormDireccion()
        {
            InitializeComponent();
        }

        // boton añadir genera el evendo de enviar el dato del texbox al datagridview
        private void buttonAñadirDireccion_Click_1(object sender, EventArgs e)
        {
            dataGridViewDireccion.Rows.Add(textBoxDireccion.Text);
            //Se llama el metodo para capturar el dato de direccion añadido
            CapturarDireccion();
        }

        //Metodo para capturar la neuva direccion
        private Direccion CapturarDireccion()
        {
            Direccion pDireccion = new Direccion();
            pDireccion.id = "";
            // se trae la variable id_cliente almacenada en el sistema para especificar la dirreccion a quien le pertenece
            pDireccion.id_cliente = Properties.Settings.Default.Id_cliente;
            
            // se recorre el datagidview para encontrar la direccion y almacenarla 
            foreach (DataGridViewRow row in dataGridViewDireccion.Rows)
            {
                if (row.Cells["Column1"].Value != null)
                {
                    pDireccion.direccion = row.Cells[0].Value.ToString();
                }
                    
            }

            return pDireccion;
        }

        // Boton para llamar el metodo de registrar la direccion
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Direccion pDireccion = CapturarDireccion();
            Datos1 registar = new Datos1();
            registar.registrarDireccion(pDireccion);
        }
    }
}
