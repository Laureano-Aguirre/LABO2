namespace _6CEjercicio02
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpb_DetallesDeUsuario = new System.Windows.Forms.GroupBox();
            this.nud_Edad = new System.Windows.Forms.NumericUpDown();
            this.txb_Direccion = new System.Windows.Forms.TextBox();
            this.txb_Nombre = new System.Windows.Forms.TextBox();
            this.lb_Edad = new System.Windows.Forms.Label();
            this.lb_Direccion = new System.Windows.Forms.Label();
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.gpb_Genero = new System.Windows.Forms.GroupBox();
            this.rdb_GenNoBin = new System.Windows.Forms.RadioButton();
            this.rdb_GenFem = new System.Windows.Forms.RadioButton();
            this.rdb_GenMasc = new System.Windows.Forms.RadioButton();
            this.gpb_Cursos = new System.Windows.Forms.GroupBox();
            this.chb_JavaScript = new System.Windows.Forms.CheckBox();
            this.chb_CMasMas = new System.Windows.Forms.CheckBox();
            this.chb_CSharp = new System.Windows.Forms.CheckBox();
            this.lbx_Pais = new System.Windows.Forms.ListBox();
            this.lb_Pais = new System.Windows.Forms.Label();
            this.btn_Ingresar = new System.Windows.Forms.Button();
            this.gpb_DetallesDeUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Edad)).BeginInit();
            this.gpb_Genero.SuspendLayout();
            this.gpb_Cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_DetallesDeUsuario
            // 
            this.gpb_DetallesDeUsuario.Controls.Add(this.nud_Edad);
            this.gpb_DetallesDeUsuario.Controls.Add(this.txb_Direccion);
            this.gpb_DetallesDeUsuario.Controls.Add(this.txb_Nombre);
            this.gpb_DetallesDeUsuario.Controls.Add(this.lb_Edad);
            this.gpb_DetallesDeUsuario.Controls.Add(this.lb_Direccion);
            this.gpb_DetallesDeUsuario.Controls.Add(this.lb_Nombre);
            this.gpb_DetallesDeUsuario.Location = new System.Drawing.Point(37, 80);
            this.gpb_DetallesDeUsuario.Name = "gpb_DetallesDeUsuario";
            this.gpb_DetallesDeUsuario.Size = new System.Drawing.Size(283, 175);
            this.gpb_DetallesDeUsuario.TabIndex = 0;
            this.gpb_DetallesDeUsuario.TabStop = false;
            this.gpb_DetallesDeUsuario.Text = "Detalles del usuario";
            // 
            // nud_Edad
            // 
            this.nud_Edad.Location = new System.Drawing.Point(90, 126);
            this.nud_Edad.Name = "nud_Edad";
            this.nud_Edad.Size = new System.Drawing.Size(129, 23);
            this.nud_Edad.TabIndex = 5;
            // 
            // txb_Direccion
            // 
            this.txb_Direccion.Location = new System.Drawing.Point(90, 80);
            this.txb_Direccion.Name = "txb_Direccion";
            this.txb_Direccion.PlaceholderText = "Ingrese direccion";
            this.txb_Direccion.Size = new System.Drawing.Size(129, 23);
            this.txb_Direccion.TabIndex = 4;
            // 
            // txb_Nombre
            // 
            this.txb_Nombre.Location = new System.Drawing.Point(90, 35);
            this.txb_Nombre.Name = "txb_Nombre";
            this.txb_Nombre.PlaceholderText = "Ingrese nombre";
            this.txb_Nombre.Size = new System.Drawing.Size(129, 23);
            this.txb_Nombre.TabIndex = 3;
            // 
            // lb_Edad
            // 
            this.lb_Edad.AutoSize = true;
            this.lb_Edad.Location = new System.Drawing.Point(6, 128);
            this.lb_Edad.Name = "lb_Edad";
            this.lb_Edad.Size = new System.Drawing.Size(33, 15);
            this.lb_Edad.TabIndex = 2;
            this.lb_Edad.Text = "Edad";
            // 
            // lb_Direccion
            // 
            this.lb_Direccion.AutoSize = true;
            this.lb_Direccion.Location = new System.Drawing.Point(6, 83);
            this.lb_Direccion.Name = "lb_Direccion";
            this.lb_Direccion.Size = new System.Drawing.Size(57, 15);
            this.lb_Direccion.TabIndex = 1;
            this.lb_Direccion.Text = "Direccion";
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(6, 38);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(51, 15);
            this.lb_Nombre.TabIndex = 0;
            this.lb_Nombre.Text = "Nombre";
            // 
            // gpb_Genero
            // 
            this.gpb_Genero.Controls.Add(this.rdb_GenNoBin);
            this.gpb_Genero.Controls.Add(this.rdb_GenFem);
            this.gpb_Genero.Controls.Add(this.rdb_GenMasc);
            this.gpb_Genero.Location = new System.Drawing.Point(458, 80);
            this.gpb_Genero.Name = "gpb_Genero";
            this.gpb_Genero.Size = new System.Drawing.Size(182, 130);
            this.gpb_Genero.TabIndex = 1;
            this.gpb_Genero.TabStop = false;
            this.gpb_Genero.Text = "Genero";
            // 
            // rdb_GenNoBin
            // 
            this.rdb_GenNoBin.AutoSize = true;
            this.rdb_GenNoBin.Location = new System.Drawing.Point(17, 96);
            this.rdb_GenNoBin.Name = "rdb_GenNoBin";
            this.rdb_GenNoBin.Size = new System.Drawing.Size(81, 19);
            this.rdb_GenNoBin.TabIndex = 2;
            this.rdb_GenNoBin.TabStop = true;
            this.rdb_GenNoBin.Text = "No binario";
            this.rdb_GenNoBin.UseVisualStyleBackColor = true;
            // 
            // rdb_GenFem
            // 
            this.rdb_GenFem.AutoSize = true;
            this.rdb_GenFem.Location = new System.Drawing.Point(17, 59);
            this.rdb_GenFem.Name = "rdb_GenFem";
            this.rdb_GenFem.Size = new System.Drawing.Size(78, 19);
            this.rdb_GenFem.TabIndex = 1;
            this.rdb_GenFem.TabStop = true;
            this.rdb_GenFem.Text = "Femenino";
            this.rdb_GenFem.UseVisualStyleBackColor = true;
            // 
            // rdb_GenMasc
            // 
            this.rdb_GenMasc.AutoSize = true;
            this.rdb_GenMasc.Location = new System.Drawing.Point(17, 22);
            this.rdb_GenMasc.Name = "rdb_GenMasc";
            this.rdb_GenMasc.Size = new System.Drawing.Size(80, 19);
            this.rdb_GenMasc.TabIndex = 0;
            this.rdb_GenMasc.TabStop = true;
            this.rdb_GenMasc.Text = "Masculino";
            this.rdb_GenMasc.UseVisualStyleBackColor = true;
            // 
            // gpb_Cursos
            // 
            this.gpb_Cursos.Controls.Add(this.chb_JavaScript);
            this.gpb_Cursos.Controls.Add(this.chb_CMasMas);
            this.gpb_Cursos.Controls.Add(this.chb_CSharp);
            this.gpb_Cursos.Location = new System.Drawing.Point(458, 232);
            this.gpb_Cursos.Name = "gpb_Cursos";
            this.gpb_Cursos.Size = new System.Drawing.Size(182, 130);
            this.gpb_Cursos.TabIndex = 2;
            this.gpb_Cursos.TabStop = false;
            this.gpb_Cursos.Text = "Cursos";
            // 
            // chb_JavaScript
            // 
            this.chb_JavaScript.AutoSize = true;
            this.chb_JavaScript.Location = new System.Drawing.Point(17, 90);
            this.chb_JavaScript.Name = "chb_JavaScript";
            this.chb_JavaScript.Size = new System.Drawing.Size(78, 19);
            this.chb_JavaScript.TabIndex = 2;
            this.chb_JavaScript.Text = "JavaScript";
            this.chb_JavaScript.UseVisualStyleBackColor = true;
            // 
            // chb_CMasMas
            // 
            this.chb_CMasMas.AutoSize = true;
            this.chb_CMasMas.Location = new System.Drawing.Point(17, 56);
            this.chb_CMasMas.Name = "chb_CMasMas";
            this.chb_CMasMas.Size = new System.Drawing.Size(50, 19);
            this.chb_CMasMas.TabIndex = 1;
            this.chb_CMasMas.Text = "C++";
            this.chb_CMasMas.UseVisualStyleBackColor = true;
            // 
            // chb_CSharp
            // 
            this.chb_CSharp.AutoSize = true;
            this.chb_CSharp.Location = new System.Drawing.Point(17, 22);
            this.chb_CSharp.Name = "chb_CSharp";
            this.chb_CSharp.Size = new System.Drawing.Size(41, 19);
            this.chb_CSharp.TabIndex = 0;
            this.chb_CSharp.Text = "C#";
            this.chb_CSharp.UseVisualStyleBackColor = true;
            // 
            // lbx_Pais
            // 
            this.lbx_Pais.FormattingEnabled = true;
            this.lbx_Pais.ItemHeight = 15;
            this.lbx_Pais.Location = new System.Drawing.Point(37, 288);
            this.lbx_Pais.Name = "lbx_Pais";
            this.lbx_Pais.Size = new System.Drawing.Size(283, 94);
            this.lbx_Pais.TabIndex = 3;
            // 
            // lb_Pais
            // 
            this.lb_Pais.AutoSize = true;
            this.lb_Pais.Location = new System.Drawing.Point(37, 270);
            this.lb_Pais.Name = "lb_Pais";
            this.lb_Pais.Size = new System.Drawing.Size(28, 15);
            this.lb_Pais.TabIndex = 4;
            this.lb_Pais.Text = "Pais";
            // 
            // btn_Ingresar
            // 
            this.btn_Ingresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Ingresar.Location = new System.Drawing.Point(522, 387);
            this.btn_Ingresar.Name = "btn_Ingresar";
            this.btn_Ingresar.Size = new System.Drawing.Size(118, 36);
            this.btn_Ingresar.TabIndex = 5;
            this.btn_Ingresar.Text = "Ingresar";
            this.btn_Ingresar.UseVisualStyleBackColor = true;
            this.btn_Ingresar.Click += new System.EventHandler(this.btn_Ingresar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.btn_Ingresar);
            this.Controls.Add(this.lb_Pais);
            this.Controls.Add(this.lbx_Pais);
            this.Controls.Add(this.gpb_Cursos);
            this.Controls.Add(this.gpb_Genero);
            this.Controls.Add(this.gpb_DetallesDeUsuario);
            this.Name = "Form1";
            this.Text = "Registro";
            this.gpb_DetallesDeUsuario.ResumeLayout(false);
            this.gpb_DetallesDeUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Edad)).EndInit();
            this.gpb_Genero.ResumeLayout(false);
            this.gpb_Genero.PerformLayout();
            this.gpb_Cursos.ResumeLayout(false);
            this.gpb_Cursos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox gpb_DetallesDeUsuario;
        private NumericUpDown nud_Edad;
        private TextBox txb_Direccion;
        private TextBox txb_Nombre;
        private Label lb_Edad;
        private Label lb_Direccion;
        private Label lb_Nombre;
        private GroupBox gpb_Genero;
        private RadioButton rdb_GenNoBin;
        private RadioButton rdb_GenFem;
        private RadioButton rdb_GenMasc;
        private GroupBox gpb_Cursos;
        private CheckBox chb_JavaScript;
        private CheckBox chb_CMasMas;
        private CheckBox chb_CSharp;
        private ListBox lbx_Pais;
        private Label lb_Pais;
        private Button btn_Ingresar;
    }
}