namespace WindowsForms
{
    partial class Principal
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgenciasBancarias = new System.Windows.Forms.Button();
            this.btnPagamentos = new System.Windows.Forms.Button();
            this.btnPoupanca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(43, 33);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(301, 24);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Sistema de apoio gerêcial";
            // 
            // btnAgenciasBancarias
            // 
            this.btnAgenciasBancarias.BackColor = System.Drawing.Color.White;
            this.btnAgenciasBancarias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgenciasBancarias.FlatAppearance.BorderSize = 0;
            this.btnAgenciasBancarias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgenciasBancarias.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgenciasBancarias.Image = global::WindowsForms.Properties.Resources.account_balance_FILL0_wght400_GRAD0_opsz48;
            this.btnAgenciasBancarias.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgenciasBancarias.Location = new System.Drawing.Point(261, 90);
            this.btnAgenciasBancarias.Name = "btnAgenciasBancarias";
            this.btnAgenciasBancarias.Size = new System.Drawing.Size(212, 63);
            this.btnAgenciasBancarias.TabIndex = 5;
            this.btnAgenciasBancarias.Text = "Agências bancarias";
            this.btnAgenciasBancarias.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgenciasBancarias.UseVisualStyleBackColor = false;
            // 
            // btnPagamentos
            // 
            this.btnPagamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPagamentos.FlatAppearance.BorderSize = 0;
            this.btnPagamentos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPagamentos.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnPagamentos.Image = global::WindowsForms.Properties.Resources.payments_FILL0_wght400_GRAD0_opsz48;
            this.btnPagamentos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPagamentos.Location = new System.Drawing.Point(150, 90);
            this.btnPagamentos.Name = "btnPagamentos";
            this.btnPagamentos.Size = new System.Drawing.Size(89, 63);
            this.btnPagamentos.TabIndex = 4;
            this.btnPagamentos.Text = "Pagamentos";
            this.btnPagamentos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPagamentos.UseVisualStyleBackColor = true;
            // 
            // btnPoupanca
            // 
            this.btnPoupanca.BackColor = System.Drawing.Color.White;
            this.btnPoupanca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPoupanca.FlatAppearance.BorderSize = 0;
            this.btnPoupanca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPoupanca.Image = global::WindowsForms.Properties.Resources.savings_FILL0_wght400_GRAD0_opsz48;
            this.btnPoupanca.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPoupanca.Location = new System.Drawing.Point(25, 90);
            this.btnPoupanca.Name = "btnPoupanca";
            this.btnPoupanca.Size = new System.Drawing.Size(97, 63);
            this.btnPoupanca.TabIndex = 0;
            this.btnPoupanca.Text = "Poupança";
            this.btnPoupanca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPoupanca.UseVisualStyleBackColor = false;
            this.btnPoupanca.Click += new System.EventHandler(this.btnPoupanca_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsForms.Properties.Resources.undraw_digital_currency_qpak;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 218);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 310);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAgenciasBancarias);
            this.Controls.Add(this.btnPagamentos);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnPoupanca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoupanca;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnPagamentos;
        private System.Windows.Forms.Button btnAgenciasBancarias;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

