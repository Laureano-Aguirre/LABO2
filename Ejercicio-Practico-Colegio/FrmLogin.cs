using System;
using System.Drawing;
using System.Text;
using Colegio;


namespace Ejercicio_Practico_Colegio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("C:/Users/Lau/Downloads/imagen-huergo.png");
            this.TransparencyKey = Color.FromArgb(255, 0, 255);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = txb_Usuario.Text;
            string password = txb_Password.Text;

            if (ValidarDatos(user, password))
            {
                if(ValidarUser(user, password))
                {
                    Profesor profesor = new Profesor(user, password);
                    FrmMenuPrincipal frmMenuPrincipal = new FrmMenuPrincipal(user);
                    frmMenuPrincipal.Show();
                    this.Hide();
                }
            }
        }

        private bool ValidarDatos(string usuario, string password)
        {
            bool validado = true;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Se deben completar los siguientes datos:");
            if(string.IsNullOrEmpty(usuario))
            {
                validado = false;
                sb.AppendLine("Usuario");
            }
            if(string.IsNullOrEmpty(password))
            {
                validado = false;
                sb.AppendLine("Contraseña");
            }

            if(!validado)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return validado;
        }

        private bool ValidarUser(string usuario, string password)
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Los datos incorrectos son: ");
            if (usuario != "Laureano")
            {
                esValido = false;
                sb.AppendLine("Usuario");
            }
            if(password != "12345")
            {
                esValido = false;
                sb.AppendLine("Contraseña");
            }

            if(!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }
    }
}