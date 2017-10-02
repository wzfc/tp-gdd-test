namespace WindowsFormsApp1
{
    partial class UserLogin
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
            this.Username = new System.Windows.Forms.TextBox();
            this.text_usuario = new System.Windows.Forms.Label();
            this.text_contrasenia = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.button_iniciar_sesion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(15, 299);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(250, 25);
            this.Username.TabIndex = 0;
            this.Username.TextChanged += new System.EventHandler(this.Username_TextChanged);
            // 
            // text_usuario
            // 
            this.text_usuario.AutoSize = true;
            this.text_usuario.Location = new System.Drawing.Point(15, 281);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(71, 15);
            this.text_usuario.TabIndex = 1;
            this.text_usuario.Text = "&Usuario:";
            // 
            // text_contrasenia
            // 
            this.text_contrasenia.AutoSize = true;
            this.text_contrasenia.Location = new System.Drawing.Point(15, 336);
            this.text_contrasenia.Name = "text_contrasenia";
            this.text_contrasenia.Size = new System.Drawing.Size(95, 15);
            this.text_contrasenia.TabIndex = 3;
            this.text_contrasenia.Text = "&Contraseña:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(15, 355);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(250, 25);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // logo
            // 
            this.logo.Image = global::WindowsFormsApp1.Properties.Resources.logo1;
            this.logo.Location = new System.Drawing.Point(15, 8);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(250, 250);
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            // 
            // button_iniciar_sesion
            // 
            this.button_iniciar_sesion.Location = new System.Drawing.Point(15, 404);
            this.button_iniciar_sesion.Name = "button_iniciar_sesion";
            this.button_iniciar_sesion.Size = new System.Drawing.Size(250, 37);
            this.button_iniciar_sesion.TabIndex = 6;
            this.button_iniciar_sesion.Text = "&Iniciar sesión";
            this.button_iniciar_sesion.UseVisualStyleBackColor = true;
            this.button_iniciar_sesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 487);
            this.Controls.Add(this.button_iniciar_sesion);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.text_contrasenia);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.Username);
            this.Name = "UserLogin";
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label text_usuario;
        private System.Windows.Forms.Label text_contrasenia;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button button_iniciar_sesion;
    }
}

