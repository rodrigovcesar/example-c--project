using ProjetoLoja.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoLoja.DAOs
{
    public class ClienteDAO : DAO<Cliente>
    {
        private Contexto bancoDados;
        private List<Cliente> listaClientes;

        public List<Cliente> ListaClientes
        {
            get { return listaClientes; }
            set { listaClientes = value; }
        }

        public ClienteDAO(Contexto db)
        {

            this.bancoDados = db;
            CarregarLista();
        }


        public void CarregarLista()
        {
            try
            {
                if (listaClientes == null)
                    this.listaClientes = bancoDados.Clientes.OrderBy(i => i.codCliente).ToList();
            }
            catch (Exception e)
            {
                mensagemErro(e.Message);

            }


        }

        public void Salvar(Cliente novoCliente)
        {

            try
            {
                bancoDados.Clientes.Add(novoCliente);
                bancoDados.SaveChanges();


                listaClientes.Add(novoCliente);

            }
            catch (Exception e)
            {
                mensagemErro(e.Message);
            }

        }

        public void SalvarAlteracoes(Cliente clienteAlterado)
        {
            try
            {
                bancoDados.Entry(clienteAlterado).State = EntityState.Modified;
                bancoDados.SaveChanges();

                int indice = listaClientes.FindIndex(i => i.codCliente == clienteAlterado.codCliente);
                listaClientes[indice] = clienteAlterado;
                
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
            foreach (Cliente cli in listaClientes)
            {
                if (cli.RG.Equals(rg))
                {
                    resultado = true;
                }
                if (cli.CPF.Equals(cpf))
                {
                    resultado = true;
                }

            }

            return resultado;
        }


    }
}
