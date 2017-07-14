using ProjetoLoja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoLoja.DAOs
{
    public class CompraDAO : DAO<Compra>
    {
        private Contexto bancoDados;
        private List<Compra> listaCompra;

        public List<Compra> ListaCompra
        {
            get { return listaCompra; }
            set { listaCompra = value; }
        }

        public CompraDAO(Contexto db)
        {
            this.bancoDados = db;
            CarregarLista();
        }


        public void CarregarLista()
        {

            try
            {
                //if (listaCompra == null)
                    listaCompra = bancoDados.Compras.OrderBy(i => i.codCompra).ToList();

            }
            catch (Exception e)
            {
                mensagemErro(e.Message);

            }

        }

     


        public void Salvar(Compra novaCompra)
        {
            try
            {
                bancoDados.Compras.Add(novaCompra);
                bancoDados.SaveChanges();

                listaCompra.Add(novaCompra);
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
