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
    public partial class FormularioUsuario : Form
    {
        public FormularioUsuario()
        {
            InitializeComponent();
            CustomizeDesing();
            ContenedorFormularios.Visible = false;
        }

        // Metodo encargado de mostrar y ocultar los formularios que se envian
        private void AbrirFormulario(object formularioBase)
        {
            if (this.ContenedorFormularios.Controls.Count > 0)
            {
                this.ContenedorFormularios.Controls.RemoveAt(0);
            }
            Form FB = formularioBase as Form;
            FB.TopLevel = false;
            FB.Dock = DockStyle.Fill;
            this.ContenedorFormularios.Controls.Add(FB);
            this.ContenedorFormularios.Tag = FB;
            FB.Show();
        }

        private void InicioUsuario_Load(object sender, EventArgs e)
        {

        }

        //Mantiene oculto los submenus
        private void CustomizeDesing()
        {
            SubMenuPedido.Visible = false;
            SubMenuDatos.Visible = false;
        }

        // Metodo para ocultar los submenus 
        private void HideSubMenu()
        {
            if (SubMenuPedido.Visible == true)
            { SubMenuPedido.Visible = false; }
            if (SubMenuDatos.Visible == true)
            { SubMenuDatos.Visible = false; }
        }

        //Metodo encargado de mostar y ocultar los sub Menus
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

        // ser le genero un evento a cada boton creado en el menu y sub menu para mostrar los formulario correspondientes
        private void buttonDatos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubMenuDatos);
        }

        private void buttonGestionPedido_Click_1(object sender, EventArgs e)
        {
            ContenedorFormularios.Visible = true;
            AbrirFormulario(new GestionarPedido());
        }

        private void buttonPedido_Click(object sender, EventArgs e)
        {
            ShowSubMenu(SubMenuPedido);
        }

        private void buttonGestionDevolucion_Click(object sender, EventArgs e)
        {
            ContenedorFormularios.Visible = true;
            AbrirFormulario(new FormDevolucion());
        }

        private void buttonHistorial_Click(object sender, EventArgs e)
        {
            ContenedorFormularios.Visible = true;
            AbrirFormulario(new FormHistorial());
        }

        private void buttonCatalogo_Click(object sender, EventArgs e)
        {
            ContenedorFormularios.Visible = true;
            AbrirFormulario(new FormCatalogo());
        }

        private void buttonCredenciales_Click(object sender, EventArgs e)
        {
            ContenedorFormularios.Visible = true;
            AbrirFormulario(new FormACDatos());
        }

        private void buttonDireccion_Click(object sender, EventArgs e)
        {
            ContenedorFormularios.Visible = true;
            AbrirFormulario(new FormDireccion());
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ContenedorFormularios.Visible = true;
            AbrirFormulario(new FormUsuDatos());
        }

        // evento para cerrar sesion del fromulario usuario
        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
