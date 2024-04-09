using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacientes
{
    public partial class Form2 : Form
    {
        private const string UsuarioCorrecto = "admin";
        private const string ContraseñaCorrecta = "password";
        public Form2()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true; // Configurar el TextBox como campo de contraseña
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Esto asegura que el TextBox de usuario esté listo para recibir input al cargar el formulario
            this.ActiveControl = txtUsuario;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == UsuarioCorrecto && contraseña == ContraseñaCorrecta)
            {
                MessageBox.Show("Login exitoso");
                // Aquí podrías abrir el formulario principal de tu aplicación, etc.
                Form1 Form1 = new Form1();
                Form1.Show();
                this.Hide(); // Cerrar el formulario de login
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intenta de nuevo.");
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
