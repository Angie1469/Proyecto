using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using Proyecto;


namespace Proyecto
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            lblmsgError.Visible = false;

        }

        //Metodo para capturar los datos del textbox y generar usuario por metodo constructor
        public Usuario CapturarUsuario(TextBox nombre, TextBox contraseña)
        {
            Usuario pUsuario;
            pUsuario = new Usuario();
            pUsuario.nombre = CredencialNombre.Text.ToString();
            pUsuario.contraseña = CredencialContraseña.Text.ToString();
            return pUsuario;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //se utiliza el metodo de capturar los texbox y metodo de validar el ususario y contraseña
            Usuario pUsuario = CapturarUsuario(CredencialNombre, CredencialContraseña);
            Usuario pRol = pUsuario.validarDatos(pUsuario);
            // verificación del rol para el acceso al formulario correspondiente
            if(pRol.rol.ToString() == "CLIENTE" )
            {
                FormularioUsuario mainMenu = new FormularioUsuario();
                mainMenu.Show();
                this.Hide();
            }
            else if (pRol.rol.ToString() == "ADMINISTRADOR") 
            {
                formularioAdministrador mainMenu = new formularioAdministrador();
                mainMenu.Show();
                this.Hide();
            }
            else //Mensaje de error
            {
                lblmsgError.Visible = true;
                CredencialNombre.Clear();
                CredencialContraseña.Clear();
            }
        }

        private void CredencialContraseña_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
