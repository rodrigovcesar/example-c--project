namespace ProjetoLoja.UI
{
    partial class TelaCompra
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
            this.btnConfirmarCompra = new System.Windows.Forms.Button();
            this.btnAdicionarNoCarrinho = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodVendedorMask = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.spinQuantidade = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboProduto = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvCarrinho = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custo_Unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Custo_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEsvaziarCarrinho = new System.Windows.Forms.Button();
            this.txtPrecoTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemoverLinha = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantidade)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmarCompra
            // 
            this.btnConfirmarCompra.Location = new System.Drawing.Point(390, 486);
            this.btnConfirmarCompra.Name = "btnConfirmarCompra";
            this.btnConfirmarCompra.Size = new System.Drawing.Size(137, 31);
            this.btnConfirmarCompra.TabIndex = 0;
            this.btnConfirmarCompra.Text = "Confirmar Compra";
            this.btnConfirmarCompra.UseVisualStyleBackColor = true;
            this.btnConfirmarCompra.Click += new System.EventHandler(this.btnConfirmarCompra_Click);
            // 
            // btnAdicionarNoCarrinho
            // 
            this.btnAdicionarNoCarrinho.Location = new System.Drawing.Point(416, 31);
            this.btnAdicionarNoCarrinho.Name = "btnAdicionarNoCarrinho";
            this.btnAdicionarNoCarrinho.Size = new System.Drawing.Size(99, 46);
            this.btnAdicionarNoCarrinho.TabIndex = 1;
            this.btnAdicionarNoCarrinho.Text = "Adicionar no Carrinho";
            this.btnAdicionarNoCarrinho.UseVisualStyleBackColor = true;
            this.btnAdicionarNoCarrinho.Click += new System.EventHandler(this.btnAdicionarNoCarrinho_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF do Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cód. do Vendedor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(105, 54);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.ReadOnly = true;
            this.txtNomeVendedor.Size = new System.Drawing.Size(171, 20);
            this.txtNomeVendedor.TabIndex = 7;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(400, 62);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(164, 20);
            this.txtNomeCliente.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodVendedorMask);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNomeVendedor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 87);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendedor";
            // 
            // txtCodVendedorMask
            // 
            this.txtCodVendedorMask.Location = new System.Drawing.Point(105, 19);
            this.txtCodVendedorMask.Mask = "00000";
            this.txtCodVendedorMask.Name = "txtCodVendedorMask";
            this.txtCodVendedorMask.Size = new System.Drawing.Size(41, 20);
            this.txtCodVendedorMask.TabIndex = 12;
            this.txtCodVendedorMask.ValidatingType = typeof(int);
            this.txtCodVendedorMask.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCodVendedorMask_MaskInputRejected);
            this.txtCodVendedorMask.LostFocus += new System.EventHandler(this.txtCodVendedorMaskLostFocus);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCpfCliente);
            this.groupBox2.Location = new System.Drawing.Point(300, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 88);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cliente";
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(100, 19);
            this.txtCpfCliente.Mask = "000.000.000-00";
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCpfCliente.TabIndex = 0;
            this.txtCpfCliente.LostFocus += new System.EventHandler(this.txtCpfCliente_LostFocus);
            // 
            // spinQuantidade
            // 
            this.spinQuantidade.Location = new System.Drawing.Point(270, 52);
            this.spinQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinQuantidade.Name = "spinQuantidade";
            this.spinQuantidade.Size = new System.Drawing.Size(47, 20);
            this.spinQuantidade.TabIndex = 11;
            this.spinQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.comboProduto);
            this.groupBox3.Controls.Add(this.spinQuantidade);
            this.groupBox3.Controls.Add(this.btnAdicionarNoCarrinho);
            this.groupBox3.Location = new System.Drawing.Point(12, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(558, 102);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adicionar ao Carrinho";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Produto";
            // 
            // comboProduto
            // 
            this.comboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProduto.FormattingEnabled = true;
            this.comboProduto.Items.AddRange(new object[] {
            "Selecione um Produto"});
            this.comboProduto.Location = new System.Drawing.Point(25, 45);
            this.comboProduto.Name = "comboProduto";
            this.comboProduto.Size = new System.Drawing.Size(189, 21);
            this.comboProduto.TabIndex = 12;
            this.comboProduto.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvCarrinho);
            this.groupBox4.Location = new System.Drawing.Point(12, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(558, 190);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Carrinho";
            // 
            // dgvCarrinho
            // 
            this.dgvCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Custo_Unitario,
            this.Quantidade,
            this.Custo_Total});
            this.dgvCarrinho.Location = new System.Drawing.Point(12, 28);
            this.dgvCarrinho.Name = "dgvCarrinho";
            this.dgvCarrinho.Size = new System.Drawing.Size(529, 146);
            this.dgvCarrinho.TabIndex = 0;
            this.dgvCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Produto.Width = 183;
            // 
            // Custo_Unitario
            // 
            this.Custo_Unitario.HeaderText = "Custo Unitário";
            this.Custo_Unitario.Name = "Custo_Unitario";
            this.Custo_Unitario.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // Custo_Total
            // 
            this.Custo_Total.HeaderText = "Custo Total";
            this.Custo_Total.Name = "Custo_Total";
            this.Custo_Total.ReadOnly = true;
            // 
            // btnEsvaziarCarrinho
            // 
            this.btnEsvaziarCarrinho.Location = new System.Drawing.Point(227, 486);
            this.btnEsvaziarCarrinho.Name = "btnEsvaziarCarrinho";
            this.btnEsvaziarCarrinho.Size = new System.Drawing.Size(137, 31);
            this.btnEsvaziarCarrinho.TabIndex = 14;
            this.btnEsvaziarCarrinho.Text = "Esvaziar Carrinho";
            this.btnEsvaziarCarrinho.UseVisualStyleBackColor = true;
            this.btnEsvaziarCarrinho.Click += new System.EventHandler(this.btnEsvaziarCarrinho_Click);
            // 
            // txtPrecoTotal
            // 
            this.txtPrecoTotal.Location = new System.Drawing.Point(265, 444);
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.ReadOnly = true;
            this.txtPrecoTotal.Size = new System.Drawing.Size(95, 20);
            this.txtPrecoTotal.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 447);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Preço Total";
            // 
            // btnRemoverLinha
            // 
            this.btnRemoverLinha.Location = new System.Drawing.Point(37, 486);
            this.btnRemoverLinha.Name = "btnRemoverLinha";
            this.btnRemoverLinha.Size = new System.Drawing.Size(160, 31);
            this.btnRemoverLinha.TabIndex = 15;
            this.btnRemoverLinha.Text = "Remover Produto do Carrinho ";
            this.btnRemoverLinha.UseVisualStyleBackColor = true;
            this.btnRemoverLinha.Click += new System.EventHandler(this.btnRemoverLinha_Click);
            // 
            // TelaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 582);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrecoTotal);
            this.Controls.Add(this.btnRemoverLinha);
            this.Controls.Add(this.btnEsvaziarCarrinho);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnConfirmarCompra);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TelaCompra";
            this.Text = "TelaCompra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaCompra_FormClosing);
            this.Load += new System.EventHandler(this.TelaCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinQuantidade)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirmarCompra;
        private System.Windows.Forms.Button btnAdicionarNoCarrinho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeVendedor;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown spinQuantidade;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboProduto;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvCarrinho;
        private System.Windows.Forms.Button btnEsvaziarCarrinho;
        private System.Windows.Forms.TextBox txtPrecoTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtCodVendedorMask;
        private System.Windows.Forms.MaskedTextBox txtCpfCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custo_Unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Custo_Total;
        private System.Windows.Forms.Button btnRemoverLinha;
    }
}