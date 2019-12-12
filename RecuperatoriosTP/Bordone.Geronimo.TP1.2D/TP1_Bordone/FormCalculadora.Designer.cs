namespace TP1_Bordone
{
    partial class FormCalculadora
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.boxOperador = new System.Windows.Forms.ComboBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnHacerBinario = new System.Windows.Forms.Button();
            this.btnHacerDecimal = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.txtNum1.Location = new System.Drawing.Point(28, 87);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(130, 50);
            this.txtNum1.TabIndex = 0;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.txtNum2.Location = new System.Drawing.Point(372, 87);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(130, 50);
            this.txtNum2.TabIndex = 2;
            // 
            // boxOperador
            // 
            this.boxOperador.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.boxOperador.FormattingEnabled = true;
            this.boxOperador.Items.AddRange(new object[] {
            "-",
            "*",
            "/",
            "+"});
            this.boxOperador.Location = new System.Drawing.Point(205, 87);
            this.boxOperador.Name = "boxOperador";
            this.boxOperador.Size = new System.Drawing.Size(121, 50);
            this.boxOperador.Sorted = true;
            this.boxOperador.TabIndex = 1;
            // 
            // btnOperar
            // 
            this.btnOperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnOperar.Location = new System.Drawing.Point(28, 210);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(130, 44);
            this.btnOperar.TabIndex = 3;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = true;
            this.btnOperar.Click += new System.EventHandler(this.btnOperar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnLimpiar.Location = new System.Drawing.Point(196, 210);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(130, 44);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCerrar.Location = new System.Drawing.Point(372, 210);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(130, 44);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnHacerBinario
            // 
            this.btnHacerBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnHacerBinario.Location = new System.Drawing.Point(28, 302);
            this.btnHacerBinario.Name = "btnHacerBinario";
            this.btnHacerBinario.Size = new System.Drawing.Size(230, 44);
            this.btnHacerBinario.TabIndex = 6;
            this.btnHacerBinario.Text = "Convertir a Binario";
            this.btnHacerBinario.UseVisualStyleBackColor = true;
            this.btnHacerBinario.Click += new System.EventHandler(this.btnHacerBinario_Click);
            // 
            // btnHacerDecimal
            // 
            this.btnHacerDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnHacerDecimal.Location = new System.Drawing.Point(272, 302);
            this.btnHacerDecimal.Name = "btnHacerDecimal";
            this.btnHacerDecimal.Size = new System.Drawing.Size(230, 44);
            this.btnHacerDecimal.TabIndex = 7;
            this.btnHacerDecimal.Text = "Convertir a Decimal";
            this.btnHacerDecimal.UseVisualStyleBackColor = true;
            this.btnHacerDecimal.Click += new System.EventHandler(this.btnHacerDecimal_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.txtResultado.Location = new System.Drawing.Point(248, 30);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(30, 31);
            this.txtResultado.TabIndex = 8;
            this.txtResultado.Text = "0";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 414);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnHacerDecimal);
            this.Controls.Add(this.btnHacerBinario);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.boxOperador);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Geronimo Bordone";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.ComboBox boxOperador;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnHacerBinario;
        private System.Windows.Forms.Button btnHacerDecimal;
        private System.Windows.Forms.Label txtResultado;
    }
}