namespace ejemplo_1
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.ckbViolencia = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbManoLimpia = new System.Windows.Forms.RadioButton();
            this.rdbArmaBlanca = new System.Windows.Forms.RadioButton();
            this.rdbArmaDeFuego = new System.Windows.Forms.RadioButton();
            this.lblArma = new System.Windows.Forms.Label();
            this.cboArma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nmMuertes = new System.Windows.Forms.NumericUpDown();
            this.btnNombre = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMuertes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Futura-Heavy", 9.749998F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(87, 278);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Ver Perfil";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(136, 307);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(449, 131);
            this.lwElementos.TabIndex = 2;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.List;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(156, 12);
            this.txtNombre.MaxLength = 30;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(105, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Futura-Heavy", 9.749998F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(84, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 16);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Font = new System.Drawing.Font("Futura-Heavy", 9.749998F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNacimiento.Location = new System.Drawing.Point(29, 62);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(124, 16);
            this.lblNacimiento.TabIndex = 5;
            this.lblNacimiento.Text = "Fecha de Nacimiento";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpNacimiento.Location = new System.Drawing.Point(156, 56);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(152, 20);
            this.dtpNacimiento.TabIndex = 1;
            // 
            // ckbViolencia
            // 
            this.ckbViolencia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ckbViolencia.AutoSize = true;
            this.ckbViolencia.Font = new System.Drawing.Font("Futura-Heavy", 9.749998F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbViolencia.Location = new System.Drawing.Point(132, 102);
            this.ckbViolencia.Name = "ckbViolencia";
            this.ckbViolencia.Size = new System.Drawing.Size(145, 20);
            this.ckbViolencia.TabIndex = 2;
            this.ckbViolencia.Text = "Te gusta la violencia?";
            this.ckbViolencia.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.rdbManoLimpia);
            this.groupBox1.Controls.Add(this.rdbArmaBlanca);
            this.groupBox1.Controls.Add(this.rdbArmaDeFuego);
            this.groupBox1.Font = new System.Drawing.Font("Futura-Heavy", 9.749998F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 47);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estilo de defensa";
            // 
            // rdbManoLimpia
            // 
            this.rdbManoLimpia.AutoSize = true;
            this.rdbManoLimpia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbManoLimpia.Location = new System.Drawing.Point(411, 20);
            this.rdbManoLimpia.Name = "rdbManoLimpia";
            this.rdbManoLimpia.Size = new System.Drawing.Size(107, 20);
            this.rdbManoLimpia.TabIndex = 2;
            this.rdbManoLimpia.TabStop = true;
            this.rdbManoLimpia.Text = "MANO LIMPIA";
            this.rdbManoLimpia.UseVisualStyleBackColor = false;
            // 
            // rdbArmaBlanca
            // 
            this.rdbArmaBlanca.AutoSize = true;
            this.rdbArmaBlanca.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbArmaBlanca.Location = new System.Drawing.Point(275, 20);
            this.rdbArmaBlanca.Name = "rdbArmaBlanca";
            this.rdbArmaBlanca.Size = new System.Drawing.Size(113, 20);
            this.rdbArmaBlanca.TabIndex = 1;
            this.rdbArmaBlanca.TabStop = true;
            this.rdbArmaBlanca.Text = "ARMA BLANCA";
            this.rdbArmaBlanca.UseVisualStyleBackColor = false;
            // 
            // rdbArmaDeFuego
            // 
            this.rdbArmaDeFuego.AutoSize = true;
            this.rdbArmaDeFuego.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rdbArmaDeFuego.Location = new System.Drawing.Point(112, 20);
            this.rdbArmaDeFuego.Name = "rdbArmaDeFuego";
            this.rdbArmaDeFuego.Size = new System.Drawing.Size(124, 20);
            this.rdbArmaDeFuego.TabIndex = 0;
            this.rdbArmaDeFuego.TabStop = true;
            this.rdbArmaDeFuego.Text = "ARMA DE FUEGO";
            this.rdbArmaDeFuego.UseVisualStyleBackColor = false;
            // 
            // lblArma
            // 
            this.lblArma.AutoSize = true;
            this.lblArma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArma.Font = new System.Drawing.Font("Futura-Heavy", 9.749998F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArma.Location = new System.Drawing.Point(107, 184);
            this.lblArma.Name = "lblArma";
            this.lblArma.Size = new System.Drawing.Size(45, 18);
            this.lblArma.TabIndex = 9;
            this.lblArma.Text = "ARMA";
            this.lblArma.MouseLeave += new System.EventHandler(this.lblArma_MouseLeave);
            this.lblArma.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblArma_MouseMove);
            // 
            // cboArma
            // 
            this.cboArma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboArma.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboArma.Font = new System.Drawing.Font("Futura-Heavy", 9.749998F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboArma.FormattingEnabled = true;
            this.cboArma.Location = new System.Drawing.Point(156, 179);
            this.cboArma.Name = "cboArma";
            this.cboArma.Size = new System.Drawing.Size(73, 24);
            this.cboArma.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Futura-Heavy", 9.749998F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "MUERTES";
            // 
            // nmMuertes
            // 
            this.nmMuertes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmMuertes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nmMuertes.Font = new System.Drawing.Font("Futura-Heavy", 9.749998F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmMuertes.Location = new System.Drawing.Point(160, 216);
            this.nmMuertes.Name = "nmMuertes";
            this.nmMuertes.Size = new System.Drawing.Size(72, 24);
            this.nmMuertes.TabIndex = 5;
            // 
            // btnNombre
            // 
            this.btnNombre.Location = new System.Drawing.Point(267, 12);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.Size = new System.Drawing.Size(75, 23);
            this.btnNombre.TabIndex = 13;
            this.btnNombre.Text = "verificar";
            this.btnNombre.UseVisualStyleBackColor = true;
            this.btnNombre.Click += new System.EventHandler(this.btnNombre_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(350, 56);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(100, 66);
            this.textBox1.TabIndex = 14;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 460);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNombre);
            this.Controls.Add(this.nmMuertes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboArma);
            this.Controls.Add(this.lblArma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckbViolencia);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnAgregar);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(726, 499);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMuertes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.CheckBox ckbViolencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbManoLimpia;
        private System.Windows.Forms.RadioButton rdbArmaBlanca;
        private System.Windows.Forms.RadioButton rdbArmaDeFuego;
        private System.Windows.Forms.Label lblArma;
        private System.Windows.Forms.ComboBox cboArma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nmMuertes;
        private System.Windows.Forms.Button btnNombre;
        private System.Windows.Forms.TextBox textBox1;
    }
}

