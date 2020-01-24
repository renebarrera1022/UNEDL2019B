namespace AutoReserva
{
    partial class Autos
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

        //#region Código generado por el Diseñador de Windows Forms
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelFamiliar = new System.Windows.Forms.Label();
            this.ñ = new System.Windows.Forms.Label();
            this.pictureBox_Mazda = new System.Windows.Forms.PictureBox();
            this.pictureBox_Bugatti = new System.Windows.Forms.PictureBox();
            this.pictureBox_vmw = new System.Windows.Forms.PictureBox();
            this.pictureBox_RollsRoyce = new System.Windows.Forms.PictureBox();
            this.pictureBox_Kia = new System.Windows.Forms.PictureBox();
            this.pictureBox_Suburban = new System.Windows.Forms.PictureBox();
            this.bt_Baja_Suburban = new System.Windows.Forms.Button();
            this.bt_baja_Mazda = new System.Windows.Forms.Button();
            this.bt_baja_KIA = new System.Windows.Forms.Button();
            this.bt_baja_wmw = new System.Windows.Forms.Button();
            this.bt_baja_Rollroyce = new System.Windows.Forms.Button();
            this.bt_baja_Bugatti = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_Editar_todo = new System.Windows.Forms.Button();
            this.btGuardadTodo = new System.Windows.Forms.Button();
            this.txtBox_Suburban_Carac_FAM = new System.Windows.Forms.TextBox();
            this.txtBox_Mazda_Carac_FAM = new System.Windows.Forms.TextBox();
            this.txtBox_Kia_Carac_FAM = new System.Windows.Forms.TextBox();
            this.txtBox_Vmw_Carac_PREM = new System.Windows.Forms.TextBox();
            this.txtBox_RollRoyce_Carac_PREM = new System.Windows.Forms.TextBox();
            this.txtBox_Bugatti_Carac_PREM = new System.Windows.Forms.TextBox();
            this.btnRegresarInicio = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mazda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bugatti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vmw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RollsRoyce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Kia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Suburban)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.operationToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(217, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.inicioToolStripMenuItem.Text = "Inicio";
            this.inicioToolStripMenuItem.Click += new System.EventHandler(this.inicioToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // operationToolStripMenuItem
            // 
            this.operationToolStripMenuItem.Name = "operationToolStripMenuItem";
            this.operationToolStripMenuItem.Size = new System.Drawing.Size(72, 22);
            this.operationToolStripMenuItem.Text = "Operation";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // labelFamiliar
            // 
            this.labelFamiliar.AutoSize = true;
            this.labelFamiliar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFamiliar.Location = new System.Drawing.Point(17, 38);
            this.labelFamiliar.Name = "labelFamiliar";
            this.labelFamiliar.Size = new System.Drawing.Size(185, 40);
            this.labelFamiliar.TabIndex = 2;
            this.labelFamiliar.Text = "FAMILIAR";
            this.labelFamiliar.Click += new System.EventHandler(this.labelFamiliar_Click);
            // 
            // ñ
            // 
            this.ñ.AutoSize = true;
            this.ñ.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ñ.Location = new System.Drawing.Point(17, 313);
            this.ñ.Name = "ñ";
            this.ñ.Size = new System.Drawing.Size(184, 40);
            this.ñ.TabIndex = 3;
            this.ñ.Text = "PREMIUM";
            // 
            // pictureBox_Mazda
            // 
            this.pictureBox_Mazda.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Mazda.Image")));
            this.pictureBox_Mazda.Location = new System.Drawing.Point(267, 113);
            this.pictureBox_Mazda.Name = "pictureBox_Mazda";
            this.pictureBox_Mazda.Size = new System.Drawing.Size(287, 114);
            this.pictureBox_Mazda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Mazda.TabIndex = 4;
            this.pictureBox_Mazda.TabStop = false;
            this.pictureBox_Mazda.Click += new System.EventHandler(this.pictureBox_Mazda_Click);
            // 
            // pictureBox_Bugatti
            // 
            this.pictureBox_Bugatti.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Bugatti.Image")));
            this.pictureBox_Bugatti.Location = new System.Drawing.Point(548, 386);
            this.pictureBox_Bugatti.Name = "pictureBox_Bugatti";
            this.pictureBox_Bugatti.Size = new System.Drawing.Size(264, 114);
            this.pictureBox_Bugatti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Bugatti.TabIndex = 5;
            this.pictureBox_Bugatti.TabStop = false;
            // 
            // pictureBox_vmw
            // 
            this.pictureBox_vmw.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_vmw.Image")));
            this.pictureBox_vmw.Location = new System.Drawing.Point(23, 386);
            this.pictureBox_vmw.Name = "pictureBox_vmw";
            this.pictureBox_vmw.Size = new System.Drawing.Size(251, 114);
            this.pictureBox_vmw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_vmw.TabIndex = 1;
            this.pictureBox_vmw.TabStop = false;
            // 
            // pictureBox_RollsRoyce
            // 
            this.pictureBox_RollsRoyce.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_RollsRoyce.Image")));
            this.pictureBox_RollsRoyce.Location = new System.Drawing.Point(292, 386);
            this.pictureBox_RollsRoyce.Name = "pictureBox_RollsRoyce";
            this.pictureBox_RollsRoyce.Size = new System.Drawing.Size(239, 114);
            this.pictureBox_RollsRoyce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_RollsRoyce.TabIndex = 4;
            this.pictureBox_RollsRoyce.TabStop = false;
            // 
            // pictureBox_Kia
            // 
            this.pictureBox_Kia.Enabled = false;
            this.pictureBox_Kia.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Kia.Image")));
            this.pictureBox_Kia.Location = new System.Drawing.Point(560, 113);
            this.pictureBox_Kia.Name = "pictureBox_Kia";
            this.pictureBox_Kia.Size = new System.Drawing.Size(253, 114);
            this.pictureBox_Kia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Kia.TabIndex = 6;
            this.pictureBox_Kia.TabStop = false;
            // 
            // pictureBox_Suburban
            // 
            this.pictureBox_Suburban.ErrorImage = null;
            this.pictureBox_Suburban.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Suburban.Image")));
            this.pictureBox_Suburban.Location = new System.Drawing.Point(24, 113);
            this.pictureBox_Suburban.Name = "pictureBox_Suburban";
            this.pictureBox_Suburban.Size = new System.Drawing.Size(237, 114);
            this.pictureBox_Suburban.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Suburban.TabIndex = 1;
            this.pictureBox_Suburban.TabStop = false;
            // 
            // bt_Baja_Suburban
            // 
            this.bt_Baja_Suburban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Baja_Suburban.Location = new System.Drawing.Point(24, 81);
            this.bt_Baja_Suburban.Name = "bt_Baja_Suburban";
            this.bt_Baja_Suburban.Size = new System.Drawing.Size(103, 26);
            this.bt_Baja_Suburban.TabIndex = 7;
            this.bt_Baja_Suburban.Text = "BAJA";
            this.bt_Baja_Suburban.UseVisualStyleBackColor = true;
            this.bt_Baja_Suburban.Click += new System.EventHandler(this.bt_Baja_Suburban_Click);
            // 
            // bt_baja_Mazda
            // 
            this.bt_baja_Mazda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_baja_Mazda.Location = new System.Drawing.Point(267, 81);
            this.bt_baja_Mazda.Name = "bt_baja_Mazda";
            this.bt_baja_Mazda.Size = new System.Drawing.Size(103, 26);
            this.bt_baja_Mazda.TabIndex = 9;
            this.bt_baja_Mazda.Text = "BAJA";
            this.bt_baja_Mazda.UseVisualStyleBackColor = true;
            this.bt_baja_Mazda.Click += new System.EventHandler(this.bt_baja_Mazda_Click);
            // 
            // bt_baja_KIA
            // 
            this.bt_baja_KIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_baja_KIA.Location = new System.Drawing.Point(560, 81);
            this.bt_baja_KIA.Name = "bt_baja_KIA";
            this.bt_baja_KIA.Size = new System.Drawing.Size(103, 26);
            this.bt_baja_KIA.TabIndex = 11;
            this.bt_baja_KIA.Text = "BAJA";
            this.bt_baja_KIA.UseVisualStyleBackColor = true;
            this.bt_baja_KIA.Click += new System.EventHandler(this.bt_baja_KIA_Click);
            // 
            // bt_baja_wmw
            // 
            this.bt_baja_wmw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_baja_wmw.Location = new System.Drawing.Point(23, 356);
            this.bt_baja_wmw.Name = "bt_baja_wmw";
            this.bt_baja_wmw.Size = new System.Drawing.Size(103, 26);
            this.bt_baja_wmw.TabIndex = 13;
            this.bt_baja_wmw.Text = "BAJA";
            this.bt_baja_wmw.UseVisualStyleBackColor = true;
            this.bt_baja_wmw.Click += new System.EventHandler(this.bt_baja_wmw_Click);
            // 
            // bt_baja_Rollroyce
            // 
            this.bt_baja_Rollroyce.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_baja_Rollroyce.Location = new System.Drawing.Point(292, 356);
            this.bt_baja_Rollroyce.Name = "bt_baja_Rollroyce";
            this.bt_baja_Rollroyce.Size = new System.Drawing.Size(103, 26);
            this.bt_baja_Rollroyce.TabIndex = 15;
            this.bt_baja_Rollroyce.Text = "BAJA";
            this.bt_baja_Rollroyce.UseVisualStyleBackColor = true;
            this.bt_baja_Rollroyce.Click += new System.EventHandler(this.bt_baja_Rollroyce_Click);
            // 
            // bt_baja_Bugatti
            // 
            this.bt_baja_Bugatti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_baja_Bugatti.Location = new System.Drawing.Point(548, 356);
            this.bt_baja_Bugatti.Name = "bt_baja_Bugatti";
            this.bt_baja_Bugatti.Size = new System.Drawing.Size(103, 26);
            this.bt_baja_Bugatti.TabIndex = 17;
            this.bt_baja_Bugatti.Text = "BAJA";
            this.bt_baja_Bugatti.UseVisualStyleBackColor = true;
            this.bt_baja_Bugatti.Click += new System.EventHandler(this.bt_baja_Bugatti_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 39);
            this.label2.TabIndex = 24;
            this.label2.Text = "• Motor  Tracción delantero integral\r\n• 6 velocidades con modo manual\r\n• Frenos (" +
    "Del. - Tras.)discos ventilados";
            // 
            // bt_Editar_todo
            // 
            this.bt_Editar_todo.Location = new System.Drawing.Point(657, 29);
            this.bt_Editar_todo.Name = "bt_Editar_todo";
            this.bt_Editar_todo.Size = new System.Drawing.Size(155, 29);
            this.bt_Editar_todo.TabIndex = 27;
            this.bt_Editar_todo.Text = "EDITAR";
            this.bt_Editar_todo.UseVisualStyleBackColor = true;
            this.bt_Editar_todo.Click += new System.EventHandler(this.bt_Editar_todo_Click);
            // 
            // btGuardadTodo
            // 
            this.btGuardadTodo.Location = new System.Drawing.Point(657, 611);
            this.btGuardadTodo.Name = "btGuardadTodo";
            this.btGuardadTodo.Size = new System.Drawing.Size(155, 29);
            this.btGuardadTodo.TabIndex = 28;
            this.btGuardadTodo.Text = "GUARDAR";
            this.btGuardadTodo.UseVisualStyleBackColor = true;
            this.btGuardadTodo.Click += new System.EventHandler(this.btGuardadTodo_Click);
            // 
            // txtBox_Suburban_Carac_FAM
            // 
            this.txtBox_Suburban_Carac_FAM.Enabled = false;
            this.txtBox_Suburban_Carac_FAM.Location = new System.Drawing.Point(23, 227);
            this.txtBox_Suburban_Carac_FAM.Multiline = true;
            this.txtBox_Suburban_Carac_FAM.Name = "txtBox_Suburban_Carac_FAM";
            this.txtBox_Suburban_Carac_FAM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Suburban_Carac_FAM.Size = new System.Drawing.Size(240, 71);
            this.txtBox_Suburban_Carac_FAM.TabIndex = 29;
            this.txtBox_Suburban_Carac_FAM.Text = "SUBURBAN\r\n• Motor  Tracción delantero integral\r\n• 6 velocidades con modo manual\r\n" +
    "• Frenos (Del. - Tras.)discos ventilados\r\n• Disponible";
            this.txtBox_Suburban_Carac_FAM.TextChanged += new System.EventHandler(this.txtBox_Suburban_TextChanged);
            // 
            // txtBox_Mazda_Carac_FAM
            // 
            this.txtBox_Mazda_Carac_FAM.Enabled = false;
            this.txtBox_Mazda_Carac_FAM.Location = new System.Drawing.Point(267, 227);
            this.txtBox_Mazda_Carac_FAM.Multiline = true;
            this.txtBox_Mazda_Carac_FAM.Name = "txtBox_Mazda_Carac_FAM";
            this.txtBox_Mazda_Carac_FAM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Mazda_Carac_FAM.Size = new System.Drawing.Size(288, 71);
            this.txtBox_Mazda_Carac_FAM.TabIndex = 31;
            this.txtBox_Mazda_Carac_FAM.Text = "MAZDA\r\n• Cierre de puertas con comando a distancia\r\n• Computadora de a bordo\tsi\r\n" +
    "• Encendido del motor con botón\r\n• Disponible";
            this.txtBox_Mazda_Carac_FAM.TextChanged += new System.EventHandler(this.txtBox_Mazda_Carac_FAM_TextChanged);
            // 
            // txtBox_Kia_Carac_FAM
            // 
            this.txtBox_Kia_Carac_FAM.Enabled = false;
            this.txtBox_Kia_Carac_FAM.Location = new System.Drawing.Point(560, 227);
            this.txtBox_Kia_Carac_FAM.Multiline = true;
            this.txtBox_Kia_Carac_FAM.Name = "txtBox_Kia_Carac_FAM";
            this.txtBox_Kia_Carac_FAM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Kia_Carac_FAM.Size = new System.Drawing.Size(255, 71);
            this.txtBox_Kia_Carac_FAM.TabIndex = 32;
            this.txtBox_Kia_Carac_FAM.Text = "KIA\r\n• Cilindros 4 en línea\r\n• Válvulas 16\r\n• Alimentación inyección directa turb" +
    "o\r\n• Disponible";
            this.txtBox_Kia_Carac_FAM.TextChanged += new System.EventHandler(this.txtBox_Kia_Carac_FAM_TextChanged);
            // 
            // txtBox_Vmw_Carac_PREM
            // 
            this.txtBox_Vmw_Carac_PREM.Enabled = false;
            this.txtBox_Vmw_Carac_PREM.Location = new System.Drawing.Point(23, 500);
            this.txtBox_Vmw_Carac_PREM.Multiline = true;
            this.txtBox_Vmw_Carac_PREM.Name = "txtBox_Vmw_Carac_PREM";
            this.txtBox_Vmw_Carac_PREM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Vmw_Carac_PREM.Size = new System.Drawing.Size(252, 98);
            this.txtBox_Vmw_Carac_PREM.TabIndex = 33;
            this.txtBox_Vmw_Carac_PREM.Text = "VMW\r\n• Cámara de visión trasera\r\n• Conectividad Android Auto y Apple Car Play\r\n• " +
    "Pantalla táctil a color de 7 pulgadas\r\n• Disponible";
            this.txtBox_Vmw_Carac_PREM.TextChanged += new System.EventHandler(this.txtBox_Vmw_Carac_PREM_TextChanged);
            // 
            // txtBox_RollRoyce_Carac_PREM
            // 
            this.txtBox_RollRoyce_Carac_PREM.Enabled = false;
            this.txtBox_RollRoyce_Carac_PREM.Location = new System.Drawing.Point(292, 500);
            this.txtBox_RollRoyce_Carac_PREM.Multiline = true;
            this.txtBox_RollRoyce_Carac_PREM.Name = "txtBox_RollRoyce_Carac_PREM";
            this.txtBox_RollRoyce_Carac_PREM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_RollRoyce_Carac_PREM.Size = new System.Drawing.Size(240, 98);
            this.txtBox_RollRoyce_Carac_PREM.TabIndex = 34;
            this.txtBox_RollRoyce_Carac_PREM.Text = "ROLL ROYCE\r\n• Espejo retrovisor antideslumbrante con brújula\r\n• 6 bolsas de aire " +
    "frontales laterales y tipo cortina \r\n• Asistente de frenado de emergencia\r\n• Dis" +
    "ponible";
            this.txtBox_RollRoyce_Carac_PREM.TextChanged += new System.EventHandler(this.txtBox_RollRoyce_Carac_PREM_TextChanged);
            // 
            // txtBox_Bugatti_Carac_PREM
            // 
            this.txtBox_Bugatti_Carac_PREM.Enabled = false;
            this.txtBox_Bugatti_Carac_PREM.Location = new System.Drawing.Point(548, 500);
            this.txtBox_Bugatti_Carac_PREM.Multiline = true;
            this.txtBox_Bugatti_Carac_PREM.Name = "txtBox_Bugatti_Carac_PREM";
            this.txtBox_Bugatti_Carac_PREM.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBox_Bugatti_Carac_PREM.Size = new System.Drawing.Size(265, 98);
            this.txtBox_Bugatti_Carac_PREM.TabIndex = 35;
            this.txtBox_Bugatti_Carac_PREM.Text = "BUGATTI\r\n• Cierre de seguros automático sensible a la velocidad\r\n• Frenos de disc" +
    "o en las 4 ruedas\r\n• Sensores de estacionamiento traseros\r\n• Disponible";
            this.txtBox_Bugatti_Carac_PREM.TextChanged += new System.EventHandler(this.txtBox_Bugatti_Carac_PREM_TextChanged);
            // 
            // btnRegresarInicio
            // 
            this.btnRegresarInicio.Location = new System.Drawing.Point(23, 611);
            this.btnRegresarInicio.Name = "btnRegresarInicio";
            this.btnRegresarInicio.Size = new System.Drawing.Size(155, 29);
            this.btnRegresarInicio.TabIndex = 36;
            this.btnRegresarInicio.Text = "REGRESAR";
            this.btnRegresarInicio.UseVisualStyleBackColor = true;
            this.btnRegresarInicio.Click += new System.EventHandler(this.btnRegresarInicio_Click);
            // 
            // Autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(834, 487);
            this.Controls.Add(this.btnRegresarInicio);
            this.Controls.Add(this.txtBox_Bugatti_Carac_PREM);
            this.Controls.Add(this.txtBox_RollRoyce_Carac_PREM);
            this.Controls.Add(this.txtBox_Vmw_Carac_PREM);
            this.Controls.Add(this.txtBox_Kia_Carac_FAM);
            this.Controls.Add(this.txtBox_Mazda_Carac_FAM);
            this.Controls.Add(this.txtBox_Suburban_Carac_FAM);
            this.Controls.Add(this.btGuardadTodo);
            this.Controls.Add(this.bt_Editar_todo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_baja_Bugatti);
            this.Controls.Add(this.bt_baja_Rollroyce);
            this.Controls.Add(this.bt_baja_wmw);
            this.Controls.Add(this.bt_baja_KIA);
            this.Controls.Add(this.bt_baja_Mazda);
            this.Controls.Add(this.bt_Baja_Suburban);
            this.Controls.Add(this.pictureBox_Kia);
            this.Controls.Add(this.pictureBox_Bugatti);
            this.Controls.Add(this.pictureBox_RollsRoyce);
            this.Controls.Add(this.pictureBox_Mazda);
            this.Controls.Add(this.ñ);
            this.Controls.Add(this.labelFamiliar);
            this.Controls.Add(this.pictureBox_vmw);
            this.Controls.Add(this.pictureBox_Suburban);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(30, 30);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Autos";
            this.Text = "Autos";
            this.Load += new System.EventHandler(this.Autos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mazda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Bugatti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_vmw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RollsRoyce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Kia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Suburban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.Label labelFamiliar;
        private System.Windows.Forms.Label ñ;
        private System.Windows.Forms.PictureBox pictureBox_Mazda;
        private System.Windows.Forms.PictureBox pictureBox_Bugatti;
        private System.Windows.Forms.PictureBox pictureBox_vmw;
        private System.Windows.Forms.PictureBox pictureBox_RollsRoyce;
        private System.Windows.Forms.PictureBox pictureBox_Kia;
        private System.Windows.Forms.PictureBox pictureBox_Suburban;
        private System.Windows.Forms.Button bt_Baja_Suburban;
        private System.Windows.Forms.Button bt_baja_Mazda;
        private System.Windows.Forms.Button bt_baja_KIA;
        private System.Windows.Forms.Button bt_baja_wmw;
        private System.Windows.Forms.Button bt_baja_Rollroyce;
        private System.Windows.Forms.Button bt_baja_Bugatti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_Editar_todo;
        private System.Windows.Forms.Button btGuardadTodo;
        private System.Windows.Forms.TextBox txtBox_Suburban_Carac_FAM;
        private System.Windows.Forms.TextBox txtBox_Mazda_Carac_FAM;
        private System.Windows.Forms.TextBox txtBox_Kia_Carac_FAM;
        private System.Windows.Forms.TextBox txtBox_Vmw_Carac_PREM;
        private System.Windows.Forms.TextBox txtBox_RollRoyce_Carac_PREM;
        private System.Windows.Forms.TextBox txtBox_Bugatti_Carac_PREM;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.Button btnRegresarInicio;
    }

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>}
}
