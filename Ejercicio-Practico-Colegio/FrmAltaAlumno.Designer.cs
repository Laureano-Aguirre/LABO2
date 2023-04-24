namespace Ejercicio_Practico_Colegio
{
    partial class FrmAltaAlumno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_AltaAluNombre = new System.Windows.Forms.Label();
            this.lb_AltaAluApellido = new System.Windows.Forms.Label();
            this.lb_AltaAluFechaNac = new System.Windows.Forms.Label();
            this.lb_AltaAluDireccion = new System.Windows.Forms.Label();
            this.lb_AltaAluCurso = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gpb_AltaAluMaterias = new System.Windows.Forms.GroupBox();
            this.txb_AltaAluNombre = new System.Windows.Forms.TextBox();
            this.txb_AltaAluApellido = new System.Windows.Forms.TextBox();
            this.txb_AltaAluDireccion = new System.Windows.Forms.TextBox();
            this.txb_AltaAluCurso = new System.Windows.Forms.TextBox();
            this.dtp_AltaAluFechaDeNac = new System.Windows.Forms.DateTimePicker();
            this.chb_AltaAluMatematica1 = new System.Windows.Forms.CheckBox();
            this.chb_AltaAluIngles1 = new System.Windows.Forms.CheckBox();
            this.chb_AltaAluProgramacion1 = new System.Windows.Forms.CheckBox();
            this.chb_AltaAluLaboratorio1 = new System.Windows.Forms.CheckBox();
            this.chb_AltaAluSpd = new System.Windows.Forms.CheckBox();
            this.chb_AltaAluArqSO = new System.Windows.Forms.CheckBox();
            this.chb_AltaAluMatematica2 = new System.Windows.Forms.CheckBox();
            this.chb_AltaAluIngles2 = new System.Windows.Forms.CheckBox();
            this.chb_AltaAluProgramacion2 = new System.Windows.Forms.CheckBox();
            this.chb_AltaAluLaboratorio2 = new System.Windows.Forms.CheckBox();
            this.gpb_AltaAluMaterias.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_AltaAluNombre
            // 
            this.lb_AltaAluNombre.AutoSize = true;
            this.lb_AltaAluNombre.Location = new System.Drawing.Point(38, 31);
            this.lb_AltaAluNombre.Name = "lb_AltaAluNombre";
            this.lb_AltaAluNombre.Size = new System.Drawing.Size(51, 15);
            this.lb_AltaAluNombre.TabIndex = 0;
            this.lb_AltaAluNombre.Text = "Nombre";
            // 
            // lb_AltaAluApellido
            // 
            this.lb_AltaAluApellido.AutoSize = true;
            this.lb_AltaAluApellido.Location = new System.Drawing.Point(38, 90);
            this.lb_AltaAluApellido.Name = "lb_AltaAluApellido";
            this.lb_AltaAluApellido.Size = new System.Drawing.Size(51, 15);
            this.lb_AltaAluApellido.TabIndex = 1;
            this.lb_AltaAluApellido.Text = "Apellido";
            // 
            // lb_AltaAluFechaNac
            // 
            this.lb_AltaAluFechaNac.AutoSize = true;
            this.lb_AltaAluFechaNac.Location = new System.Drawing.Point(38, 152);
            this.lb_AltaAluFechaNac.Name = "lb_AltaAluFechaNac";
            this.lb_AltaAluFechaNac.Size = new System.Drawing.Size(117, 15);
            this.lb_AltaAluFechaNac.TabIndex = 2;
            this.lb_AltaAluFechaNac.Text = "Fecha de nacimiento";
            // 
            // lb_AltaAluDireccion
            // 
            this.lb_AltaAluDireccion.AutoSize = true;
            this.lb_AltaAluDireccion.Location = new System.Drawing.Point(38, 224);
            this.lb_AltaAluDireccion.Name = "lb_AltaAluDireccion";
            this.lb_AltaAluDireccion.Size = new System.Drawing.Size(57, 15);
            this.lb_AltaAluDireccion.TabIndex = 3;
            this.lb_AltaAluDireccion.Text = "Direccion";
            // 
            // lb_AltaAluCurso
            // 
            this.lb_AltaAluCurso.AutoSize = true;
            this.lb_AltaAluCurso.Location = new System.Drawing.Point(38, 295);
            this.lb_AltaAluCurso.Name = "lb_AltaAluCurso";
            this.lb_AltaAluCurso.Size = new System.Drawing.Size(38, 15);
            this.lb_AltaAluCurso.TabIndex = 4;
            this.lb_AltaAluCurso.Text = "Curso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(689, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpb_AltaAluMaterias
            // 
            this.gpb_AltaAluMaterias.Controls.Add(this.chb_AltaAluLaboratorio2);
            this.gpb_AltaAluMaterias.Controls.Add(this.chb_AltaAluProgramacion2);
            this.gpb_AltaAluMaterias.Controls.Add(this.chb_AltaAluIngles2);
            this.gpb_AltaAluMaterias.Controls.Add(this.chb_AltaAluMatematica2);
            this.gpb_AltaAluMaterias.Controls.Add(this.chb_AltaAluArqSO);
            this.gpb_AltaAluMaterias.Controls.Add(this.chb_AltaAluSpd);
            this.gpb_AltaAluMaterias.Controls.Add(this.chb_AltaAluLaboratorio1);
            this.gpb_AltaAluMaterias.Controls.Add(this.chb_AltaAluProgramacion1);
            this.gpb_AltaAluMaterias.Controls.Add(this.chb_AltaAluIngles1);
            this.gpb_AltaAluMaterias.Controls.Add(this.chb_AltaAluMatematica1);
            this.gpb_AltaAluMaterias.Location = new System.Drawing.Point(359, 49);
            this.gpb_AltaAluMaterias.Name = "gpb_AltaAluMaterias";
            this.gpb_AltaAluMaterias.Size = new System.Drawing.Size(420, 284);
            this.gpb_AltaAluMaterias.TabIndex = 7;
            this.gpb_AltaAluMaterias.TabStop = false;
            this.gpb_AltaAluMaterias.Text = "Materias";
            // 
            // txb_AltaAluNombre
            // 
            this.txb_AltaAluNombre.Location = new System.Drawing.Point(38, 49);
            this.txb_AltaAluNombre.Name = "txb_AltaAluNombre";
            this.txb_AltaAluNombre.PlaceholderText = "Ingrese aqui";
            this.txb_AltaAluNombre.Size = new System.Drawing.Size(136, 23);
            this.txb_AltaAluNombre.TabIndex = 8;
            // 
            // txb_AltaAluApellido
            // 
            this.txb_AltaAluApellido.Location = new System.Drawing.Point(38, 108);
            this.txb_AltaAluApellido.Name = "txb_AltaAluApellido";
            this.txb_AltaAluApellido.PlaceholderText = "Ingrese aqui";
            this.txb_AltaAluApellido.Size = new System.Drawing.Size(136, 23);
            this.txb_AltaAluApellido.TabIndex = 9;
            // 
            // txb_AltaAluDireccion
            // 
            this.txb_AltaAluDireccion.Location = new System.Drawing.Point(38, 242);
            this.txb_AltaAluDireccion.Name = "txb_AltaAluDireccion";
            this.txb_AltaAluDireccion.PlaceholderText = "Ingrese aqui";
            this.txb_AltaAluDireccion.Size = new System.Drawing.Size(136, 23);
            this.txb_AltaAluDireccion.TabIndex = 11;
            // 
            // txb_AltaAluCurso
            // 
            this.txb_AltaAluCurso.Location = new System.Drawing.Point(38, 313);
            this.txb_AltaAluCurso.Name = "txb_AltaAluCurso";
            this.txb_AltaAluCurso.PlaceholderText = "Ingrese aqui";
            this.txb_AltaAluCurso.Size = new System.Drawing.Size(136, 23);
            this.txb_AltaAluCurso.TabIndex = 12;
            // 
            // dtp_AltaAluFechaDeNac
            // 
            this.dtp_AltaAluFechaDeNac.Location = new System.Drawing.Point(38, 170);
            this.dtp_AltaAluFechaDeNac.Name = "dtp_AltaAluFechaDeNac";
            this.dtp_AltaAluFechaDeNac.Size = new System.Drawing.Size(234, 23);
            this.dtp_AltaAluFechaDeNac.TabIndex = 14;
            // 
            // chb_AltaAluMatematica1
            // 
            this.chb_AltaAluMatematica1.AutoSize = true;
            this.chb_AltaAluMatematica1.Location = new System.Drawing.Point(19, 41);
            this.chb_AltaAluMatematica1.Name = "chb_AltaAluMatematica1";
            this.chb_AltaAluMatematica1.Size = new System.Drawing.Size(95, 19);
            this.chb_AltaAluMatematica1.TabIndex = 0;
            this.chb_AltaAluMatematica1.Text = "Matematica I";
            this.chb_AltaAluMatematica1.UseVisualStyleBackColor = true;
            // 
            // chb_AltaAluIngles1
            // 
            this.chb_AltaAluIngles1.AutoSize = true;
            this.chb_AltaAluIngles1.Location = new System.Drawing.Point(283, 41);
            this.chb_AltaAluIngles1.Name = "chb_AltaAluIngles1";
            this.chb_AltaAluIngles1.Size = new System.Drawing.Size(63, 19);
            this.chb_AltaAluIngles1.TabIndex = 1;
            this.chb_AltaAluIngles1.Text = "Ingles I";
            this.chb_AltaAluIngles1.UseVisualStyleBackColor = true;
            // 
            // chb_AltaAluProgramacion1
            // 
            this.chb_AltaAluProgramacion1.AutoSize = true;
            this.chb_AltaAluProgramacion1.Location = new System.Drawing.Point(19, 90);
            this.chb_AltaAluProgramacion1.Name = "chb_AltaAluProgramacion1";
            this.chb_AltaAluProgramacion1.Size = new System.Drawing.Size(107, 19);
            this.chb_AltaAluProgramacion1.TabIndex = 2;
            this.chb_AltaAluProgramacion1.Text = "Programacion I";
            this.chb_AltaAluProgramacion1.UseVisualStyleBackColor = true;
            // 
            // chb_AltaAluLaboratorio1
            // 
            this.chb_AltaAluLaboratorio1.AutoSize = true;
            this.chb_AltaAluLaboratorio1.Location = new System.Drawing.Point(283, 90);
            this.chb_AltaAluLaboratorio1.Name = "chb_AltaAluLaboratorio1";
            this.chb_AltaAluLaboratorio1.Size = new System.Drawing.Size(93, 19);
            this.chb_AltaAluLaboratorio1.TabIndex = 3;
            this.chb_AltaAluLaboratorio1.Text = "Laboratorio I";
            this.chb_AltaAluLaboratorio1.UseVisualStyleBackColor = true;
            // 
            // chb_AltaAluSpd
            // 
            this.chb_AltaAluSpd.AutoSize = true;
            this.chb_AltaAluSpd.Location = new System.Drawing.Point(19, 137);
            this.chb_AltaAluSpd.Name = "chb_AltaAluSpd";
            this.chb_AltaAluSpd.Size = new System.Drawing.Size(213, 19);
            this.chb_AltaAluSpd.TabIndex = 4;
            this.chb_AltaAluSpd.Text = "Sistema de procesamiento de datos";
            this.chb_AltaAluSpd.UseVisualStyleBackColor = true;
            // 
            // chb_AltaAluArqSO
            // 
            this.chb_AltaAluArqSO.AutoSize = true;
            this.chb_AltaAluArqSO.Location = new System.Drawing.Point(283, 137);
            this.chb_AltaAluArqSO.Name = "chb_AltaAluArqSO";
            this.chb_AltaAluArqSO.Size = new System.Drawing.Size(126, 19);
            this.chb_AltaAluArqSO.TabIndex = 5;
            this.chb_AltaAluArqSO.Text = "Arquitectura de SO";
            this.chb_AltaAluArqSO.UseVisualStyleBackColor = true;
            // 
            // chb_AltaAluMatematica2
            // 
            this.chb_AltaAluMatematica2.AutoSize = true;
            this.chb_AltaAluMatematica2.Location = new System.Drawing.Point(19, 193);
            this.chb_AltaAluMatematica2.Name = "chb_AltaAluMatematica2";
            this.chb_AltaAluMatematica2.Size = new System.Drawing.Size(98, 19);
            this.chb_AltaAluMatematica2.TabIndex = 6;
            this.chb_AltaAluMatematica2.Text = "Matematica II";
            this.chb_AltaAluMatematica2.UseVisualStyleBackColor = true;
            // 
            // chb_AltaAluIngles2
            // 
            this.chb_AltaAluIngles2.AutoSize = true;
            this.chb_AltaAluIngles2.Location = new System.Drawing.Point(283, 193);
            this.chb_AltaAluIngles2.Name = "chb_AltaAluIngles2";
            this.chb_AltaAluIngles2.Size = new System.Drawing.Size(66, 19);
            this.chb_AltaAluIngles2.TabIndex = 7;
            this.chb_AltaAluIngles2.Text = "Ingles II";
            this.chb_AltaAluIngles2.UseVisualStyleBackColor = true;
            // 
            // chb_AltaAluProgramacion2
            // 
            this.chb_AltaAluProgramacion2.AutoSize = true;
            this.chb_AltaAluProgramacion2.Location = new System.Drawing.Point(19, 242);
            this.chb_AltaAluProgramacion2.Name = "chb_AltaAluProgramacion2";
            this.chb_AltaAluProgramacion2.Size = new System.Drawing.Size(110, 19);
            this.chb_AltaAluProgramacion2.TabIndex = 8;
            this.chb_AltaAluProgramacion2.Text = "Programacion II";
            this.chb_AltaAluProgramacion2.UseVisualStyleBackColor = true;
            // 
            // chb_AltaAluLaboratorio2
            // 
            this.chb_AltaAluLaboratorio2.AutoSize = true;
            this.chb_AltaAluLaboratorio2.Location = new System.Drawing.Point(283, 242);
            this.chb_AltaAluLaboratorio2.Name = "chb_AltaAluLaboratorio2";
            this.chb_AltaAluLaboratorio2.Size = new System.Drawing.Size(96, 19);
            this.chb_AltaAluLaboratorio2.TabIndex = 9;
            this.chb_AltaAluLaboratorio2.Text = "Laboratorio II";
            this.chb_AltaAluLaboratorio2.UseVisualStyleBackColor = true;
            // 
            // FrmAltaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.dtp_AltaAluFechaDeNac);
            this.Controls.Add(this.txb_AltaAluCurso);
            this.Controls.Add(this.txb_AltaAluDireccion);
            this.Controls.Add(this.txb_AltaAluApellido);
            this.Controls.Add(this.txb_AltaAluNombre);
            this.Controls.Add(this.gpb_AltaAluMaterias);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_AltaAluCurso);
            this.Controls.Add(this.lb_AltaAluDireccion);
            this.Controls.Add(this.lb_AltaAluFechaNac);
            this.Controls.Add(this.lb_AltaAluApellido);
            this.Controls.Add(this.lb_AltaAluNombre);
            this.Name = "FrmAltaAlumno";
            this.Text = "Alta alumno";
            this.gpb_AltaAluMaterias.ResumeLayout(false);
            this.gpb_AltaAluMaterias.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_AltaAluNombre;
        private Label lb_AltaAluApellido;
        private Label lb_AltaAluFechaNac;
        private Label lb_AltaAluDireccion;
        private Label lb_AltaAluCurso;
        private Button button1;
        private GroupBox gpb_AltaAluMaterias;
        private TextBox txb_AltaAluNombre;
        private TextBox txb_AltaAluApellido;
        private TextBox txb_AltaAluDireccion;
        private TextBox txb_AltaAluCurso;
        private DateTimePicker dtp_AltaAluFechaDeNac;
        private CheckBox chb_AltaAluLaboratorio2;
        private CheckBox chb_AltaAluProgramacion2;
        private CheckBox chb_AltaAluIngles2;
        private CheckBox chb_AltaAluMatematica2;
        private CheckBox chb_AltaAluArqSO;
        private CheckBox chb_AltaAluSpd;
        private CheckBox chb_AltaAluLaboratorio1;
        private CheckBox chb_AltaAluProgramacion1;
        private CheckBox chb_AltaAluIngles1;
        private CheckBox chb_AltaAluMatematica1;
    }
}