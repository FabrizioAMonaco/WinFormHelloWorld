namespace WinFormHelloWorld
{
    partial class FormHelloWorld
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
            this.lblSaudacao = new System.Windows.Forms.Label();
            this.btnSaudacao = new System.Windows.Forms.Button();
            this.tbxSaudacao = new System.Windows.Forms.TextBox();
            this.lblSaudacaoSaida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSaudacao
            // 
            this.lblSaudacao.AutoSize = true;
            this.lblSaudacao.Location = new System.Drawing.Point(43, 34);
            this.lblSaudacao.Name = "lblSaudacao";
            this.lblSaudacao.Size = new System.Drawing.Size(128, 13);
            this.lblSaudacao.TabIndex = 0;
            this.lblSaudacao.Text = "Bom dia, digite seu nome:";
            // 
            // btnSaudacao
            // 
            this.btnSaudacao.Location = new System.Drawing.Point(144, 88);
            this.btnSaudacao.Name = "btnSaudacao";
            this.btnSaudacao.Size = new System.Drawing.Size(75, 23);
            this.btnSaudacao.TabIndex = 1;
            this.btnSaudacao.Text = "Enviar";
            this.btnSaudacao.UseVisualStyleBackColor = true;
            this.btnSaudacao.Click += new System.EventHandler(this.btnSaudacao_Click);
            // 
            // tbxSaudacao
            // 
            this.tbxSaudacao.Location = new System.Drawing.Point(46, 50);
            this.tbxSaudacao.Name = "tbxSaudacao";
            this.tbxSaudacao.Size = new System.Drawing.Size(266, 20);
            this.tbxSaudacao.TabIndex = 2;
            // 
            // lblSaudacaoSaida
            // 
            this.lblSaudacaoSaida.AutoSize = true;
            this.lblSaudacaoSaida.Location = new System.Drawing.Point(53, 125);
            this.lblSaudacaoSaida.Name = "lblSaudacaoSaida";
            this.lblSaudacaoSaida.Size = new System.Drawing.Size(0, 13);
            this.lblSaudacaoSaida.TabIndex = 3;
            // 
            // FormHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 168);
            this.Controls.Add(this.lblSaudacaoSaida);
            this.Controls.Add(this.tbxSaudacao);
            this.Controls.Add(this.btnSaudacao);
            this.Controls.Add(this.lblSaudacao);
            this.Name = "FormHelloWorld";
            this.Text = "Formulário de Boas Vindas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSaudacao;
        private System.Windows.Forms.Button btnSaudacao;
        private System.Windows.Forms.TextBox tbxSaudacao;
        private System.Windows.Forms.Label lblSaudacaoSaida;
    }
}

