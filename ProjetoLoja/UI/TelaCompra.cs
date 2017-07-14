using ProjetoLoja.Model;
using ProjetoLoja.DAOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoLoja.UI
{
    public partial class TelaCompra : Form
    {
        private DAOs.CompraDAO compraDAO;
        private DAOs.Compra_ProdutoDAO compraProdutoDAO;
        private VendedorDAO vendedorDAO;
        private ClienteDAO clienteDAO;
        private ProdutoDAO produtoDAO;

        #region CONSTRUTOR
        public TelaCompra(DAOs.CompraDAO compraDao, DAOs.Compra_ProdutoDAO compraProdutoDao, VendedorDAO vendedorDao, ClienteDAO clienteDao, ProdutoDAO produtoDao)
        {
            InitializeComponent();
            this.compraDAO = compraDao;
            this.compraProdutoDAO = compraProdutoDao;
            this.vendedorDAO = vendedorDao;
            this.clienteDAO = clienteDao;
            this.produtoDAO = produtoDao;
        }
        #endregion

        #region AÇÕES

        private void txtCodVendedorMaskLostFocus(object sender, EventArgs e)
        {
            int codigo;

            if (this.ContainsFocus == true)
                try
                {
                    codigo = int.Parse(txtCodVendedorMask.Text);
                    Vendedor vendedorEncontrado = vendedorDAO.ListaVendedor.Find(i => i.codVendedor == codigo);

                    if (vendedorEncontrado == null)
                    {
                        txtCodVendedorMask.Text = string.Empty;
                        if (this.ContainsFocus == true)
                            MessageBox.Show("Vendedor não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        txtNomeVendedor.Text = vendedorEncontrado.nome;
                    }


                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Digite o Código do Vendedor para iniciar sua compra");

                }
        }

        private void txtCpfCliente_LostFocus(object sender, EventArgs e)
        {

            if (this.ContainsFocus == true)
                try
                {

                    Cliente clienteEncontrado = clienteDAO.ListaClientes.Find(i => i.CPF == txtCpfCliente.Text);

                    if (clienteEncontrado == null)
                    {
                        txtCpfCliente.Text = string.Empty;
                        if (this.ContainsFocus == true)
                            MessageBox.Show("Cliente não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        txtNomeCliente.Text = clienteEncontrado.nome;
                    }

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Digite o CPF do Cliente para iniciar sua compra");
                }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboProduto.Items.Clear();
            comboProduto.Items.AddRange(produtoDAO.ListaProduto.ToArray());
        }

        private void btnAdicionarNoCarrinho_Click(object sender, EventArgs e)
        {
            //List<produto> listaGridView = new List<produto>();
            //produto prod = produtoDAO.ListaProduto.Find(i => i.descricao == comboProduto.SelectedItem.ToString());
            Produto prod = (Produto)comboProduto.SelectedItem;
            float custoUnitario = prod.valor;
            int quantidade = (int)spinQuantidade.Value;
            float custoTotal = custoUnitario * quantidade;
           

            string[] dados = { prod.ToString(), custoUnitario.ToString(), quantidade.ToString(), custoTotal.ToString() };



            if (quantidade > prod.quantidade)
            {
                MessageBox.Show("Quantidade insuficiente em estoque", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                spinQuantidade.Focus();
                return;
            }
            dgvCarrinho.Rows.Add(dados);
            double precoTotal = 0;

            foreach (DataGridViewRow item in dgvCarrinho.Rows)
            {
                precoTotal += Convert.ToDouble(item.Cells["Custo_Total"].Value);
                txtPrecoTotal.Text = precoTotal.ToString();
            }





        }

        private void btnConfirmarCompra_Click(object sender, EventArgs e)
        {

            Cliente cli = clienteDAO.ListaClientes.Find(i => i.CPF == txtCpfCliente.Text);

            Compra novaCompra = new Compra();
            novaCompra.dataCompra = DateTime.Today;
            novaCompra.codCliente = cli.codCliente;
            novaCompra.codVendedor = int.Parse(txtCodVendedorMask.Text);
            novaCompra.valor_total = float.Parse(txtPrecoTotal.Text);

            compraDAO.Salvar(novaCompra);
            //compraDAO.SalvarLista();

            int linha = 0;


            foreach (DataGridViewRow item in dgvCarrinho.Rows)
            {
                Produto prod = produtoDAO.ListaProduto.Find(i => i.descricao == item.Cells["Produto"].Value.ToString());
                int index = compraDAO.ListaCompra.Count - 1;
                Compra comp = compraDAO.ListaCompra.ElementAt(index);
                Compra_Produto novaCompraProduto = new Compra_Produto();
                novaCompraProduto.codProduto = prod.codProduto;
                novaCompraProduto.codCompra = comp.codCompra;
                novaCompraProduto.qtde_comprada = Convert.ToInt32(item.Cells["Quantidade"].Value);
                novaCompraProduto.valor_comprado = float.Parse(item.Cells["Custo_Total"].Value.ToString());

                prod.quantidade -= novaCompraProduto.qtde_comprada;
                compraProdutoDAO.Salvar(novaCompraProduto);
                produtoDAO.SalvarAlteracoes(prod);

                linha++;

                if (dgvCarrinho.Rows.Count - 1 == linha)
                {
                    break;
                }
            }

            MessageBox.Show("Compra efetuada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limparTela();
            //produtoDAO.SalvarLista();

            


        }

        private void btnEsvaziarCarrinho_Click(object sender, EventArgs e)
        {
            if (dgvCarrinho.RowCount == 1)
            {
                MessageBox.Show("O Carrinho está vazio!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            dgvCarrinho.Rows.Clear();
            txtPrecoTotal.Text = string.Empty;
        }

        private void btnRemoverLinha_Click(object sender, EventArgs e)
        {
            
            if (dgvCarrinho.RowCount == 1)
            {
                MessageBox.Show("O Carrinho está vazio!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            float soma = 0;

            DataGridViewSelectedRowCollection linhas = dgvCarrinho.SelectedRows;
            foreach (DataGridViewRow linha in linhas)
            {
                soma = float.Parse(linha.Cells["Custo_Total"].Value.ToString());
                dgvCarrinho.Rows.Remove(linha);
            }

            float valor_total = float.Parse(txtPrecoTotal.Text);
            valor_total -= soma;
            txtPrecoTotal.Text = valor_total.ToString();

        }

        private void limparTela()
        {
            dgvCarrinho.Rows.Clear();
            txtCodVendedorMask.Text = string.Empty;
            txtCpfCliente.Text = string.Empty;
            txtNomeVendedor.Text = string.Empty;
            txtNomeCliente.Text = string.Empty;
            txtPrecoTotal.Text = string.Empty;
            spinQuantidade.Value = 1;
            comboProduto.SelectedIndex = -1;
        }

        #endregion

        #region OUTROS

        private void TelaCompra_FormClosing(object sender, FormClosingEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void TelaCompra_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodVendedorMask_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        #endregion


    }
}

