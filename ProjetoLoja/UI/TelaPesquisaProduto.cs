using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLoja.Model;
using ProjetoLoja.DAOs;

namespace ProjetoLoja.UI
{
    public partial class TelaPesquisaProduto : Form
    {

        private ProdutoDAO produtos;

        
        public TelaPesquisaProduto(ProdutoDAO prod)
        {
            InitializeComponent();
            this.produtos = prod;

            List<Produto> produtos = new List<Produto>();
            produtos = this.produtos.ListaProduto;

            foreach(Produto item in produtos)
            {
                comboBox1.Items.Add(item.descricao);
            }

        }

        #region METODOS
        private void combobox_LostFocus(object sender,EventArgs e)
        {
            if (this.ContainsFocus == true)

                try
                {
                    Produto prodFound = produtos.ListaProduto.Find(i => i.descricao.Equals(comboBox1.SelectedItem));
                    if (prodFound == null)
                    {
                        MessageBox.Show("Selecione um Produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        currentQtd.Text = prodFound.quantidade.ToString();
                        currentPrice.Text = prodFound.valor.ToString();
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Selecione o Produto!");
                }

        }

        private void TelaPesquisaProduto_Load(object sender, EventArgs e)
        {

        }

        private void btnQtd_Click(object sender, EventArgs e)
        {

            if (!currentQtd.Text.Equals(""))
            {
                eraseEverything();

                currentQtd.ReadOnly = false;
                btnSave.Visible = true;
            }
            else
            {
                MessageBox.Show("Busque por um Produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnChangedPrice_Click(object sender, EventArgs e)
        {

            if (currentQtd.Text.Equals(""))
            {
                MessageBox.Show("Busque por um Produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                btnChangedPrice.Visible = false;
                btnQtd.Visible = false;

                currentPrice.ReadOnly = false;
                btnSave.Visible = true;

            }

        }

        public void eraseEverything()
        {
            btnQtd.Visible = false;
            btnChangedPrice.Visible = false;
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {

            Produto prodUpdate = produtos.ListaProduto.Find(i => i.descricao.Equals(comboBox1.SelectedItem));
                if (prodUpdate == null)
                {
                    eraseEverything();
                    MessageBox.Show("Selecione um Produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    prodUpdate.quantidade = int.Parse(currentQtd.Text);
                    prodUpdate.valor = float.Parse(currentPrice.Text);

                    MessageBox.Show("Estoque Atualizado com Sucesso!", "Atualização Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                btnSave.Visible = false;

                currentQtd.ReadOnly = true;
                currentPrice.ReadOnly = true;
                btnChangedPrice.Visible = true;
                btnQtd.Visible = true;

                produtos.SalvarAlteracoes(prodUpdate);
                //produtos.SalvarLista();

                }
            
        }
        
        private void changeQtd_TextChanged(object sender, EventArgs e)
        {
        }
        #endregion



    }
}
