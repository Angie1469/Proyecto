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
    public partial class formularioAdministrador : Form
    {
        public formularioAdministrador()
        {
            InitializeComponent();
            CustomizeDesing();
            ContenedorFormularios2.Visible = false;
        }
        //encargado de mostrar y ocultar los formularios que se le envian
        private void AbrirFormulario(object formularioBase)
        {
            if (this.ContenedorFormularios2.Controls.Count > 0)
            {
                this.ContenedorFormularios2.Controls.RemoveAt(0);
            }
            Form FB = formularioBase as Form;
            FB.TopLevel = false;
            FB.Dock = DockStyle.Fill;
            this.ContenedorFormularios2.Controls.Add(FB);
            this.ContenedorFormularios2.Tag = FB;
            FB.Show();
        }
        //Mantiene oculto los submenus
        private void CustomizeDesing()
        {
            subMenuDatos.Visible = false;
            subMenuMedicamento.Visible = false;
        }
        // Metodo para ocultar los submenus 
        private void HideSubMenu()
        {
            if (subMenuDatos.Visible == true)
            { subMenuDatos.Visible = false; }
            if (subMenuMedicamento.Visible == true)
            { subMenuMedicamento.Visible = false; }
        }

        // muestra y oculta los botones que se configuraron en el sub menu
        private void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
            }
            else
            { subMenu.Visible = false; }
        }

        //Se le asigno a cada boton un evento para mostrar los formularios correspondientes
        private void buttonDatos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuDatos);
        }

        private void buttonMedicamento_Click(object sender, EventArgs e)
        {
            ShowSubMenu(subMenuMedicamento);
        }

        private void buttonCamCredenciales_Click(object sender, EventArgs e)
        {
            ContenedorFormularios2.Visible = true;
            AbrirFormulario(new FormACDatos());
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            ContenedorFormularios2.Visible = true;
            AbrirFormulario(new FormIngresarDatos());
        }

        private void buttonReportar_Click(object sender, EventArgs e)
        {
            ContenedorFormularios2.Visible = true;
            AbrirFormulario(new FormReportarMedicamento());
        }

        //Se cierra el formulario si asi lo dese el administrador, evento salir
        private void labelSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
