namespace checkPecas
{
    partial class frmContolePecasProduzidas
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.mtxtData = new System.Windows.Forms.MaskedTextBox();
            this.cbPecas = new System.Windows.Forms.ComboBox();
            this.txtAprovadas = new System.Windows.Forms.TextBox();
            this.txtReprovadas = new System.Windows.Forms.TextBox();
            this.txtProduzidas = new System.Windows.Forms.TextBox();
            this.txtPrejuizo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dbCheckPecasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPecasBindingSource = new System.Windows.Forms.BindingSource(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbCheckPecasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPecasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(178, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(163, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Peças";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(54, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peças Aprovadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(41, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Peças Reprovadas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(49, 307);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Peças Produzidas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(50, 372);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Prejuízo Estimado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(163, 437);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "E-mail";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(400, 492);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(212, 47);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // mtxtData
            // 
            this.mtxtData.Location = new System.Drawing.Point(244, 43);
            this.mtxtData.Mask = "00/00/0000";
            this.mtxtData.Name = "mtxtData";
            this.mtxtData.Size = new System.Drawing.Size(133, 32);
            this.mtxtData.TabIndex = 1;
            this.mtxtData.ValidatingType = typeof(System.DateTime);

            // 
            // cbPecas
            // 
            this.cbPecas.DataSource = this.tblPecasBindingSource;
            this.cbPecas.DisplayMember = "nomePeca";
            this.cbPecas.FormattingEnabled = true;
            this.cbPecas.Location = new System.Drawing.Point(244, 108);
            this.cbPecas.Name = "cbPecas";
            this.cbPecas.Size = new System.Drawing.Size(368, 35);
            this.cbPecas.TabIndex = 9;
            // 
            // txtAprovadas
            // 
            this.txtAprovadas.Location = new System.Drawing.Point(244, 173);
            this.txtAprovadas.Name = "txtAprovadas";
            this.txtAprovadas.Size = new System.Drawing.Size(100, 32);
            this.txtAprovadas.TabIndex = 10;
            // 
            // txtReprovadas
            // 
            this.txtReprovadas.Location = new System.Drawing.Point(244, 238);
            this.txtReprovadas.Name = "txtReprovadas";
            this.txtReprovadas.Size = new System.Drawing.Size(100, 32);
            this.txtReprovadas.TabIndex = 11;
            // 
            // txtProduzidas
            // 
            this.txtProduzidas.Location = new System.Drawing.Point(244, 303);
            this.txtProduzidas.Name = "txtProduzidas";
            this.txtProduzidas.Size = new System.Drawing.Size(100, 32);
            this.txtProduzidas.TabIndex = 12;
            // 
            // txtPrejuizo
            // 
            this.txtPrejuizo.Location = new System.Drawing.Point(244, 368);
            this.txtPrejuizo.Name = "txtPrejuizo";
            this.txtPrejuizo.Size = new System.Drawing.Size(178, 32);
            this.txtPrejuizo.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(244, 430);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(368, 32);
            this.txtEmail.TabIndex = 14;
            // 
            // pictureBox1
            // 

            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 90);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // dbCheckPecasDataSet
            // 

            // 
            // dbCheckPecasDataSetBindingSource
            // 

            this.dbCheckPecasDataSetBindingSource.Position = 0;
            // 
            // tblPecasBindingSource
            // 
            this.tblPecasBindingSource.DataMember = "tblPecas";
            this.tblPecasBindingSource.DataSource = this.dbCheckPecasDataSetBindingSource;
            // 
            // tblPecasTableAdapter
            // 

            // 
            // frmControlePecasProduzidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(633, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPrejuizo);
            this.Controls.Add(this.txtProduzidas);
            this.Controls.Add(this.txtReprovadas);
            this.Controls.Add(this.txtAprovadas);
            this.Controls.Add(this.cbPecas);
            this.Controls.Add(this.mtxtData);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmControlePecasProduzidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Peças Produzidas";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();


            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.MaskedTextBox mtxtData;
        private System.Windows.Forms.ComboBox cbPecas;
        private System.Windows.Forms.TextBox txtAprovadas;
        private System.Windows.Forms.TextBox txtReprovadas;
        private System.Windows.Forms.TextBox txtProduzidas;
        private System.Windows.Forms.TextBox txtPrejuizo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource dbCheckPecasDataSetBindingSource;

        private System.Windows.Forms.BindingSource tblPecasBindingSource;

    }
}