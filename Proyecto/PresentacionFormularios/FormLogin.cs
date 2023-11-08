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
        //se creo una variable para capturar la id del cliente que ingresa al software 
        public static string ID_CLIENTE;

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

        //metodo encargado de verificar el check box para mostra o no mostar las credenciales que se guardan
        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Recordar == true)
            {
                // las credenciales y el check se estan guardando en variables del sistema 
                CredencialNombre.Text = Properties.Settings.Default.Usuario;
                CredencialContraseña.Text = Properties.Settings.Default.Contraseña;
                checkBoxRecordar.Checked = Properties.Settings.Default.Recordar;
            }
            else
            {
                CredencialNombre.Text = " ";
                CredencialContraseña.Text = "";
                checkBoxRecordar.Checked = false;
            }
        }

        // boton de ingresar donde se llaman los metodos de capturar el usuario y validar sus credenciales
        private void button1_Click(object sender, EventArgs e)
        {

            //se utiliza el metodo de capturar los texbox y metodo de validar el ususario y contraseña
            Usuario pUsuario = CapturarUsuario(CredencialNombre, CredencialContraseña);
            Usuario pRol = pUsuario.validarDatos(pUsuario);


            // verificación del rol para el acceso al formulario correspondiente
            if(pRol.rol.ToString() == "CLIENTE" )
            {

                ID_CLIENTE = pRol.id_cliente.ToString();

                //condicional para la funcionalidad de recordar el usuario y la contraseña
                if (checkBoxRecordar.Checked)
                {
                    Properties.Settings.Default.Usuario = CredencialNombre.Text;
                    Properties.Settings.Default.Contraseña = CredencialContraseña.Text;
                    Properties.Settings.Default.Id_cliente = pRol.id_cliente.ToString();
                    Properties.Settings.Default.Recordar = checkBoxRecordar.Checked;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                }
                else
                {
                    Properties.Settings.Default.Usuario = " ";
                    Properties.Settings.Default.Contraseña = " ";
                    Properties.Settings.Default.Recordar = false;
                }
                //Se encarga de mostra el formulario correspondiente
                FormularioUsuario mainMenu = new FormularioUsuario();
                mainMenu.Show();
                mainMenu.FormClosed+=salirLogin;
                this.Hide();
            }
            else if (pRol.rol.ToString() == "ADMINISTRADOR") 
            {
                //condicional para la funcionalidad de recordar el usuario y la contraseña
                if (checkBoxRecordar.Checked)
                {
                    Properties.Settings.Default.Usuario = CredencialNombre.Text;
                    Properties.Settings.Default.Contraseña = CredencialContraseña.Text;
                    Properties.Settings.Default.Recordar = checkBoxRecordar.Checked;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                }
                else
                {
                    Properties.Settings.Default.Usuario = " ";
                    Properties.Settings.Default.Contraseña = " ";
                    Properties.Settings.Default.Recordar = false;
                }

                formularioAdministrador mainMenu = new formularioAdministrador();
                mainMenu.Show();
                mainMenu.FormClosed += salirLogin;
                this.Hide();
            }
            else //Mensaje de error
            {
                lblmsgError.Visible = true;
                CredencialNombre.Clear();
                CredencialContraseña.Clear();
            }

        }

        // Metodo utilizado para mostrar nuevamente el formulario login si el cliente o administrador salen del formulario principal
        private void salirLogin(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
