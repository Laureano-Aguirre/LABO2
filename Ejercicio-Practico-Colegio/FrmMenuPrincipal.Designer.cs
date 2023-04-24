namespace Ejercicio_Practico_Colegio
{
    partial class FrmMenuPrincipal
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
            components = new System.ComponentModel.Container();
            lb_Bienvenida = new Label();
            gpb_Registrar = new GroupBox();
            btn_RegistrarCurso = new Button();
            btn_RegistrarMat = new Button();
            btn_RegistrarAlum = new Button();
            gpb_Ver = new GroupBox();
            btn_VerCurso = new Button();
            btn_VerMateria = new Button();
            btn_VerAlumno = new Button();
            pb_MenPrinLogo = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            lb_Hora = new Label();
            gpb_Registrar.SuspendLayout();
            gpb_Ver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_MenPrinLogo).BeginInit();
            SuspendLayout();
            // 
            // lb_Bienvenida
            // 
            lb_Bienvenida.AutoSize = true;
            lb_Bienvenida.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Bienvenida.Location = new Point(55, 31);
            lb_Bienvenida.Name = "lb_Bienvenida";
            lb_Bienvenida.Size = new Size(50, 18);
            lb_Bienvenida.TabIndex = 0;
            lb_Bienvenida.Text = "label1";
            // 
            // gpb_Registrar
            // 
            gpb_Registrar.Controls.Add(btn_RegistrarCurso);
            gpb_Registrar.Controls.Add(btn_RegistrarMat);
            gpb_Registrar.Controls.Add(btn_RegistrarAlum);
            gpb_Registrar.Location = new Point(38, 89);
            gpb_Registrar.Name = "gpb_Registrar";
            gpb_Registrar.Size = new Size(307, 100);
            gpb_Registrar.TabIndex = 2;
            gpb_Registrar.TabStop = false;
            gpb_Registrar.Text = "Registrar";
            // 
            // btn_RegistrarCurso
            // 
            btn_RegistrarCurso.Location = new Point(215, 43);
            btn_RegistrarCurso.Name = "btn_RegistrarCurso";
            btn_RegistrarCurso.Size = new Size(75, 23);
            btn_RegistrarCurso.TabIndex = 2;
            btn_RegistrarCurso.Text = "Curso";
            btn_RegistrarCurso.UseVisualStyleBackColor = true;
            btn_RegistrarCurso.Click += btn_RegistrarCurso_Click;
            // 
            // btn_RegistrarMat
            // 
            btn_RegistrarMat.Location = new Point(115, 43);
            btn_RegistrarMat.Name = "btn_RegistrarMat";
            btn_RegistrarMat.Size = new Size(75, 23);
            btn_RegistrarMat.TabIndex = 1;
            btn_RegistrarMat.Text = "Materia";
            btn_RegistrarMat.UseVisualStyleBackColor = true;
            // 
            // btn_RegistrarAlum
            // 
            btn_RegistrarAlum.Location = new Point(17, 43);
            btn_RegistrarAlum.Name = "btn_RegistrarAlum";
            btn_RegistrarAlum.Size = new Size(75, 23);
            btn_RegistrarAlum.TabIndex = 0;
            btn_RegistrarAlum.Text = "Alumno";
            btn_RegistrarAlum.UseVisualStyleBackColor = true;
            btn_RegistrarAlum.Click += btn_RegistrarAlum_Click;
            // 
            // gpb_Ver
            // 
            gpb_Ver.Controls.Add(btn_VerCurso);
            gpb_Ver.Controls.Add(btn_VerMateria);
            gpb_Ver.Controls.Add(btn_VerAlumno);
            gpb_Ver.Location = new Point(452, 89);
            gpb_Ver.Name = "gpb_Ver";
            gpb_Ver.Size = new Size(307, 100);
            gpb_Ver.TabIndex = 3;
            gpb_Ver.TabStop = false;
            gpb_Ver.Text = "Ver";
            // 
            // btn_VerCurso
            // 
            btn_VerCurso.Location = new Point(215, 43);
            btn_VerCurso.Name = "btn_VerCurso";
            btn_VerCurso.Size = new Size(75, 23);
            btn_VerCurso.TabIndex = 2;
            btn_VerCurso.Text = "Curso";
            btn_VerCurso.UseVisualStyleBackColor = true;
            // 
            // btn_VerMateria
            // 
            btn_VerMateria.Location = new Point(115, 43);
            btn_VerMateria.Name = "btn_VerMateria";
            btn_VerMateria.Size = new Size(75, 23);
            btn_VerMateria.TabIndex = 1;
            btn_VerMateria.Text = "Materia";
            btn_VerMateria.UseVisualStyleBackColor = true;
            // 
            // btn_VerAlumno
            // 
            btn_VerAlumno.Location = new Point(17, 43);
            btn_VerAlumno.Name = "btn_VerAlumno";
            btn_VerAlumno.Size = new Size(75, 23);
            btn_VerAlumno.TabIndex = 0;
            btn_VerAlumno.Text = "Alumno";
            btn_VerAlumno.UseVisualStyleBackColor = true;
            // 
            // pb_MenPrinLogo
            // 
            pb_MenPrinLogo.Image = Properties.Resources.imagen_huergo;
            pb_MenPrinLogo.Location = new Point(73, 213);
            pb_MenPrinLogo.Name = "pb_MenPrinLogo";
            pb_MenPrinLogo.Size = new Size(222, 225);
            pb_MenPrinLogo.TabIndex = 4;
            pb_MenPrinLogo.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lb_Hora
            // 
            lb_Hora.AutoSize = true;
            lb_Hora.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Hora.Location = new Point(480, 282);
            lb_Hora.Name = "lb_Hora";
            lb_Hora.Size = new Size(194, 81);
            lb_Hora.TabIndex = 5;
            lb_Hora.Text = "label1";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lb_Hora);
            Controls.Add(pb_MenPrinLogo);
            Controls.Add(gpb_Ver);
            Controls.Add(gpb_Registrar);
            Controls.Add(lb_Bienvenida);
            Name = "FrmMenuPrincipal";
            Text = "Menu Principal";
            FormClosing += FrmMenuPrincipal_FormClosing;
            Load += FrmMenuPrincipal_Load;
            gpb_Registrar.ResumeLayout(false);
            gpb_Ver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_MenPrinLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Bienvenida;
        private GroupBox gpb_Registrar;
        private Button btn_RegistrarCurso;
        private Button btn_RegistrarMat;
        private Button btn_RegistrarAlum;
        private GroupBox gpb_Ver;
        private Button btn_VerCurso;
        private Button btn_VerMateria;
        private Button btn_VerAlumno;
        private PictureBox pb_MenPrinLogo;
        private System.Windows.Forms.Timer timer1;
        private Label lb_Hora;
    }
}