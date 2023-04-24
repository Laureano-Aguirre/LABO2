using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6CEjercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //Form1 form = new Form1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO : 1 - Dedos
            string nomb;
            string apell;
            string materia;
           // bool nombre;
            //bool apellido;
            //StringBuilder sb = new StringBuilder();

            nomb = txb_nombre.Text;
            apell = txb_apellido.Text;
            //nombre = string.IsNullOrEmpty(nomb);
            //apellido = string.IsNullOrEmpty(apell);

            if(Validar())
            {
                materia = cmb_Materias.SelectedItem.ToString();
                MenuPrincipal menuPrincipal = new MenuPrincipal(nomb, apell, "Hola, soy Windows Forms!", materia);

                menuPrincipal.Show();
                this.Hide();
            }
            

            //if(nombre == true && apellido == true)
            //{
            //    sb.AppendLine("Se deben completar los siguientes campos:");
            //    sb.AppendLine("nombre");
            //    sb.AppendLine("apellido");
            //    MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else if (nombre == true && apellido != true)
            //{
            //    sb.AppendLine("Se deben completar los siguientes campos:");
            //    sb.AppendLine("nombre");
            //    MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //} else if (nombre != true && apellido == true)
            //{
            //    sb.AppendLine("Se deben completar los siguientes campos:");
            //    sb.AppendLine("apellido");
            //    MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    materia = cmb_Materias.SelectedItem.ToString();
            //    MenuPrincipal menuPrincipal = new MenuPrincipal(nomb, apell, "Hola, soy Windows Forms!", materia);

            //    menuPrincipal.Show();
            //    this.Hide();
            //}
            
            
        }

        private bool Validar()
        {
            StringBuilder sb = new StringBuilder();
            bool valido = true;

            sb.AppendLine("Se deben completar los siguientes datos:");

            if(string.IsNullOrWhiteSpace(txb_nombre.Text))
            {
                sb.AppendLine("nombre");
                valido = false;
            } 
            if(string.IsNullOrWhiteSpace(txb_apellido.Text))
            {
                sb.AppendLine("apellido");
                valido = false;
            }

            if(!(valido))
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valido;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmb_Materias.Items.Add("Matematica I");
            cmb_Materias.Items.Add("Laboratorio I");
            cmb_Materias.Items.Add("Programacion I");
            cmb_Materias.Items.Add("Ingles II");
            cmb_Materias.Items.Add("Matematica II");
            cmb_Materias.Items.Add("Laboratorio II");
            cmb_Materias.Items.Add("Programacion II");
            cmb_Materias.Items.Add("Ingles II");
            if(cmb_Materias.SelectedItem == null)
            {
                cmb_Materias.Text = "Programacion I";
            }
        }
    }
} 