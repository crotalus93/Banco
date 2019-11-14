namespace Banco
{
    partial class FormCadastroConta
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
            this.label2 = new System.Windows.Forms.Label();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.botaoCadastro = new System.Windows.Forms.Button();
            this.radioCC = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioCP = new System.Windows.Forms.RadioButton();
            this.radioCI = new System.Windows.Forms.RadioButton();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titular";
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(119, 12);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 3;
            // 
            // botaoCadastro
            // 
            this.botaoCadastro.Location = new System.Drawing.Point(123, 139);
            this.botaoCadastro.Name = "botaoCadastro";
            this.botaoCadastro.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastro.TabIndex = 4;
            this.botaoCadastro.Text = "Cadastrar";
            this.botaoCadastro.UseVisualStyleBackColor = true;
            this.botaoCadastro.Click += new System.EventHandler(this.botaoCadastro_Click);
            // 
            // radioCC
            // 
            this.radioCC.AutoSize = true;
            this.radioCC.Location = new System.Drawing.Point(119, 67);
            this.radioCC.Name = "radioCC";
            this.radioCC.Size = new System.Drawing.Size(96, 17);
            this.radioCC.TabIndex = 5;
            this.radioCC.TabStop = true;
            this.radioCC.Text = "Conta Corrente";
            this.radioCC.UseVisualStyleBackColor = true;
            this.radioCC.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Conta";
            // 
            // radioCP
            // 
            this.radioCP.AutoSize = true;
            this.radioCP.Location = new System.Drawing.Point(119, 91);
            this.radioCP.Name = "radioCP";
            this.radioCP.Size = new System.Drawing.Size(105, 17);
            this.radioCP.TabIndex = 7;
            this.radioCP.TabStop = true;
            this.radioCP.Text = "Conta Poupança";
            this.radioCP.UseVisualStyleBackColor = true;
            // 
            // radioCI
            // 
            this.radioCI.AutoSize = true;
            this.radioCI.Location = new System.Drawing.Point(119, 114);
            this.radioCI.Name = "radioCI";
            this.radioCI.Size = new System.Drawing.Size(116, 17);
            this.radioCI.TabIndex = 8;
            this.radioCI.TabStop = true;
            this.radioCI.Text = "Conta Investimento";
            this.radioCI.UseVisualStyleBackColor = true;
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(119, 38);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Número";
            // 
            // FormCadastroConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 174);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.radioCI);
            this.Controls.Add(this.radioCP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioCC);
            this.Controls.Add(this.botaoCadastro);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.label2);
            this.Name = "FormCadastroConta";
            this.Text = "FormCadastroConta";
            this.Load += new System.EventHandler(this.FormCadastroConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.Button botaoCadastro;
        private System.Windows.Forms.RadioButton radioCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioCP;
        private System.Windows.Forms.RadioButton radioCI;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.Label label1;
    }
}