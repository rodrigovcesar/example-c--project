using ProjetoLoja.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoLoja.DAOs
{
    public class VendedorDAO : DAO<Vendedor>
    {
        private Contexto bancoDados;
        private List<Vendedor> listaVendedor;

        public List<Vendedor> ListaVendedor
        {
            get { return listaVendedor; }
        }

        public VendedorDAO(Contexto db)
        {
            this.bancoDados = db;
            CarregarLista();
        }


        public void CarregarLista()
        {
            
            try
            {
                if (listaVendedor == null)
                    listaVendedor = bancoDados.Vendedors.OrderBy(i => i.codVendedor).ToList();

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
        //        foreach (vendedor vendedor in listaVendedor)
        //        {
        //            bancoDados.Entry(vendedor).State = vendedor.codVendedor == 0 ?
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

        public void SalvarAlteracoes(Vendedor vendedorAlterado)
        {
            try
            {
                bancoDados.Entry(vendedorAlterado).State = EntityState.Modified;
                bancoDados.SaveChanges();

                int indice = listaVendedor.FindIndex(i => i.codVendedor == vendedorAlterado.codVendedor);
                listaVendedor[indice] = vendedorAlterado;

            }
            catch (Exception e)
            {
                mensagemErro(e.Message);
            }
        }


        public void Salvar(Vendedor novoVendedor)
        {
            try
            {
                bancoDados.Vendedors.Add(novoVendedor);
                bancoDados.SaveChanges();

                listaVendedor.Add(novoVendedor);
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

        public bool verificarDuplicidade(string rg, string cpf)
        {
            bool resultado = false;
            foreach (Vendedor vendedor in listaVendedor)
            {
                if (vendedor.RG.Equals(rg))
                {
                    resultado = true;
                }
                if (vendedor.CPF.Equals(cpf))
                {
                    resultado = true;
                }

            }

            return resultado;
        }
    }
}
