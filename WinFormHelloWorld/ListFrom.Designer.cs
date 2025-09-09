namespace WinFormHelloWorld
{
    partial class ListForm
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
            this.lbxList = new System.Windows.Forms.ListBox();
            this.btnSomar = new System.Windows.Forms.Button();
            this.lblList = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.tbxNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxRazao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPG = new System.Windows.Forms.Button();
            this.btnFibo = new System.Windows.Forms.Button();
            this.tbxQtdTermos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPrimo = new System.Windows.Forms.Button();
            this.btnFatorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxList
            // 
            this.lbxList.FormattingEnabled = true;
            this.lbxList.Location = new System.Drawing.Point(36, 206);
            this.lbxList.Name = "lbxList";
            this.lbxList.Size = new System.Drawing.Size(162, 173);
            this.lbxList.TabIndex = 0;
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(230, 17);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(96, 30);
            this.btnSomar.TabIndex = 1;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(39, 191);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(109, 13);
            this.lblList.TabIndex = 2;
            this.lblList.Text = "Listagem de Números";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(39, 27);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(170, 20);
            this.lblNum.TabIndex = 3;
            this.lblNum.Text = "Entre com um número:";
            // 
            // tbxNum
            // 
            this.tbxNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNum.Location = new System.Drawing.Point(42, 50);
            this.tbxNum.Name = "tbxNum";
            this.tbxNum.Size = new System.Drawing.Size(100, 26);
            this.tbxNum.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 30);
            this.button1.TabIndex = 5;
            this.button1.Text = "PA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxRazao
            // 
            this.tbxRazao.Location = new System.Drawing.Point(42, 104);
            this.tbxRazao.Name = "tbxRazao";
            this.tbxRazao.Size = new System.Drawing.Size(100, 20);
            this.tbxRazao.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Entre com a razão (r ou q):";
            // 
            // btnPG
            // 
            this.btnPG.Location = new System.Drawing.Point(230, 126);
            this.btnPG.Name = "btnPG";
            this.btnPG.Size = new System.Drawing.Size(96, 30);
            this.btnPG.TabIndex = 8;
            this.btnPG.Text = "PG";
            this.btnPG.UseVisualStyleBackColor = true;
            this.btnPG.Click += new System.EventHandler(this.btnPG_Click);
            // 
            // btnFibo
            // 
            this.btnFibo.Location = new System.Drawing.Point(230, 181);
            this.btnFibo.Name = "btnFibo";
            this.btnFibo.Size = new System.Drawing.Size(96, 30);
            this.btnFibo.TabIndex = 9;
            this.btnFibo.Text = "Fibonacci";
            this.btnFibo.UseVisualStyleBackColor = true;
            this.btnFibo.Click += new System.EventHandler(this.btnFibo_Click);
            // 
            // tbxQtdTermos
            // 
            this.tbxQtdTermos.Location = new System.Drawing.Point(42, 153);
            this.tbxQtdTermos.Name = "tbxQtdTermos";
            this.tbxQtdTermos.Size = new System.Drawing.Size(100, 20);
            this.tbxQtdTermos.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantidade de termos (PA ou PG):";
            // 
            // btnPrimo
            // 
            this.btnPrimo.Location = new System.Drawing.Point(230, 241);
            this.btnPrimo.Name = "btnPrimo";
            this.btnPrimo.Size = new System.Drawing.Size(96, 30);
            this.btnPrimo.TabIndex = 12;
            this.btnPrimo.Text = "Primos";
            this.btnPrimo.UseVisualStyleBackColor = true;
            this.btnPrimo.Click += new System.EventHandler(this.btnPrimo_Click);
            // 
            // btnFatorial
            // 
            this.btnFatorial.Location = new System.Drawing.Point(230, 298);
            this.btnFatorial.Name = "btnFatorial";
            this.btnFatorial.Size = new System.Drawing.Size(96, 30);
            this.btnFatorial.TabIndex = 13;
            this.btnFatorial.Text = "Fatorial";
            this.btnFatorial.UseVisualStyleBackColor = true;
            this.btnFatorial.Click += new System.EventHandler(this.btnFatorial_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 393);
            this.Controls.Add(this.btnFatorial);
            this.Controls.Add(this.btnPrimo);
            this.Controls.Add(this.tbxQtdTermos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFibo);
            this.Controls.Add(this.btnPG);
            this.Controls.Add(this.tbxRazao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbxNum);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.lbxList);
            this.Name = "ListForm";
            this.Text = "ListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxList;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox tbxNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxRazao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPG;
        private System.Windows.Forms.Button btnFibo;
        private System.Windows.Forms.TextBox tbxQtdTermos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrimo;
        private System.Windows.Forms.Button btnFatorial;
    }
}