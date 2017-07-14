using ProjetoLoja.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoLoja.DAOs
{
    public class ProdutoDAO : DAO<Produto>
    {
        private Contexto bancoDados;
        private List<Produto> listaProduto;

        public List<Produto> ListaProduto
        {
            get { return listaProduto; }
            set { listaProduto = value; }
        }

        public ProdutoDAO(Contexto db)
        {
            this.bancoDados = db;
            CarregarLista();
        }


        public void CarregarLista()
        {

            try
            {
                if (listaProduto == null)
                    listaProduto = bancoDados.Produtoes.OrderBy(i => i.codProduto).ToList();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }

        }

        //public void SalvarLista()
        //{
        //    try
        //    {
        //        foreach (produto produto in listaProduto)
        //        {
        //            bancoDados.Entry(produto).State = produto.codProduto == 0 ?
        //                               EntityState.Added :
        //                               EntityState.Modified;
        //        }
        //        bancoDados.SaveChanges();

        //    }
        //    catch (Exception e)
        //    {
        //        mensagemErro(e.Message);
        //    }


        //}


        public void Salvar(Produto novoProduto)
        {
            try
            {
                bancoDados.Produtoes.Add(novoProduto);
                bancoDados.SaveChanges();

                listaProduto.Add(novoProduto);
            }
            catch (Exception e)
            {
                mensagemErro(e.Message);
            }

        }

        public void SalvarAlteracoes(Produto produtoAlterado)
        {
            try
            {
                bancoDados.Entry(produtoAlterado).State = EntityState.Modified;
                bancoDados.SaveChanges();

                int indice = listaProduto.FindIndex(i => i.codProduto == produtoAlterado.codProduto);
                listaProduto[indice] = produtoAlterado;

            }
            catch (Exception e)
            {
                mensagemErro(e.Message);
            }
        }

        private void mensagemErro(string mensagem)
        {
            MessageBox.Show("Erro com o banco de dados: " + mensagem);
        }
    }
}
