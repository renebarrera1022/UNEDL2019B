namespace Examen3ParcialTaller
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnOtro = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.Dirección = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dtNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtnDeposito = new System.Windows.Forms.RadioButton();
            this.rbtnRetiro = new System.Windows.Forms.RadioButton();
            this.rbtnConsulta = new System.Windows.Forms.RadioButton();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.dtEjecucion = new System.Windows.Forms.DateTimePicker();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEdicion = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNacimiento);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.Dirección);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(47, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(772, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Personales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de nacimiento:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnOtro);
            this.groupBox2.Controls.Add(this.rbtnMasculino);
            this.groupBox2.Controls.Add(this.rbtnFemenino);
            this.groupBox2.Location = new System.Drawing.Point(26, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnLimpiar);
            this.groupBox3.Controls.Add(this.btnEjecutar);
            this.groupBox3.Controls.Add(this.dtEjecucion);
            this.groupBox3.Controls.Add(this.txtSaldo);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCantidad);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(47, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(772, 256);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos bancarios";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbtnConsulta);
            this.groupBox4.Controls.Add(this.rbtnRetiro);
            this.groupBox4.Controls.Add(this.rbtnDeposito);
            this.groupBox4.Location = new System.Drawing.Point(26, 170);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(393, 70);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Operación";
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Enabled = false;
            this.rbtnFemenino.Location = new System.Drawing.Point(19, 35);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(105, 24);
            this.rbtnFemenino.TabIndex = 0;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Enabled = false;
            this.rbtnMasculino.Location = new System.Drawing.Point(152, 35);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(105, 24);
            this.rbtnMasculino.TabIndex = 1;
            this.rbtnMasculino.TabStop = true;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnOtro
            // 
            this.rbtnOtro.AutoSize = true;
            this.rbtnOtro.Enabled = false;
            this.rbtnOtro.Location = new System.Drawing.Point(286, 35);
            this.rbtnOtro.Name = "rbtnOtro";
            this.rbtnOtro.Size = new System.Drawing.Size(65, 24);
            this.rbtnOtro.TabIndex = 2;
            this.rbtnOtro.TabStop = true;
            this.rbtnOtro.Text = "Otro";
            this.rbtnOtro.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(98, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(306, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(98, 71);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(306, 26);
            this.txtApellido.TabIndex = 5;
            // 
            // Dirección
            // 
            this.Dirección.AutoSize = true;
            this.Dirección.Location = new System.Drawing.Point(424, 40);
            this.Dirección.Name = "Dirección";
            this.Dirección.Size = new System.Drawing.Size(79, 20);
            this.Dirección.TabIndex = 6;
            this.Dirección.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(509, 40);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(239, 189);
            this.txtDireccion.TabIndex = 7;
            // 
            // dtNacimiento
            // 
            this.dtNacimiento.Enabled = false;
            this.dtNacimiento.Location = new System.Drawing.Point(190, 110);
            this.dtNacimiento.Name = "dtNacimiento";
            this.dtNacimiento.Size = new System.Drawing.Size(214, 26);
            this.dtNacimiento.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Enabled = false;
            this.txtCantidad.Location = new System.Drawing.Point(98, 40);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(306, 26);
            this.txtCantidad.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Saldo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Fecha de ejecución:";
            // 
            // rbtnDeposito
            // 
            this.rbtnDeposito.AutoSize = true;
            this.rbtnDeposito.Enabled = false;
            this.rbtnDeposito.Location = new System.Drawing.Point(19, 25);
            this.rbtnDeposito.Name = "rbtnDeposito";
            this.rbtnDeposito.Size = new System.Drawing.Size(98, 24);
            this.rbtnDeposito.TabIndex = 3;
            this.rbtnDeposito.TabStop = true;
            this.rbtnDeposito.Text = "Deposito";
            this.rbtnDeposito.UseVisualStyleBackColor = true;
            // 
            // rbtnRetiro
            // 
            this.rbtnRetiro.AutoSize = true;
            this.rbtnRetiro.Enabled = false;
            this.rbtnRetiro.Location = new System.Drawing.Point(152, 25);
            this.rbtnRetiro.Name = "rbtnRetiro";
            this.rbtnRetiro.Size = new System.Drawing.Size(77, 24);
            this.rbtnRetiro.TabIndex = 4;
            this.rbtnRetiro.TabStop = true;
            this.rbtnRetiro.Text = "Retiro";
            this.rbtnRetiro.UseVisualStyleBackColor = true;
            // 
            // rbtnConsulta
            // 
            this.rbtnConsulta.AutoSize = true;
            this.rbtnConsulta.Enabled = false;
            this.rbtnConsulta.Location = new System.Drawing.Point(268, 25);
            this.rbtnConsulta.Name = "rbtnConsulta";
            this.rbtnConsulta.Size = new System.Drawing.Size(97, 24);
            this.rbtnConsulta.TabIndex = 5;
            this.rbtnConsulta.TabStop = true;
            this.rbtnConsulta.Text = "Consulta";
            this.rbtnConsulta.UseVisualStyleBackColor = true;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(98, 86);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(306, 26);
            this.txtSaldo.TabIndex = 12;
            // 
            // dtEjecucion
            // 
            this.dtEjecucion.Enabled = false;
            this.dtEjecucion.Location = new System.Drawing.Point(190, 130);
            this.dtEjecucion.Name = "dtEjecucion";
            this.dtEjecucion.Size = new System.Drawing.Size(214, 26);
            this.dtEjecucion.TabIndex = 9;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Enabled = false;
            this.btnEjecutar.Location = new System.Drawing.Point(509, 43);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(239, 46);
            this.btnEjecutar.TabIndex = 13;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Location = new System.Drawing.Point(509, 117);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(239, 46);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEdicion
            // 
            this.btnEdicion.Location = new System.Drawing.Point(851, 45);
            this.btnEdicion.Name = "btnEdicion";
            this.btnEdicion.Size = new System.Drawing.Size(239, 46);
            this.btnEdicion.TabIndex = 15;
            this.btnEdicion.Text = "Edición";
            this.btnEdicion.UseVisualStyleBackColor = true;
            this.btnEdicion.Click += new System.EventHandler(this.btnEdicion_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(851, 120);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(239, 46);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 589);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEdicion);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label Dirección;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnOtro;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtNacimiento;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.DateTimePicker dtEjecucion;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnConsulta;
        private System.Windows.Forms.RadioButton rbtnRetiro;
        private System.Windows.Forms.RadioButton rbtnDeposito;
        private System.Windows.Forms.Button btnEdicion;
        private System.Windows.Forms.Button btnCancelar;
    }
}

