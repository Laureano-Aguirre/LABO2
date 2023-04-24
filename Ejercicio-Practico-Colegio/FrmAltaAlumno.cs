using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Colegio;

namespace Ejercicio_Practico_Colegio
{
    public partial class FrmAltaAlumno : Form
    {
        public FrmAltaAlumno()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txb_AltaAluNombre.Text;
            string apellido = txb_AltaAluApellido.Text;
            string direccion = txb_AltaAluDireccion.Text;
            string curso = txb_AltaAluCurso.Text;
            DateTime fechaDeNacimiento = dtp_AltaAluFechaDeNac.Value;
            string[] materias = new string[10];

            if(chb_AltaAluMatematica1.Checked)
            {
                materias[0] = "Matematica I";
            }
            if(chb_AltaAluIngles1.Checked)
            {
                materias[1] = "Ingles I";
            }
            if(chb_AltaAluProgramacion1.Checked)
            {
                materias[2] = "Programacion I";
            }
            if(chb_AltaAluLaboratorio1.Checked)
            {
                materias[3] = "Laboratorio I";
            }
            if(chb_AltaAluSpd.Checked)
            {
                materias[4] = "Sistema de procesamiento de datos";
            }
            if(chb_AltaAluArqSO.Checked)
            {
                materias[5] = "Arquitectura de sistemas operativos";
            }
            if(chb_AltaAluMatematica2.Checked)
            {
                materias[6] = "Matematica II";
            }
            if(chb_AltaAluIngles2.Checked)
            {
                materias[7] = "Ingles II";
            }
            if(chb_AltaAluProgramacion2.Checked)
            {
                materias[8] = "Programacion II";
            }
            if(chb_AltaAluLaboratorio2.Checked)
            {
                materias[9] = "Laboratorio II";
            }

            if(ValidarDatos(nombre,apellido,direccion,curso))
            {
                Alumno alumno = new Alumno(nombre, apellido, fechaDeNacimiento, direccion, curso, materias);
                MessageBox.Show(alumno.Mostrar(), "", MessageBoxButtons.OK);

            }

        }

        private bool ValidarDatos(string nombre, string apellido, string direccion, string curso)
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Se deben completar los siguientes datos:");
            if (string.IsNullOrEmpty(nombre))
            {
                esValido = false;
                sb.AppendLine("Nombre");
            }
            if (string.IsNullOrEmpty(apellido))
            {
                esValido = false;
                sb.AppendLine("Apellido");
            }
            if(string.IsNullOrEmpty(direccion))
            {
                esValido = false;
                sb.AppendLine("Direccion");
            }
            if(string.IsNullOrEmpty (curso))
            {
                esValido = false;
                sb.AppendLine("Curso");
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;

        }
    }
}
