namespace AutoReserva
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Usuario = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.textBox_Clave = new System.Windows.Forms.TextBox();
            this.btn__Login = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.BackColor = System.Drawing.Color.Transparent;
            this.Usuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usuario.Location = new System.Drawing.Point(357, 332);
            this.Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(96, 26);
            this.Usuario.TabIndex = 0;
            this.Usuario.Text = "Usuario";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.BackColor = System.Drawing.Color.Transparent;
            this.Clave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.Location = new System.Drawing.Point(340, 432);
            this.Clave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(136, 26);
            this.Clave.TabIndex = 1;
            this.Clave.Text = "Contraseña";
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Location = new System.Drawing.Point(260, 371);
            this.textBox_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(297, 20);
            this.textBox_Usuario.TabIndex = 2;
            // 
            // textBox_Clave
            // 
            this.textBox_Clave.Location = new System.Drawing.Point(260, 473);
            this.textBox_Clave.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Clave.Name = "textBox_Clave";
            this.textBox_Clave.PasswordChar = '*';
            this.textBox_Clave.Size = new System.Drawing.Size(297, 20);
            this.textBox_Clave.TabIndex = 3;
            this.textBox_Clave.TextChanged += new System.EventHandler(this.textBox_Clave_TextChanged);
            // 
            // btn__Login
            // 
            this.btn__Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn__Login.Location = new System.Drawing.Point(345, 527);
            this.btn__Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn__Login.Name = "btn__Login";
            this.btn__Login.Size = new System.Drawing.Size(127, 37);
            this.btn__Login.TabIndex = 4;
            this.btn__Login.Text = "Iniciar sesión";
            this.btn__Login.UseVisualStyleBackColor = true;
            this.btn__Login.Click += new System.EventHandler(this.btn__Login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(705, 669);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn__Login);
            this.Controls.Add(this.textBox_Clave);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.Usuario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(30, 30);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.TextBox textBox_Clave;
        private System.Windows.Forms.Button btn__Login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}