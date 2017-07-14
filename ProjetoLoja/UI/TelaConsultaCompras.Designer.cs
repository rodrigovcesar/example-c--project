namespace ProjetoLoja.UI
{
    partial class TelaConsultaCompras
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exibirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todasAsComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cassificarPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordemAlfabéticaDosClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valorDaCompraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.valorDaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableCompras = new System.Windows.Forms.DataGridView();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelDE = new System.Windows.Forms.Label();
            this.labelATE = new System.Windows.Forms.Label();
            this.dtInicial = new System.Windows.Forms.DateTimePicker();
            this.dtFinal = new System.Windows.Forms.DateTimePicker();
            this.maskedCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.labelHistorico = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exibirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exibirToolStripMenuItem
            // 
            this.exibirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todasAsComprasToolStripMenuItem,
            this.valorDaCompraToolStripMenuItem});
            this.exibirToolStripMenuItem.Name = "exibirToolStripMenuItem";
            this.exibirToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.exibirToolStripMenuItem.Text = "Consultar por";
            this.exibirToolStripMenuItem.Click += new System.EventHandler(this.exibirToolStripMenuItem_Click);
            // 
            // todasAsComprasToolStripMenuItem
            // 
            this.todasAsComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cassificarPorToolStripMenuItem});
            this.todasAsComprasToolStripMenuItem.Name = "todasAsComprasToolStripMenuItem";
            this.todasAsComprasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.todasAsComprasToolStripMenuItem.Text = "Determinado Período";
            this.todasAsComprasToolStripMenuItem.Click += new System.EventHandler(this.todasAsComprasToolStripMenuItem_Click);
            // 
            // cassificarPorToolStripMenuItem
            // 
            this.cassificarPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordemAlfabéticaDosClientesToolStripMenuItem,
            this.valorDaCompraToolStripMenuItem1});
            this.cassificarPorToolStripMenuItem.Name = "cassificarPorToolStripMenuItem";
            this.cassificarPorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cassificarPorToolStripMenuItem.Text = "Classificar por";
            // 
            // ordemAlfabéticaDosClientesToolStripMenuItem
            // 
            this.ordemAlfabéticaDosClientesToolStripMenuItem.Name = "ordemAlfabéticaDosClientesToolStripMenuItem";
            this.ordemAlfabéticaDosClientesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.ordemAlfabéticaDosClientesToolStripMenuItem.Text = "Ordem Alfabética dos Clientes";
            this.ordemAlfabéticaDosClientesToolStripMenuItem.Click += new System.EventHandler(this.ordemAlfabéticaDosClientesToolStripMenuItem_Click);
            // 
            // valorDaCompraToolStripMenuItem1
            // 
            this.valorDaCompraToolStripMenuItem1.Name = "valorDaCompraToolStripMenuItem1";
            this.valorDaCompraToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
            this.valorDaCompraToolStripMenuItem1.Text = "Valor da Compra";
            this.valorDaCompraToolStripMenuItem1.Click += new System.EventHandler(this.valorDaCompraToolStripMenuItem1_Click);
            // 
            // valorDaCompraToolStripMenuItem
            // 
            this.valorDaCompraToolStripMenuItem.Name = "valorDaCompraToolStripMenuItem";
            this.valorDaCompraToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.valorDaCompraToolStripMenuItem.Text = "Determinado Cliente";
            this.valorDaCompraToolStripMenuItem.Click += new System.EventHandler(this.valorDaCompraToolStripMenuItem_Click);
            // 
            // tableCompras
            // 
            this.tableCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.codCompra,
            this.dataCompra,
            this.Vendedor,
            this.valorCompra});
            this.tableCompras.Location = new System.Drawing.Point(12, 80);
            this.tableCompras.Name = "tableCompras";
            this.tableCompras.ReadOnly = true;
            this.tableCompras.Size = new System.Drawing.Size(601, 238);
            this.tableCompras.TabIndex = 3;
            this.tableCompras.Visible = false;
            this.tableCompras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableCompras_CellContentClick);
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // codCompra
            // 
            this.codCompra.HeaderText = "Nota Fiscal";
            this.codCompra.Name = "codCompra";
            this.codCompra.ReadOnly = true;
            // 
            // dataCompra
            // 
            this.dataCompra.HeaderText = "Data da Compra";
            this.dataCompra.Name = "dataCompra";
            this.dataCompra.ReadOnly = true;
            // 
            // Vendedor
            // 
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            this.Vendedor.ReadOnly = true;
            // 
            // valorCompra
            // 
            this.valorCompra.HeaderText = "Valor da Compra";
            this.valorCompra.Name = "valorCompra";
            this.valorCompra.ReadOnly = true;
            this.valorCompra.Width = 150;
            // 
            // labelDE
            // 
            this.labelDE.AutoSize = true;
            this.labelDE.Location = new System.Drawing.Point(28, 47);
            this.labelDE.Name = "labelDE";
            this.labelDE.Size = new System.Drawing.Size(21, 13);
            this.labelDE.TabIndex = 4;
            this.labelDE.Text = "De";
            this.labelDE.Visible = false;
            // 
            // labelATE
            // 
            this.labelATE.AutoSize = true;
            this.labelATE.Location = new System.Drawing.Point(178, 47);
            this.labelATE.Name = "labelATE";
            this.labelATE.Size = new System.Drawing.Size(23, 13);
            this.labelATE.TabIndex = 5;
            this.labelATE.Text = "Até";
            this.labelATE.Visible = false;
            // 
            // dtInicial
            // 
            this.dtInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInicial.Location = new System.Drawing.Point(55, 41);
            this.dtInicial.MinDate = new System.DateTime(2015, 11, 1, 0, 0, 0, 0);
            this.dtInicial.Name = "dtInicial";
            this.dtInicial.Size = new System.Drawing.Size(84, 20);
            this.dtInicial.TabIndex = 6;
            this.dtInicial.Value = new System.DateTime(2015, 12, 1, 0, 0, 0, 0);
            this.dtInicial.Visible = false;
            // 
            // dtFinal
            // 
            this.dtFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFinal.Location = new System.Drawing.Point(207, 41);
            this.dtFinal.MinDate = new System.DateTime(2015, 12, 1, 0, 0, 0, 0);
            this.dtFinal.Name = "dtFinal";
            this.dtFinal.Size = new System.Drawing.Size(84, 20);
            this.dtFinal.TabIndex = 7;
            this.dtFinal.Value = new System.DateTime(2015, 12, 1, 0, 0, 0, 0);
            this.dtFinal.Visible = false;
            // 
            // maskedCPF
            // 
            this.maskedCPF.Location = new System.Drawing.Point(61, 44);
            this.maskedCPF.Mask = "000.000.000-00";
            this.maskedCPF.Name = "maskedCPF";
            this.maskedCPF.Size = new System.Drawing.Size(100, 20);
            this.maskedCPF.TabIndex = 9;
            this.maskedCPF.Visible = false;
            this.maskedCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedCPF_MaskInputRejected);
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(28, 47);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(27, 13);
            this.labelCPF.TabIndex = 10;
            this.labelCPF.Text = "CPF";
            this.labelCPF.Visible = false;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(337, 41);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 11;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Visible = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // labelHistorico
            // 
            this.labelHistorico.AutoSize = true;
            this.labelHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHistorico.Location = new System.Drawing.Point(154, 36);
            this.labelHistorico.Name = "labelHistorico";
            this.labelHistorico.Size = new System.Drawing.Size(211, 24);
            this.labelHistorico.TabIndex = 13;
            this.labelHistorico.Text = "Histórico de Compras";
            this.labelHistorico.Visible = false;
            // 
            // TelaConsultaCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 338);
            this.Controls.Add(this.labelHistorico);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.maskedCPF);
            this.Controls.Add(this.dtFinal);
            this.Controls.Add(this.dtInicial);
            this.Controls.Add(this.labelATE);
            this.Controls.Add(this.labelDE);
            this.Controls.Add(this.tableCompras);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaConsultaCompras";
            this.Text = "TelaConsultaCompras";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exibirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todasAsComprasToolStripMenuItem;
        private System.Windows.Forms.DataGridView tableCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorCompra;
        private System.Windows.Forms.ToolStripMenuItem valorDaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cassificarPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordemAlfabéticaDosClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem valorDaCompraToolStripMenuItem1;
        private System.Windows.Forms.Label labelDE;
        private System.Windows.Forms.Label labelATE;
        private System.Windows.Forms.DateTimePicker dtInicial;
        private System.Windows.Forms.DateTimePicker dtFinal;
        private System.Windows.Forms.MaskedTextBox maskedCPF;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label labelHistorico;
    }
}