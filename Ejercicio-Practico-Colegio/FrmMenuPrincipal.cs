using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_Practico_Colegio
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal(string nombre)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lb_Bienvenida.Text = $"Bienvenido {nombre}.";
        }

        private void FrmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            Application.Exit();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;                         //configura timer para que se ejecute cada segundo
            
            timer1.Enabled = true;                         //activar timer
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime horaActual = DateTime.Now;
            lb_Hora.Text = horaActual.ToString("hh:mm:ss tt");
        }

        private void btn_RegistrarAlum_Click(object sender, EventArgs e)
        {
            FrmAltaAlumno frmAltaAlumno = new FrmAltaAlumno();
            frmAltaAlumno.Show();
        }
    }
}
