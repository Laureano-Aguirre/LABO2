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
            this.components = new System.ComponentModel.Container();
            this.lb_Bienvenida = new System.Windows.Forms.Label();
            this.gpb_Registrar = new System.Windows.Forms.GroupBox();
            this.btn_RegistrarClas = new System.Windows.Forms.Button();
            this.btn_RegistrarMat = new System.Windows.Forms.Button();
            this.btn_RegistrarAlum = new System.Windows.Forms.Button();
            this.gpb_Ver = new System.Windows.Forms.GroupBox();
            this.btn_VerClase = new System.Windows.Forms.Button();
            this.btn_VerMateria = new System.Windows.Forms.Button();
            this.btn_VerAlumno = new System.Windows.Forms.Button();
            this.pb_MenPrinLogo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_Hora = new System.Windows.Forms.Label();
            this.gpb_Registrar.SuspendLayout();
            this.gpb_Ver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenPrinLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Bienvenida
            // 
            this.lb_Bienvenida.AutoSize = true;
            this.lb_Bienvenida.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Bienvenida.Location = new System.Drawing.Point(55, 31);
            this.lb_Bienvenida.Name = "lb_Bienvenida";
            this.lb_Bienvenida.Size = new System.Drawing.Size(50, 18);
            this.lb_Bienvenida.TabIndex = 0;
            this.lb_Bienvenida.Text = "label1";
            // 
            // gpb_Registrar
            // 
            this.gpb_Registrar.Controls.Add(this.btn_RegistrarClas);
            this.gpb_Registrar.Controls.Add(this.btn_RegistrarMat);
            this.gpb_Registrar.Controls.Add(this.btn_RegistrarAlum);
            this.gpb_Registrar.Location = new System.Drawing.Point(38, 89);
            this.gpb_Registrar.Name = "gpb_Registrar";
            this.gpb_Registrar.Size = new System.Drawing.Size(307, 100);
            this.gpb_Registrar.TabIndex = 2;
            this.gpb_Registrar.TabStop = false;
            this.gpb_Registrar.Text = "Registrar";
            // 
            // btn_RegistrarClas
            // 
            this.btn_RegistrarClas.Location = new System.Drawing.Point(215, 43);
            this.btn_RegistrarClas.Name = "btn_RegistrarClas";
            this.btn_RegistrarClas.Size = new System.Drawing.Size(75, 23);
            this.btn_RegistrarClas.TabIndex = 2;
            this.btn_RegistrarClas.Text = "Clase";
            this.btn_RegistrarClas.UseVisualStyleBackColor = true;
            // 
            // btn_RegistrarMat
            // 
            this.btn_RegistrarMat.Location = new System.Drawing.Point(115, 43);
            this.btn_RegistrarMat.Name = "btn_RegistrarMat";
            this.btn_RegistrarMat.Size = new System.Drawing.Size(75, 23);
            this.btn_RegistrarMat.TabIndex = 1;
            this.btn_RegistrarMat.Text = "Materia";
            this.btn_RegistrarMat.UseVisualStyleBackColor = true;
            // 
            // btn_RegistrarAlum
            // 
            this.btn_RegistrarAlum.Location = new System.Drawing.Point(17, 43);
            this.btn_RegistrarAlum.Name = "btn_RegistrarAlum";
            this.btn_RegistrarAlum.Size = new System.Drawing.Size(75, 23);
            this.btn_RegistrarAlum.TabIndex = 0;
            this.btn_RegistrarAlum.Text = "Alumno";
            this.btn_RegistrarAlum.UseVisualStyleBackColor = true;
            this.btn_RegistrarAlum.Click += new System.EventHandler(this.btn_RegistrarAlum_Click);
            // 
            // gpb_Ver
            // 
            this.gpb_Ver.Controls.Add(this.btn_VerClase);
            this.gpb_Ver.Controls.Add(this.btn_VerMateria);
            this.gpb_Ver.Controls.Add(this.btn_VerAlumno);
            this.gpb_Ver.Location = new System.Drawing.Point(452, 89);
            this.gpb_Ver.Name = "gpb_Ver";
            this.gpb_Ver.Size = new System.Drawing.Size(307, 100);
            this.gpb_Ver.TabIndex = 3;
            this.gpb_Ver.TabStop = false;
            this.gpb_Ver.Text = "Ver";
            // 
            // btn_VerClase
            // 
            this.btn_VerClase.Location = new System.Drawing.Point(215, 43);
            this.btn_VerClase.Name = "btn_VerClase";
            this.btn_VerClase.Size = new System.Drawing.Size(75, 23);
            this.btn_VerClase.TabIndex = 2;
            this.btn_VerClase.Text = "Clase";
            this.btn_VerClase.UseVisualStyleBackColor = true;
            // 
            // btn_VerMateria
            // 
            this.btn_VerMateria.Location = new System.Drawing.Point(115, 43);
            this.btn_VerMateria.Name = "btn_VerMateria";
            this.btn_VerMateria.Size = new System.Drawing.Size(75, 23);
            this.btn_VerMateria.TabIndex = 1;
            this.btn_VerMateria.Text = "Materia";
            this.btn_VerMateria.UseVisualStyleBackColor = true;
            // 
            // btn_VerAlumno
            // 
            this.btn_VerAlumno.Location = new System.Drawing.Point(17, 43);
            this.btn_VerAlumno.Name = "btn_VerAlumno";
            this.btn_VerAlumno.Size = new System.Drawing.Size(75, 23);
            this.btn_VerAlumno.TabIndex = 0;
            this.btn_VerAlumno.Text = "Alumno";
            this.btn_VerAlumno.UseVisualStyleBackColor = true;
            // 
            // pb_MenPrinLogo
            // 
            this.pb_MenPrinLogo.Image = global::Ejercicio_Practico_Colegio.Properties.Resources.imagen_huergo;
            this.pb_MenPrinLogo.Location = new System.Drawing.Point(73, 213);
            this.pb_MenPrinLogo.Name = "pb_MenPrinLogo";
            this.pb_MenPrinLogo.Size = new System.Drawing.Size(222, 225);
            this.pb_MenPrinLogo.TabIndex = 4;
            this.pb_MenPrinLogo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_Hora
            // 
            this.lb_Hora.AutoSize = true;
            this.lb_Hora.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Hora.Location = new System.Drawing.Point(480, 282);
            this.lb_Hora.Name = "lb_Hora";
            this.lb_Hora.Size = new System.Drawing.Size(194, 81);
            this.lb_Hora.TabIndex = 5;
            this.lb_Hora.Text = "label1";
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Hora);
            this.Controls.Add(this.pb_MenPrinLogo);
            this.Controls.Add(this.gpb_Ver);
            this.Controls.Add(this.gpb_Registrar);
            this.Controls.Add(this.lb_Bienvenida);
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.gpb_Registrar.ResumeLayout(false);
            this.gpb_Ver.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_MenPrinLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_Bienvenida;
        private GroupBox gpb_Registrar;
        private Button btn_RegistrarClas;
        private Button btn_RegistrarMat;
        private Button btn_RegistrarAlum;
        private GroupBox gpb_Ver;
        private Button btn_VerClase;
        private Button btn_VerMateria;
        private Button btn_VerAlumno;
        private PictureBox pb_MenPrinLogo;
        private System.Windows.Forms.Timer timer1;
        private Label lb_Hora;
    }
}