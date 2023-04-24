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
            lb_AltaCursoSeleccionarAño = new Label();
            rdb_RegisCurso1Año = new RadioButton();
            rdb_RegisCurso2Año = new RadioButton();
            rdb_RegisCurso3Año = new RadioButton();
            rdb_RegisCurso4Año = new RadioButton();
            rdb_RegisCurso5Año = new RadioButton();
            rch_AltaCursoListaUso = new RichTextBox();
            lb_AltaCursoAño = new Label();
            lb_AltaCursoEnUso = new Label();
            cmb_AltaCursoDisponibles = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lb_AltaCursoSeleccionarAño
            // 
            lb_AltaCursoSeleccionarAño.AutoSize = true;
            lb_AltaCursoSeleccionarAño.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lb_AltaCursoSeleccionarAño.Location = new Point(12, 26);
            lb_AltaCursoSeleccionarAño.Name = "lb_AltaCursoSeleccionarAño";
            lb_AltaCursoSeleccionarAño.Size = new Size(291, 19);
            lb_AltaCursoSeleccionarAño.TabIndex = 0;
            lb_AltaCursoSeleccionarAño.Text = "Seleccione el año del curso que desea agregar:";
            // 
            // rdb_RegisCurso1Año
            // 
            rdb_RegisCurso1Año.AutoSize = true;
            rdb_RegisCurso1Año.Location = new Point(45, 66);
            rdb_RegisCurso1Año.Name = "rdb_RegisCurso1Año";
            rdb_RegisCurso1Año.Size = new Size(66, 19);
            rdb_RegisCurso1Año.TabIndex = 1;
            rdb_RegisCurso1Año.TabStop = true;
            rdb_RegisCurso1Año.Text = "1er Año";
            rdb_RegisCurso1Año.UseVisualStyleBackColor = true;
            rdb_RegisCurso1Año.CheckedChanged += rdb_RegisCurso1Año_CheckedChanged;
            // 
            // rdb_RegisCurso2Año
            // 
            rdb_RegisCurso2Año.AutoSize = true;
            rdb_RegisCurso2Año.Location = new Point(199, 66);
            rdb_RegisCurso2Año.Name = "rdb_RegisCurso2Año";
            rdb_RegisCurso2Año.Size = new Size(70, 19);
            rdb_RegisCurso2Año.TabIndex = 2;
            rdb_RegisCurso2Año.TabStop = true;
            rdb_RegisCurso2Año.Text = "2do Año";
            rdb_RegisCurso2Año.UseVisualStyleBackColor = true;
            rdb_RegisCurso2Año.CheckedChanged += rdb_RegisCurso2Año_CheckedChanged;
            // 
            // rdb_RegisCurso3Año
            // 
            rdb_RegisCurso3Año.AutoSize = true;
            rdb_RegisCurso3Año.Location = new Point(360, 66);
            rdb_RegisCurso3Año.Name = "rdb_RegisCurso3Año";
            rdb_RegisCurso3Año.Size = new Size(66, 19);
            rdb_RegisCurso3Año.TabIndex = 3;
            rdb_RegisCurso3Año.TabStop = true;
            rdb_RegisCurso3Año.Text = "3er Año";
            rdb_RegisCurso3Año.UseVisualStyleBackColor = true;
            rdb_RegisCurso3Año.CheckedChanged += rdb_RegisCurso3Año_CheckedChanged;
            // 
            // rdb_RegisCurso4Año
            // 
            rdb_RegisCurso4Año.AutoSize = true;
            rdb_RegisCurso4Año.Location = new Point(513, 66);
            rdb_RegisCurso4Año.Name = "rdb_RegisCurso4Año";
            rdb_RegisCurso4Año.Size = new Size(67, 19);
            rdb_RegisCurso4Año.TabIndex = 4;
            rdb_RegisCurso4Año.TabStop = true;
            rdb_RegisCurso4Año.Text = "4to Año";
            rdb_RegisCurso4Año.UseVisualStyleBackColor = true;
            rdb_RegisCurso4Año.CheckedChanged += rdb_RegisCurso4Año_CheckedChanged;
            // 
            // rdb_RegisCurso5Año
            // 
            rdb_RegisCurso5Año.AutoSize = true;
            rdb_RegisCurso5Año.Location = new Point(659, 66);
            rdb_RegisCurso5Año.Name = "rdb_RegisCurso5Año";
            rdb_RegisCurso5Año.Size = new Size(67, 19);
            rdb_RegisCurso5Año.TabIndex = 5;
            rdb_RegisCurso5Año.TabStop = true;
            rdb_RegisCurso5Año.Text = "5to Año";
            rdb_RegisCurso5Año.UseVisualStyleBackColor = true;
            rdb_RegisCurso5Año.CheckedChanged += rdb_RegisCurso5Año_CheckedChanged;
            // 
            // rch_AltaCursoListaUso
            // 
            rch_AltaCursoListaUso.Location = new Point(478, 195);
            rch_AltaCursoListaUso.Name = "rch_AltaCursoListaUso";
            rch_AltaCursoListaUso.Size = new Size(294, 222);
            rch_AltaCursoListaUso.TabIndex = 6;
            rch_AltaCursoListaUso.Text = "";
            // 
            // lb_AltaCursoAño
            // 
            lb_AltaCursoAño.AutoSize = true;
            lb_AltaCursoAño.Location = new Point(45, 112);
            lb_AltaCursoAño.Name = "lb_AltaCursoAño";
            lb_AltaCursoAño.Size = new Size(38, 15);
            lb_AltaCursoAño.TabIndex = 7;
            lb_AltaCursoAño.Text = "label1";
            // 
            // lb_AltaCursoEnUso
            // 
            lb_AltaCursoEnUso.AutoSize = true;
            lb_AltaCursoEnUso.Location = new Point(478, 177);
            lb_AltaCursoEnUso.Name = "lb_AltaCursoEnUso";
            lb_AltaCursoEnUso.Size = new Size(84, 15);
            lb_AltaCursoEnUso.TabIndex = 8;
            lb_AltaCursoEnUso.Text = "Cursos en uso:";
            // 
            // cmb_AltaCursoDisponibles
            // 
            cmb_AltaCursoDisponibles.FormattingEnabled = true;
            cmb_AltaCursoDisponibles.Location = new Point(45, 223);
            cmb_AltaCursoDisponibles.Name = "cmb_AltaCursoDisponibles";
            cmb_AltaCursoDisponibles.Size = new Size(121, 23);
            cmb_AltaCursoDisponibles.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 195);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 10;
            label1.Text = "label1";
            // 
            // FrmAltaCurso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(cmb_AltaCursoDisponibles);
            Controls.Add(lb_AltaCursoEnUso);
            Controls.Add(lb_AltaCursoAño);
            Controls.Add(rch_AltaCursoListaUso);
            Controls.Add(rdb_RegisCurso5Año);
            Controls.Add(rdb_RegisCurso4Año);
            Controls.Add(rdb_RegisCurso3Año);
            Controls.Add(rdb_RegisCurso2Año);
            Controls.Add(rdb_RegisCurso1Año);
            Controls.Add(lb_AltaCursoSeleccionarAño);
            Name = "FrmAltaCurso";
            Text = "Alta curso";
            Load += FrmAltaCurso_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
    }
}