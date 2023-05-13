namespace WindowsForms
{
    partial class frmPoupanca
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRendimentoPoupanca = new System.Windows.Forms.Label();
            this.lblValorDepositado = new System.Windows.Forms.Label();
            this.btnCalcularPoupanca = new System.Windows.Forms.Button();
            this.txtValorDepositado = new System.Windows.Forms.TextBox();
            this.lblValorRendimento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calcule o rendimento de um determinado valor na poupança";
            // 
            // lblRendimentoPoupanca
            // 
            this.lblRendimentoPoupanca.AutoSize = true;
            this.lblRendimentoPoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRendimentoPoupanca.ForeColor = System.Drawing.Color.Lime;
            this.lblRendimentoPoupanca.Location = new System.Drawing.Point(220, 227);
            this.lblRendimentoPoupanca.Name = "lblRendimentoPoupanca";
            this.lblRendimentoPoupanca.Size = new System.Drawing.Size(185, 16);
            this.lblRendimentoPoupanca.TabIndex = 1;
            this.lblRendimentoPoupanca.Text = "Rendimento da poupança";
            this.lblRendimentoPoupanca.Visible = false;
            // 
            // lblValorDepositado
            // 
            this.lblValorDepositado.AutoSize = true;
            this.lblValorDepositado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDepositado.Location = new System.Drawing.Point(47, 85);
            this.lblValorDepositado.Name = "lblValorDepositado";
            this.lblValorDepositado.Size = new System.Drawing.Size(193, 16);
            this.lblValorDepositado.TabIndex = 3;
            this.lblValorDepositado.Text = "Informe o valor depositado";
            // 
            // btnCalcularPoupanca
            // 
            this.btnCalcularPoupanca.BackColor = System.Drawing.Color.White;
            this.btnCalcularPoupanca.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcularPoupanca.Image = global::WindowsForms.Properties.Resources.attach_money_FILL0_wght400_GRAD0_opsz48;
            this.btnCalcularPoupanca.Location = new System.Drawing.Point(23, 145);
            this.btnCalcularPoupanca.Name = "btnCalcularPoupanca";
            this.btnCalcularPoupanca.Size = new System.Drawing.Size(189, 62);
            this.btnCalcularPoupanca.TabIndex = 4;
            this.btnCalcularPoupanca.Text = "Calcular";
            this.btnCalcularPoupanca.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCalcularPoupanca.UseVisualStyleBackColor = false;
            this.btnCalcularPoupanca.Click += new System.EventHandler(this.btnCalcularPoupanca_Click);
            // 
            // txtValorDepositado
            // 
            this.txtValorDepositado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDepositado.Location = new System.Drawing.Point(50, 104);
            this.txtValorDepositado.Name = "txtValorDepositado";
            this.txtValorDepositado.Size = new System.Drawing.Size(132, 20);
            this.txtValorDepositado.TabIndex = 5;
            // 
            // lblValorRendimento
            // 
            this.lblValorRendimento.AutoSize = true;
            this.lblValorRendimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorRendimento.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValorRendimento.Location = new System.Drawing.Point(47, 227);
            this.lblValorRendimento.Name = "lblValorRendimento";
            this.lblValorRendimento.Size = new System.Drawing.Size(157, 16);
            this.lblValorRendimento.TabIndex = 6;
            this.lblValorRendimento.Text = "Valor do Rendimento:";
            // 
            // frmPoupanca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 313);
            this.Controls.Add(this.lblValorRendimento);
            this.Controls.Add(this.txtValorDepositado);
            this.Controls.Add(this.btnCalcularPoupanca);
            this.Controls.Add(this.lblValorDepositado);
            this.Controls.Add(this.lblRendimentoPoupanca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmPoupanca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPoupanca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRendimentoPoupanca;
        private System.Windows.Forms.Label lblValorDepositado;
        private System.Windows.Forms.Button btnCalcularPoupanca;
        private System.Windows.Forms.TextBox txtValorDepositado;
        private System.Windows.Forms.Label lblValorRendimento;
    }
}