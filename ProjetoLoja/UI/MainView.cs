using ProjetoLoja.DAOs;
using ProjetoLoja.Model;
using System;
using System.Windows.Forms;
using ProjetoLoja.UI;

namespace ProjetoLoja
{
    public partial class Form1 : Form
        
    {
        private Contexto db;
        private ClienteDAO daoClientes;
        private CompraDAO daoCompras;
        private Compra_ProdutoDAO daoCompra_Produto;
        private ProdutoDAO daoProduto;
        private VendedorDAO daoVendedor;


        #region CONSTRUTOR
        public Form1(Contexto banco)
        {
            this.db = banco;
            InitializeComponent();

            //this.daoClientes = new ClienteDAO(db);
            //this.daoCompras = new CompraDAO(db);
            //this.daoCompra_Produto = new Compra_ProdutoDAO(db);
            //this.daoProduto = new ProdutoDAO(db);
            //this.daoVendedor = new VendedorDAO(db);
        }
        #endregion


        #region AÇAO
        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (daoClientes == null)
                this.daoClientes = new ClienteDAO(db);

            TelaCadastroCliente cadastroCliente = new TelaCadastroCliente(daoClientes);
            cadastroCliente.Show();

        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (daoProduto == null)
                this.daoProduto = new ProdutoDAO(db);

            TelaCadastroProduto cadastroProduto = new TelaCadastroProduto(daoProduto);
            cadastroProduto.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (daoVendedor == null)
                this.daoVendedor = new VendedorDAO(db);

            TelaCadastroVendedor cadastroVendedor = new TelaCadastroVendedor(daoVendedor);
            cadastroVendedor.Show();
        }

        private void registrarNovaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (daoCompras == null)
                daoCompras = new CompraDAO(db);

            if (daoCompra_Produto == null)
                daoCompra_Produto = new Compra_ProdutoDAO(db);

            if (daoVendedor == null)
                daoVendedor = new VendedorDAO(db);

            if (daoClientes == null)
                daoClientes = new ClienteDAO(db);

            if (daoProduto == null)
                daoProduto = new ProdutoDAO(db);


            TelaCompra registraCompra = new TelaCompra(daoCompras, daoCompra_Produto, daoVendedor, daoClientes, daoProduto);
            registraCompra.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            db.Dispose();
            Application.Exit();
        }

        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (daoClientes == null)
                daoClientes = new ClienteDAO(db);

            TelaConsultaCliente consult = new TelaConsultaCliente(daoClientes);
            consult.Show();
        }

        private void exibirAlterarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (daoVendedor == null)
                daoVendedor = new VendedorDAO(db);

            TelaPesquisaVendedor consult = new TelaPesquisaVendedor(daoVendedor);
            consult.Show();
        }
        #endregion

        private void pesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (daoClientes == null)
                daoClientes = new ClienteDAO(db);

            TelaPesquisaCliente pesquisarEditarCliente = new TelaPesquisaCliente(daoClientes);
            pesquisarEditarCliente.Show();
        }

        private void exibirToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            if (daoCompras == null)
                daoCompras = new CompraDAO(db);
                       

            if (daoVendedor == null)
                daoVendedor = new VendedorDAO(db);

            if (daoClientes == null)
                daoClientes = new ClienteDAO(db);

            

            TelaConsultaCompras consult = new TelaConsultaCompras(daoClientes, daoVendedor, daoCompras);
            consult.Show();
        }

        private void exibirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (daoProduto == null)
                daoProduto = new ProdutoDAO(db);

            TelaPesquisaProduto consult = new TelaPesquisaProduto(daoProduto);
            consult.Show();


        }

       

        
    }
}
