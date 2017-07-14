using ProjetoLoja.DAOs;
using ProjetoLoja.Model;
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
    public partial class TelaCadastroProduto : Form
    {

        private DAO<Produto> produtoDAO;

        #region CONSTRUTOR
        public TelaCadastroProduto(DAO<Produto> produtoDao)
        {
            InitializeComponent();
            this.produtoDAO = produtoDao;
        }
        #endregion

        #region AÇAO
        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            Produto novoProduto = new Produto();

            novoProduto.descricao = txtDescricao.Text;
            novoProduto.valor = float.Parse(txtValor.Text);
            novoProduto.quantidade = (int)spinQuantidade.Value;

            produtoDAO.Salvar(novoProduto);
            limparTela();
            MessageBox.Show("Produto Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TelaCadastroProduto_FormClosing(object sender, FormClosingEventArgs e)
        {
            //produtoDAO.SalvarLista();
        }
        #endregion

        public void limparTela()
        {
            txtDescricao.Text = string.Empty;
            txtValor.Text = string.Empty;
            spinQuantidade.Value = 0;
        }
    }
}
