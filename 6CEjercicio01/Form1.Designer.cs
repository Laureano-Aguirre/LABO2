namespace _6CEjercicio01
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
            this.btn_saludar = new System.Windows.Forms.Button();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_apellido = new System.Windows.Forms.Label();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_apellido = new System.Windows.Forms.TextBox();
            this.cmb_Materias = new System.Windows.Forms.ComboBox();
            this.lb_MateriaFavorita = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_saludar
            // 
            this.btn_saludar.Location = new System.Drawing.Point(625, 382);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(144, 35);
            this.btn_saludar.TabIndex = 0;
            this.btn_saludar.Text = "Saludar";
            this.btn_saludar.UseVisualStyleBackColor = true;
            this.btn_saludar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nombre.Location = new System.Drawing.Point(47, 58);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(67, 20);
            this.lb_nombre.TabIndex = 1;
            this.lb_nombre.Text = "Nombre";
            // 
            // lb_apellido
            // 
            this.lb_apellido.AutoSize = true;
            this.lb_apellido.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_apellido.Location = new System.Drawing.Point(608, 58);
            this.lb_apellido.Name = "lb_apellido";
            this.lb_apellido.Size = new System.Drawing.Size(67, 20);
            this.lb_apellido.TabIndex = 2;
            this.lb_apellido.Text = "Apellido";
            // 
            // txb_nombre
            // 
            this.txb_nombre.Location = new System.Drawing.Point(47, 82);
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(155, 23);
            this.txb_nombre.TabIndex = 3;
            // 
            // txb_apellido
            // 
            this.txb_apellido.Location = new System.Drawing.Point(608, 82);
            this.txb_apellido.Name = "txb_apellido";
            this.txb_apellido.Size = new System.Drawing.Size(137, 23);
            this.txb_apellido.TabIndex = 4;
            // 
            // cmb_Materias
            // 
            this.cmb_Materias.FormattingEnabled = true;
            this.cmb_Materias.Location = new System.Drawing.Point(47, 194);
            this.cmb_Materias.Name = "cmb_Materias";
            this.cmb_Materias.Size = new System.Drawing.Size(698, 23);
            this.cmb_Materias.TabIndex = 5;
            // 
            // lb_MateriaFavorita
            // 
            this.lb_MateriaFavorita.AutoSize = true;
            this.lb_MateriaFavorita.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_MateriaFavorita.Location = new System.Drawing.Point(47, 171);
            this.lb_MateriaFavorita.Name = "lb_MateriaFavorita";
            this.lb_MateriaFavorita.Size = new System.Drawing.Size(122, 20);
            this.lb_MateriaFavorita.TabIndex = 6;
            this.lb_MateriaFavorita.Text = "Materia favorita";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_MateriaFavorita);
            this.Controls.Add(this.cmb_Materias);
            this.Controls.Add(this.txb_apellido);
            this.Controls.Add(this.txb_nombre);
            this.Controls.Add(this.lb_apellido);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.btn_saludar);
            this.Name = "Form1";
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_saludar;
        private Label lb_nombre;
        private Label lb_apellido;
        private TextBox txb_nombre;
        private TextBox txb_apellido;
        private ComboBox cmb_Materias;
        private Label lb_MateriaFavorita;
    }
}