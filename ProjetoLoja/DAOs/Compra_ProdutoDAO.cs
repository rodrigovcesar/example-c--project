using ProjetoLoja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoLoja.DAOs
{
    public class Compra_ProdutoDAO : DAO<Compra_Produto>
    {
        private Contexto bancoDados;
        private List<Compra_Produto> listaCompraProduto;

        public List<Compra_Produto> ListaCompraProduto
        {
            get
            {
                return listaCompraProduto;
            }

            set
            {
                listaCompraProduto = value;
            }
        }

        public Compra_ProdutoDAO(Contexto db)
        {
            this.bancoDados = db;
            CarregarLista();
        }


        public void CarregarLista()
        {

            try
            {
                if (listaCompraProduto == null)
                    listaCompraProduto = bancoDados.Compra_Produto.OrderBy(i => i.codCompra).ToList();

            }
            catch (Exception e)
            {
                mensagemErro(e.Message);

            }


        }

        //public void SalvarLista()
        //{
        //    try
        //    {
        //        foreach (compra_produto compras in listaCompraProduto)
        //        {
        //            bancoDados.Entry(compras).State = compras.codCompra == 0 ?
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


        public void Salvar(Compra_Produto novoCompraProduto)
        {

            try
            {
                bancoDados.Compra_Produto.Add(novoCompraProduto);
                bancoDados.SaveChanges();

                listaCompraProduto.Add(novoCompraProduto);
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
