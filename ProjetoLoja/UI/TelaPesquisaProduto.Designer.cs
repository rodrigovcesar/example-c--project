namespace ProjetoLoja.UI
{
    partial class TelaPesquisaProduto
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentQtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.currentPrice = new System.Windows.Forms.TextBox();
            this.btnChangedPrice = new System.Windows.Forms.Button();
            this.btnQtd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(92, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(228, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.LostFocus += new System.EventHandler(this.combobox_LostFocus);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade em Estoque";
            // 
            // currentQtd
            // 
            this.currentQtd.Location = new System.Drawing.Point(160, 79);
            this.currentQtd.Name = "currentQtd";
            this.currentQtd.ReadOnly = true;
            this.currentQtd.Size = new System.Drawing.Size(45, 20);
            this.currentQtd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Custo Unitário";
            // 
            // currentPrice
            // 
            this.currentPrice.Location = new System.Drawing.Point(115, 112);
            this.currentPrice.Name = "currentPrice";
            this.currentPrice.ReadOnly = true;
            this.currentPrice.Size = new System.Drawing.Size(90, 20);
            this.currentPrice.TabIndex = 5;
            // 
            // btnChangedPrice
            // 
            this.btnChangedPrice.Location = new System.Drawing.Point(39, 202);
            this.btnChangedPrice.Name = "btnChangedPrice";
            this.btnChangedPrice.Size = new System.Drawing.Size(115, 40);
            this.btnChangedPrice.TabIndex = 6;
            this.btnChangedPrice.Text = "Alterar Custo Unitário";
            this.btnChangedPrice.UseVisualStyleBackColor = true;
            this.btnChangedPrice.Click += new System.EventHandler(this.btnChangedPrice_Click);
            // 
            // btnQtd
            // 
            this.btnQtd.Location = new System.Drawing.Point(194, 202);
            this.btnQtd.Name = "btnQtd";
            this.btnQtd.Size = new System.Drawing.Size(126, 40);
            this.btnQtd.TabIndex = 7;
            this.btnQtd.Text = "Alocar / Retirar Produtos do Estoque";
            this.btnQtd.UseVisualStyleBackColor = true;
            this.btnQtd.Click += new System.EventHandler(this.btnQtd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(106, 202);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Salvar Alteração";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // TelaPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 265);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnQtd);
            this.Controls.Add(this.btnChangedPrice);
            this.Controls.Add(this.currentPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.currentQtd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "TelaPesquisaProduto";
            this.Text = "TelaPesquisaProduto";
            this.Load += new System.EventHandler(this.TelaPesquisaProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentQtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox currentPrice;
        private System.Windows.Forms.Button btnChangedPrice;
        private System.Windows.Forms.Button btnQtd;
        private System.Windows.Forms.Button btnSave;
    }
}