namespace MainCorreo
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
            this.components = new System.ComponentModel.Container();
            this.lblIngresado = new System.Windows.Forms.Label();
            this.lblEnViaje = new System.Windows.Forms.Label();
            this.lblEntregado = new System.Windows.Forms.Label();
            this.lstIngresado = new System.Windows.Forms.ListBox();
            this.lstEnViaje = new System.Windows.Forms.ListBox();
            this.lstEntregado = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTrackingID = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.mskIdText = new System.Windows.Forms.MaskedTextBox();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.RichTextBox();
            this.menuMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menMostrar = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblIngresado
            // 
            this.lblIngresado.AutoSize = true;
            this.lblIngresado.Location = new System.Drawing.Point(12, 76);
            this.lblIngresado.Name = "lblIngresado";
            this.lblIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblIngresado.TabIndex = 1;
            this.lblIngresado.Text = "Ingresado";
            this.lblIngresado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEnViaje
            // 
            this.lblEnViaje.AutoSize = true;
            this.lblEnViaje.Location = new System.Drawing.Point(292, 76);
            this.lblEnViaje.Name = "lblEnViaje";
            this.lblEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEnViaje.TabIndex = 2;
            this.lblEnViaje.Text = "En Viaje";
            this.lblEnViaje.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEntregado
            // 
            this.lblEntregado.AutoSize = true;
            this.lblEntregado.Location = new System.Drawing.Point(569, 76);
            this.lblEntregado.Name = "lblEntregado";
            this.lblEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEntregado.TabIndex = 3;
            this.lblEntregado.Text = "Entregado";
            this.lblEntregado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lstIngresado
            // 
            this.lstIngresado.FormattingEnabled = true;
            this.lstIngresado.Location = new System.Drawing.Point(15, 97);
            this.lstIngresado.Name = "lstIngresado";
            this.lstIngresado.Size = new System.Drawing.Size(233, 199);
            this.lstIngresado.TabIndex = 4;
            // 
            // lstEnViaje
            // 
            this.lstEnViaje.FormattingEnabled = true;
            this.lstEnViaje.Location = new System.Drawing.Point(295, 97);
            this.lstEnViaje.Name = "lstEnViaje";
            this.lstEnViaje.Size = new System.Drawing.Size(233, 199);
            this.lstEnViaje.TabIndex = 5;
            // 
            // lstEntregado
            // 
            this.lstEntregado.ContextMenuStrip = this.menuMain;
            this.lstEntregado.FormattingEnabled = true;
            this.lstEntregado.Location = new System.Drawing.Point(572, 97);
            this.lstEntregado.Name = "lstEntregado";
            this.lstEntregado.Size = new System.Drawing.Size(233, 199);
            this.lstEntregado.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstIngresado);
            this.groupBox1.Controls.Add(this.lblEntregado);
            this.groupBox1.Controls.Add(this.lstEntregado);
            this.groupBox1.Controls.Add(this.lblIngresado);
            this.groupBox1.Controls.Add(this.lstEnViaje);
            this.groupBox1.Controls.Add(this.lblEnViaje);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 357);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EstadosPaquetes";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTrackingID);
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.lblDireccion);
            this.groupBox2.Controls.Add(this.mskIdText);
            this.groupBox2.Controls.Add(this.btnMostrarTodos);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Location = new System.Drawing.Point(518, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 136);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paquete";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblTrackingID
            // 
            this.lblTrackingID.AutoSize = true;
            this.lblTrackingID.Location = new System.Drawing.Point(16, 19);
            this.lblTrackingID.Name = "lblTrackingID";
            this.lblTrackingID.Size = new System.Drawing.Size(63, 13);
            this.lblTrackingID.TabIndex = 5;
            this.lblTrackingID.Text = "Tracking ID";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(19, 91);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(150, 20);
            this.txtDireccion.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(16, 75);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
            // 
            // mskIdText
            // 
            this.mskIdText.Location = new System.Drawing.Point(19, 35);
            this.mskIdText.Mask = "000-000-0000";
            this.mskIdText.Name = "mskIdText";
            this.mskIdText.Size = new System.Drawing.Size(150, 20);
            this.mskIdText.TabIndex = 2;
            this.mskIdText.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(189, 80);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(110, 40);
            this.btnMostrarTodos.TabIndex = 1;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(189, 19);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 44);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtMostrar.Location = new System.Drawing.Point(12, 375);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(500, 136);
            this.txtMostrar.TabIndex = 3;
            this.txtMostrar.Text = "";
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menMostrar});
            this.menuMain.Name = "contextMenuStrip1";
            this.menuMain.Size = new System.Drawing.Size(125, 26);
            // 
            // menMostrar
            // 
            this.menMostrar.Name = "menMostrar";
            this.menMostrar.Size = new System.Drawing.Size(152, 22);
            this.menMostrar.Text = "Mostrar...";
            this.menMostrar.Click += new System.EventHandler(this.menMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 535);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Correo por Geronimo.Bordone.2D";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblIngresado;
        private System.Windows.Forms.Label lblEnViaje;
        private System.Windows.Forms.Label lblEntregado;
        private System.Windows.Forms.ListBox lstIngresado;
        private System.Windows.Forms.ListBox lstEnViaje;
        private System.Windows.Forms.ListBox lstEntregado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox mskIdText;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RichTextBox txtMostrar;
        private System.Windows.Forms.Label lblTrackingID;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.ContextMenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menMostrar;
    }
}

