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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal( string nombre, string apellido, string mensaje, string materia)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            lb_MenuPrincipal.Text = mensaje;
            lb_Presentacion.Text = $"Soy {nombre} {apellido}, y mi materia favorita es {materia}";
        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
