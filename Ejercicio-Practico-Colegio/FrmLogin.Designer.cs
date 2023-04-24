namespace Ejercicio_Practico_Colegio
{
    partial class Login
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
            this.pb_Usuario = new System.Windows.Forms.PictureBox();
            this.txb_Usuario = new System.Windows.Forms.TextBox();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.lb_Usuario = new System.Windows.Forms.Label();
            this.lb_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Usuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_Usuario
            // 
            this.pb_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pb_Usuario.Image = global::Ejercicio_Practico_Colegio.Properties.Resources.imagen_usuario1;
            this.pb_Usuario.Location = new System.Drawing.Point(359, 130);
            this.pb_Usuario.Name = "pb_Usuario";
            this.pb_Usuario.Size = new System.Drawing.Size(80, 86);
            this.pb_Usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Usuario.TabIndex = 0;
            this.pb_Usuario.TabStop = false;
            // 
            // txb_Usuario
            // 
            this.txb_Usuario.Location = new System.Drawing.Point(336, 250);
            this.txb_Usuario.Name = "txb_Usuario";
            this.txb_Usuario.PlaceholderText = "Ingrese aqui";
            this.txb_Usuario.Size = new System.Drawing.Size(133, 23);
            this.txb_Usuario.TabIndex = 1;
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(336, 313);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.PasswordChar = '*';
            this.txb_Password.PlaceholderText = "Ingrese aqui";
            this.txb_Password.Size = new System.Drawing.Size(133, 23);
            this.txb_Password.TabIndex = 2;
            // 
            // lb_Usuario
            // 
            this.lb_Usuario.AutoSize = true;
            this.lb_Usuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Usuario.Location = new System.Drawing.Point(336, 232);
            this.lb_Usuario.Name = "lb_Usuario";
            this.lb_Usuario.Size = new System.Drawing.Size(49, 15);
            this.lb_Usuario.TabIndex = 3;
            this.lb_Usuario.Text = "Usuario";
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_Password.Location = new System.Drawing.Point(337, 295);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(69, 15);
            this.lb_Password.TabIndex = 4;
            this.lb_Password.Text = "Contraseña";
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(359, 363);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(80, 23);
            this.btn_Login.TabIndex = 5;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.lb_Usuario);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Usuario);
            this.Controls.Add(this.pb_Usuario);
            this.Name = "Login";
            this.Text = "Bienvenido!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Usuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pb_Usuario;
        private TextBox txb_Usuario;
        private TextBox txb_Password;
        private Label lb_Usuario;
        private Label lb_Password;
        private Button btn_Login;
    }
}