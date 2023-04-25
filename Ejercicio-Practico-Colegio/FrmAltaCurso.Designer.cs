namespace Ejercicio_Practico_Colegio
{
    partial class FrmAltaCurso
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
            this.lb_AltaCursoSeleccionarAño = new System.Windows.Forms.Label();
            this.rdb_RegisCurso1Año = new System.Windows.Forms.RadioButton();
            this.rdb_RegisCurso2Año = new System.Windows.Forms.RadioButton();
            this.rdb_RegisCurso3Año = new System.Windows.Forms.RadioButton();
            this.rdb_RegisCurso4Año = new System.Windows.Forms.RadioButton();
            this.rdb_RegisCurso5Año = new System.Windows.Forms.RadioButton();
            this.rch_AltaCursoListaUso = new System.Windows.Forms.RichTextBox();
            this.lb_AltaCursoAño = new System.Windows.Forms.Label();
            this.lb_AltaCursoEnUso = new System.Windows.Forms.Label();
            this.cmb_AltaCursoDisponibles = new System.Windows.Forms.ComboBox();
            this.lb_AltaCursoDisponible = new System.Windows.Forms.Label();
            this.btn_AltaCursoRegistrar = new System.Windows.Forms.Button();
            this.btn_AltaCursoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_AltaCursoSeleccionarAño
            // 
            this.lb_AltaCursoSeleccionarAño.AutoSize = true;
            this.lb_AltaCursoSeleccionarAño.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_AltaCursoSeleccionarAño.Location = new System.Drawing.Point(12, 26);
            this.lb_AltaCursoSeleccionarAño.Name = "lb_AltaCursoSeleccionarAño";
            this.lb_AltaCursoSeleccionarAño.Size = new System.Drawing.Size(291, 19);
            this.lb_AltaCursoSeleccionarAño.TabIndex = 0;
            this.lb_AltaCursoSeleccionarAño.Text = "Seleccione el año del curso que desea agregar:";
            // 
            // rdb_RegisCurso1Año
            // 
            this.rdb_RegisCurso1Año.AutoSize = true;
            this.rdb_RegisCurso1Año.Location = new System.Drawing.Point(45, 66);
            this.rdb_RegisCurso1Año.Name = "rdb_RegisCurso1Año";
            this.rdb_RegisCurso1Año.Size = new System.Drawing.Size(66, 19);
            this.rdb_RegisCurso1Año.TabIndex = 1;
            this.rdb_RegisCurso1Año.Text = "1er Año";
            this.rdb_RegisCurso1Año.UseVisualStyleBackColor = true;
            this.rdb_RegisCurso1Año.CheckedChanged += new System.EventHandler(this.rdb_RegisCurso1Año_CheckedChanged_1);
            // 
            // rdb_RegisCurso2Año
            // 
            this.rdb_RegisCurso2Año.AutoSize = true;
            this.rdb_RegisCurso2Año.Location = new System.Drawing.Point(199, 66);
            this.rdb_RegisCurso2Año.Name = "rdb_RegisCurso2Año";
            this.rdb_RegisCurso2Año.Size = new System.Drawing.Size(70, 19);
            this.rdb_RegisCurso2Año.TabIndex = 2;
            this.rdb_RegisCurso2Año.Text = "2do Año";
            this.rdb_RegisCurso2Año.UseVisualStyleBackColor = true;
            this.rdb_RegisCurso2Año.CheckedChanged += new System.EventHandler(this.rdb_RegisCurso2Año_CheckedChanged_1);
            // 
            // rdb_RegisCurso3Año
            // 
            this.rdb_RegisCurso3Año.AutoSize = true;
            this.rdb_RegisCurso3Año.Location = new System.Drawing.Point(360, 66);
            this.rdb_RegisCurso3Año.Name = "rdb_RegisCurso3Año";
            this.rdb_RegisCurso3Año.Size = new System.Drawing.Size(66, 19);
            this.rdb_RegisCurso3Año.TabIndex = 3;
            this.rdb_RegisCurso3Año.Text = "3er Año";
            this.rdb_RegisCurso3Año.UseVisualStyleBackColor = true;
            this.rdb_RegisCurso3Año.CheckedChanged += new System.EventHandler(this.rdb_RegisCurso3Año_CheckedChanged_1);
            // 
            // rdb_RegisCurso4Año
            // 
            this.rdb_RegisCurso4Año.AutoSize = true;
            this.rdb_RegisCurso4Año.Location = new System.Drawing.Point(513, 66);
            this.rdb_RegisCurso4Año.Name = "rdb_RegisCurso4Año";
            this.rdb_RegisCurso4Año.Size = new System.Drawing.Size(67, 19);
            this.rdb_RegisCurso4Año.TabIndex = 4;
            this.rdb_RegisCurso4Año.Text = "4to Año";
            this.rdb_RegisCurso4Año.UseVisualStyleBackColor = true;
            this.rdb_RegisCurso4Año.CheckedChanged += new System.EventHandler(this.rdb_RegisCurso4Año_CheckedChanged_1);
            // 
            // rdb_RegisCurso5Año
            // 
            this.rdb_RegisCurso5Año.AutoSize = true;
            this.rdb_RegisCurso5Año.Location = new System.Drawing.Point(659, 66);
            this.rdb_RegisCurso5Año.Name = "rdb_RegisCurso5Año";
            this.rdb_RegisCurso5Año.Size = new System.Drawing.Size(67, 19);
            this.rdb_RegisCurso5Año.TabIndex = 5;
            this.rdb_RegisCurso5Año.Text = "5to Año";
            this.rdb_RegisCurso5Año.UseVisualStyleBackColor = true;
            this.rdb_RegisCurso5Año.CheckedChanged += new System.EventHandler(this.rdb_RegisCurso5Año_CheckedChanged_1);
            // 
            // rch_AltaCursoListaUso
            // 
            this.rch_AltaCursoListaUso.Location = new System.Drawing.Point(478, 216);
            this.rch_AltaCursoListaUso.Name = "rch_AltaCursoListaUso";
            this.rch_AltaCursoListaUso.Size = new System.Drawing.Size(294, 146);
            this.rch_AltaCursoListaUso.TabIndex = 6;
            this.rch_AltaCursoListaUso.Text = "";
            // 
            // lb_AltaCursoAño
            // 
            this.lb_AltaCursoAño.AutoSize = true;
            this.lb_AltaCursoAño.Location = new System.Drawing.Point(45, 152);
            this.lb_AltaCursoAño.Name = "lb_AltaCursoAño";
            this.lb_AltaCursoAño.Size = new System.Drawing.Size(38, 15);
            this.lb_AltaCursoAño.TabIndex = 7;
            this.lb_AltaCursoAño.Text = "label1";
            // 
            // lb_AltaCursoEnUso
            // 
            this.lb_AltaCursoEnUso.AutoSize = true;
            this.lb_AltaCursoEnUso.Location = new System.Drawing.Point(478, 195);
            this.lb_AltaCursoEnUso.Name = "lb_AltaCursoEnUso";
            this.lb_AltaCursoEnUso.Size = new System.Drawing.Size(84, 15);
            this.lb_AltaCursoEnUso.TabIndex = 8;
            this.lb_AltaCursoEnUso.Text = "Cursos en uso:";
            // 
            // cmb_AltaCursoDisponibles
            // 
            this.cmb_AltaCursoDisponibles.FormattingEnabled = true;
            this.cmb_AltaCursoDisponibles.Location = new System.Drawing.Point(45, 216);
            this.cmb_AltaCursoDisponibles.Name = "cmb_AltaCursoDisponibles";
            this.cmb_AltaCursoDisponibles.Size = new System.Drawing.Size(121, 23);
            this.cmb_AltaCursoDisponibles.TabIndex = 9;
            // 
            // lb_AltaCursoDisponible
            // 
            this.lb_AltaCursoDisponible.AutoSize = true;
            this.lb_AltaCursoDisponible.Location = new System.Drawing.Point(45, 195);
            this.lb_AltaCursoDisponible.Name = "lb_AltaCursoDisponible";
            this.lb_AltaCursoDisponible.Size = new System.Drawing.Size(109, 15);
            this.lb_AltaCursoDisponible.TabIndex = 10;
            this.lb_AltaCursoDisponible.Text = "Cursos disponibles:";
            // 
            // btn_AltaCursoRegistrar
            // 
            this.btn_AltaCursoRegistrar.Location = new System.Drawing.Point(680, 393);
            this.btn_AltaCursoRegistrar.Name = "btn_AltaCursoRegistrar";
            this.btn_AltaCursoRegistrar.Size = new System.Drawing.Size(92, 35);
            this.btn_AltaCursoRegistrar.TabIndex = 11;
            this.btn_AltaCursoRegistrar.Text = "Registrar";
            this.btn_AltaCursoRegistrar.UseVisualStyleBackColor = true;
            // 
            // btn_AltaCursoCancelar
            // 
            this.btn_AltaCursoCancelar.Location = new System.Drawing.Point(28, 393);
            this.btn_AltaCursoCancelar.Name = "btn_AltaCursoCancelar";
            this.btn_AltaCursoCancelar.Size = new System.Drawing.Size(92, 35);
            this.btn_AltaCursoCancelar.TabIndex = 12;
            this.btn_AltaCursoCancelar.Text = "Cancelar";
            this.btn_AltaCursoCancelar.UseVisualStyleBackColor = true;
            // 
            // FrmAltaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_AltaCursoCancelar);
            this.Controls.Add(this.btn_AltaCursoRegistrar);
            this.Controls.Add(this.lb_AltaCursoDisponible);
            this.Controls.Add(this.cmb_AltaCursoDisponibles);
            this.Controls.Add(this.lb_AltaCursoEnUso);
            this.Controls.Add(this.lb_AltaCursoAño);
            this.Controls.Add(this.rch_AltaCursoListaUso);
            this.Controls.Add(this.rdb_RegisCurso5Año);
            this.Controls.Add(this.rdb_RegisCurso4Año);
            this.Controls.Add(this.rdb_RegisCurso3Año);
            this.Controls.Add(this.rdb_RegisCurso2Año);
            this.Controls.Add(this.rdb_RegisCurso1Año);
            this.Controls.Add(this.lb_AltaCursoSeleccionarAño);
            this.Name = "FrmAltaCurso";
            this.Text = "Alta curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_AltaCursoSeleccionarAño;
        private RadioButton rdb_RegisCurso1Año;
        private RadioButton rdb_RegisCurso2Año;
        private RadioButton rdb_RegisCurso3Año;
        private RadioButton rdb_RegisCurso4Año;
        private RadioButton rdb_RegisCurso5Año;
        private RichTextBox rch_AltaCursoListaUso;
        private Label lb_AltaCursoAño;
        private Label lb_AltaCursoEnUso;
        private ComboBox cmb_AltaCursoDisponibles;
        private Label lb_AltaCursoDisponible;
        private Button btn_AltaCursoRegistrar;
        private Button btn_AltaCursoCancelar;
    }
}