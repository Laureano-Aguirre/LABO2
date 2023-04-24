using _6CBibliotecaDeClasesEj2;
using System;
using System.Text;
namespace _6CEjercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbx_Pais.Items.Add("Argentina");
            lbx_Pais.Items.Add("Chile");
            lbx_Pais.Items.Add("Uruguay");
            nud_Edad.Minimum = 16;
            nud_Edad.Maximum = 90;
            nud_Edad.Value = 16;
            nud_Edad.Increment = 1;
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string nombre = txb_Nombre.Text;
            string direccion = txb_Direccion.Text;
            string genero = ValidarGenero();
            string pais = lbx_Pais.SelectedItem.ToString();
            string[] cursos = new string[3];
            decimal edad = nud_Edad.Value;
            
                if (chb_CSharp.Checked)
                {
                    cursos[0] = "C#";
                }
                if (chb_CMasMas.Checked)
                {
                    cursos[1] = "C++";
                }
                if (chb_JavaScript.Checked)
                {
                    cursos[2] = " JavaScript";
                }

            Ingresante ingresante = new Ingresante(nombre, direccion, genero, pais, cursos, edad);
            MessageBox.Show(ingresante.Mostrar(), "",MessageBoxButtons.OK);
        }


        private string ValidarGenero()
        {
            string genero;
            if(rdb_GenMasc.Checked)
            {
                genero = "Masculino";
            }
            else if (rdb_GenFem.Checked)
            {
                genero = "Femenino";
            }
            else
            {
                genero = "No binario";
            }
            return genero;
        }
    }
}