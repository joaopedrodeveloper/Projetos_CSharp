namespace ValidaCPF_GUI
{
    partial class mainPage
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.maskedCPF = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnValidar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSairCNPJ = new System.Windows.Forms.Button();
            this.btnLimparCNPJ = new System.Windows.Forms.Button();
            this.maskedCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnValidarCNPJ = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.maskedCPFGerado = new System.Windows.Forms.MaskedTextBox();
            this.btnGerarCPF = new System.Windows.Forms.Button();
            this.btnCopiarCPF = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCopiarCNPJ = new System.Windows.Forms.Button();
            this.btnGerarCNPJ = new System.Windows.Forms.Button();
            this.maskedCNPJGerado = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.maskedCPF);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnValidar);
            this.groupBox1.Location = new System.Drawing.Point(394, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPF";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(200, 146);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(109, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(84, 146);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(110, 23);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // maskedCPF
            // 
            this.maskedCPF.Location = new System.Drawing.Point(84, 79);
            this.maskedCPF.Mask = "000,000,000-00";
            this.maskedCPF.Name = "maskedCPF";
            this.maskedCPF.Size = new System.Drawing.Size(225, 20);
            this.maskedCPF.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite um CPF para validar:";
            // 
            // btnValidar
            // 
            this.btnValidar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnValidar.Location = new System.Drawing.Point(140, 117);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(114, 23);
            this.btnValidar.TabIndex = 0;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.btnSairCNPJ);
            this.groupBox2.Controls.Add(this.btnLimparCNPJ);
            this.groupBox2.Controls.Add(this.maskedCNPJ);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnValidarCNPJ);
            this.groupBox2.Location = new System.Drawing.Point(394, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 190);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CNPJ";
            // 
            // btnSairCNPJ
            // 
            this.btnSairCNPJ.Location = new System.Drawing.Point(200, 146);
            this.btnSairCNPJ.Name = "btnSairCNPJ";
            this.btnSairCNPJ.Size = new System.Drawing.Size(109, 23);
            this.btnSairCNPJ.TabIndex = 5;
            this.btnSairCNPJ.Text = "Sair";
            this.btnSairCNPJ.UseVisualStyleBackColor = true;
            this.btnSairCNPJ.Click += new System.EventHandler(this.btnSairCNPJ_Click);
            // 
            // btnLimparCNPJ
            // 
            this.btnLimparCNPJ.Location = new System.Drawing.Point(84, 146);
            this.btnLimparCNPJ.Name = "btnLimparCNPJ";
            this.btnLimparCNPJ.Size = new System.Drawing.Size(110, 23);
            this.btnLimparCNPJ.TabIndex = 4;
            this.btnLimparCNPJ.Text = "Limpar";
            this.btnLimparCNPJ.UseVisualStyleBackColor = true;
            this.btnLimparCNPJ.Click += new System.EventHandler(this.btnLimparCNPJ_Click);
            // 
            // maskedCNPJ
            // 
            this.maskedCNPJ.Location = new System.Drawing.Point(84, 79);
            this.maskedCNPJ.Mask = "00,000,000/0000-00";
            this.maskedCNPJ.Name = "maskedCNPJ";
            this.maskedCNPJ.Size = new System.Drawing.Size(225, 20);
            this.maskedCNPJ.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Digite um CNPJ para validar:";
            // 
            // btnValidarCNPJ
            // 
            this.btnValidarCNPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnValidarCNPJ.Location = new System.Drawing.Point(140, 117);
            this.btnValidarCNPJ.Name = "btnValidarCNPJ";
            this.btnValidarCNPJ.Size = new System.Drawing.Size(114, 23);
            this.btnValidarCNPJ.TabIndex = 0;
            this.btnValidarCNPJ.Text = "Validar";
            this.btnValidarCNPJ.UseVisualStyleBackColor = true;
            this.btnValidarCNPJ.Click += new System.EventHandler(this.btnValidarCNPJ_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.btnCopiarCPF);
            this.groupBox3.Controls.Add(this.maskedCPFGerado);
            this.groupBox3.Controls.Add(this.btnGerarCPF);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 190);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gerar CPF";
            // 
            // maskedCPFGerado
            // 
            this.maskedCPFGerado.Location = new System.Drawing.Point(76, 79);
            this.maskedCPFGerado.Mask = "000,000,000-00";
            this.maskedCPFGerado.Name = "maskedCPFGerado";
            this.maskedCPFGerado.Size = new System.Drawing.Size(225, 20);
            this.maskedCPFGerado.TabIndex = 3;
            // 
            // btnGerarCPF
            // 
            this.btnGerarCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarCPF.Location = new System.Drawing.Point(76, 117);
            this.btnGerarCPF.Name = "btnGerarCPF";
            this.btnGerarCPF.Size = new System.Drawing.Size(105, 31);
            this.btnGerarCPF.TabIndex = 0;
            this.btnGerarCPF.Text = "Gerar CPF";
            this.btnGerarCPF.UseVisualStyleBackColor = true;
            this.btnGerarCPF.Click += new System.EventHandler(this.btnGerarCPF_Click);
            // 
            // btnCopiarCPF
            // 
            this.btnCopiarCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopiarCPF.Location = new System.Drawing.Point(196, 117);
            this.btnCopiarCPF.Name = "btnCopiarCPF";
            this.btnCopiarCPF.Size = new System.Drawing.Size(105, 31);
            this.btnCopiarCPF.TabIndex = 4;
            this.btnCopiarCPF.Text = "Copiar CPF";
            this.btnCopiarCPF.UseVisualStyleBackColor = true;
            this.btnCopiarCPF.Click += new System.EventHandler(this.btnCopiarCPF_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.maskedCNPJGerado);
            this.groupBox4.Controls.Add(this.btnCopiarCNPJ);
            this.groupBox4.Controls.Add(this.btnGerarCNPJ);
            this.groupBox4.Location = new System.Drawing.Point(12, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(376, 190);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gerar CNPJ";
            // 
            // btnCopiarCNPJ
            // 
            this.btnCopiarCNPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCopiarCNPJ.Location = new System.Drawing.Point(196, 117);
            this.btnCopiarCNPJ.Name = "btnCopiarCNPJ";
            this.btnCopiarCNPJ.Size = new System.Drawing.Size(105, 31);
            this.btnCopiarCNPJ.TabIndex = 4;
            this.btnCopiarCNPJ.Text = "Copiar CNPJ";
            this.btnCopiarCNPJ.UseVisualStyleBackColor = true;
            this.btnCopiarCNPJ.Click += new System.EventHandler(this.btnCopiarCNPJ_Click);
            // 
            // btnGerarCNPJ
            // 
            this.btnGerarCNPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGerarCNPJ.Location = new System.Drawing.Point(76, 117);
            this.btnGerarCNPJ.Name = "btnGerarCNPJ";
            this.btnGerarCNPJ.Size = new System.Drawing.Size(105, 31);
            this.btnGerarCNPJ.TabIndex = 0;
            this.btnGerarCNPJ.Text = "Gerar CNPJ";
            this.btnGerarCNPJ.UseVisualStyleBackColor = true;
            this.btnGerarCNPJ.Click += new System.EventHandler(this.btnGerarCNPJ_Click);
            // 
            // maskedCNPJGerado
            // 
            this.maskedCNPJGerado.Location = new System.Drawing.Point(76, 79);
            this.maskedCNPJGerado.Mask = "00,000,000/0000-00";
            this.maskedCNPJGerado.Name = "maskedCNPJGerado";
            this.maskedCNPJGerado.Size = new System.Drawing.Size(225, 20);
            this.maskedCNPJGerado.TabIndex = 6;
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainPage";
            this.Text = "Gera CNPJ ou CPF";
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
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedCPF;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSairCNPJ;
        private System.Windows.Forms.Button btnLimparCNPJ;
        private System.Windows.Forms.MaskedTextBox maskedCNPJ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnValidarCNPJ;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedCPFGerado;
        private System.Windows.Forms.Button btnGerarCPF;
        private System.Windows.Forms.Button btnCopiarCPF;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox maskedCNPJGerado;
        private System.Windows.Forms.Button btnCopiarCNPJ;
        private System.Windows.Forms.Button btnGerarCNPJ;
    }
}

