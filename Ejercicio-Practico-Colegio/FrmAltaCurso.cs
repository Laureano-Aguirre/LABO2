using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Colegio;

namespace Ejercicio_Practico_Colegio
{
    public partial class FrmAltaCurso : Form
    {
        public FrmAltaCurso()
        {
            InitializeComponent();

            cmb_AltaCursoDisponibles.Visible = false;
            rch_AltaCursoListaUso.Visible = false;
            lb_AltaCursoEnUso.Visible = false;
            lb_AltaCursoDisponible.Visible = false;
            lb_AltaCursoAño.Visible = false;
        }

        private void FrmAltaCurso_Load(object sender, EventArgs e)
        {
            
            lb_AltaCursoAño.Visible = false;

            //rdb_RegisCurso1Año.Checked = false;
            //rdb_RegisCurso2Año.Checked = false;
            //rdb_RegisCurso3Año.Checked = false;
            //rdb_RegisCurso4Año.Checked = false;
            //rdb_RegisCurso5Año.Checked = false;
        }

        private void rdb_RegisCurso1Año_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_RegisCurso1Año.Checked == true)
            {
                lb_AltaCursoAño.Visible = true;
                lb_AltaCursoAño.Text = "1ER AÑO";
                rch_AltaCursoListaUso.Visible = true;
                lb_AltaCursoEnUso.Visible = true;
                lb_AltaCursoDisponible.Visible = true;
                cmb_AltaCursoDisponibles.Visible = true;
                cmb_AltaCursoDisponibles.Items.Clear();
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} A");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} B");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} C");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} D");
            }
        }

        private void rdb_RegisCurso2Año_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_RegisCurso2Año.Checked == true)
            {
                lb_AltaCursoAño.Visible = true;
                lb_AltaCursoAño.Text = "2DO AÑO";
                rch_AltaCursoListaUso.Visible = true;
                lb_AltaCursoEnUso.Visible = true;
                lb_AltaCursoDisponible.Visible = true;
                cmb_AltaCursoDisponibles.Visible = true;
                cmb_AltaCursoDisponibles.Items.Clear();
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} A");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} B");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} C");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} D");
            }
        }

        private void rdb_RegisCurso3Año_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_RegisCurso3Año.Checked == true)
            {
                lb_AltaCursoAño.Visible = true;
                lb_AltaCursoAño.Text = "3ER AÑO";
                rch_AltaCursoListaUso.Visible = true;
                lb_AltaCursoEnUso.Visible = true;
                lb_AltaCursoDisponible.Visible = true;
                cmb_AltaCursoDisponibles.Visible = true;
                cmb_AltaCursoDisponibles.Items.Clear();
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} A");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} B");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} C");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} D");
            }
        }

        private void rdb_RegisCurso4Año_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_RegisCurso4Año.Checked == true)
            {
                lb_AltaCursoAño.Visible = true;
                lb_AltaCursoAño.Text = "4TO AÑO";
                rch_AltaCursoListaUso.Visible = true;
                lb_AltaCursoEnUso.Visible = true;
                lb_AltaCursoDisponible.Visible = true;
                cmb_AltaCursoDisponibles.Visible = true;
                cmb_AltaCursoDisponibles.Items.Clear();
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} A");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} B");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} C");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} D");
            }
        }

        private void rdb_RegisCurso5Año_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdb_RegisCurso5Año.Checked == true)
            {
                lb_AltaCursoAño.Visible = true;
                lb_AltaCursoAño.Text = "5TO AÑO";
                rch_AltaCursoListaUso.Visible = true;
                lb_AltaCursoEnUso.Visible = true;
                lb_AltaCursoDisponible.Visible = true;
                cmb_AltaCursoDisponibles.Visible = true;
                cmb_AltaCursoDisponibles.Items.Clear();
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} A");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} B");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} C");
                cmb_AltaCursoDisponibles.Items.Add($"{lb_AltaCursoAño.Text} D");
            }
        }
    }
}
