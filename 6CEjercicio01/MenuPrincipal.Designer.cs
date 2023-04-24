namespace _6CEjercicio01
{
    partial class MenuPrincipal
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
            this.lb_MenuPrincipal = new System.Windows.Forms.Label();
            this.lb_Presentacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_MenuPrincipal
            // 
            this.lb_MenuPrincipal.AutoSize = true;
            this.lb_MenuPrincipal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_MenuPrincipal.Location = new System.Drawing.Point(57, 65);
            this.lb_MenuPrincipal.Name = "lb_MenuPrincipal";
            this.lb_MenuPrincipal.Size = new System.Drawing.Size(60, 25);
            this.lb_MenuPrincipal.TabIndex = 0;
            this.lb_MenuPrincipal.Text = "Hola!";
            // 
            // lb_Presentacion
            // 
            this.lb_Presentacion.AutoSize = true;
            this.lb_Presentacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Presentacion.Location = new System.Drawing.Point(57, 132);
            this.lb_Presentacion.Name = "lb_Presentacion";
            this.lb_Presentacion.Size = new System.Drawing.Size(43, 17);
            this.lb_Presentacion.TabIndex = 1;
            this.lb_Presentacion.Text = "label1";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_Presentacion);
            this.Controls.Add(this.lb_MenuPrincipal);
            this.Name = "MenuPrincipal";
            this.Text = "Saludo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_MenuPrincipal;
        private Label lb_Presentacion;
    }
}