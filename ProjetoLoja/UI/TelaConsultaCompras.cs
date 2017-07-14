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
using ProjetoLoja.Control;
using ProjetoLoja.DAOs;


namespace ProjetoLoja.UI
{
    public partial class TelaConsultaCompras : Form
    {
        private ClienteDAO clis;
        private VendedorDAO vends;
        private CompraDAO compras;
        private int validacao;


        public TelaConsultaCompras(ClienteDAO clis, VendedorDAO vends, CompraDAO compras)
        {
            InitializeComponent();
            this.clis = clis;
            this.vends = vends;
            this.compras = compras;

        }

        #region METODOS
        private void exibirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void todasAsComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tableCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void valorDaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableCompras.Visible = false;
            maskedCPF.Text = string.Empty;
            this.validacao = 1;
            visibleOptionsOfSearching(validacao);


        }

        private void ordemAlfabéticaDosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableCompras.Visible = false;
            this.validacao = 3;
            visibleOptionsOfSearching(validacao);
            //DETERMINADO PERÍODO POR ORDEM ALFABÉTICA DOS CLIENTES

        }

        private void valorDaCompraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tableCompras.Visible = false;
            this.validacao = 2;
            visibleOptionsOfSearching(validacao);
            //DETERMINADO PERÍODO POR VALOR DA COMPRA (MENOR PRO MAIOR)

        }



        private void ordemAlfabéticaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void visibleOptionsOfSearching(int OP)
        {
            if (OP == 1)
            {
                labelATE.Visible = false;
                labelDE.Visible = false;
                dtFinal.Visible = false;
                dtInicial.Visible = false;
                labelHistorico.Visible = false;

                labelCPF.Visible = true;
                maskedCPF.Visible = true;
            }

            if (OP == 2 || OP == 3)
            {

                labelCPF.Visible = false;
                maskedCPF.Visible = false;

                labelATE.Visible = true;
                labelDE.Visible = true;
                dtFinal.Visible = true;
                dtInicial.Visible = true;
                labelHistorico.Visible = false;
            }

            btnListar.Visible = true;



        }
        private void btnListar_Click(object sender, EventArgs e)
        {
            tableCompras.Rows.Clear();


            if (this.validacao == 3)
            {
                carregarTableOP3();
                tableCompras.Visible = true;
                labelATE.Visible = false;
                labelDE.Visible = false;
                dtInicial.Visible = false;
                dtFinal.Visible = false;

            }


            if (this.validacao == 2)
            {
                carregarTableOP2();
                tableCompras.Visible = true;
                labelATE.Visible = false;
                labelDE.Visible = false;
                dtInicial.Visible = false;
                dtFinal.Visible = false;
            }
            if (this.validacao == 1)
            {
                carregarTableOP1();
                maskedCPF.Visible = false;
                labelCPF.Visible = false;
            }

            tableCompras.Visible = true;
            btnListar.Visible = false;
            labelHistorico.Visible = true;
        }


        public void carregarTableOP3()
        {
            compras.CarregarLista();

            Compra[] arrayAux = new Compra[compras.ListaCompra.Count];
            compras.ListaCompra.CopyTo(arrayAux);
            List<Compra> listaCompraAuxiliar = arrayAux.ToList<Compra>();
            //listaCompraAuxiliar = compras.ListaCompra;
            List<Cliente> listaClienteAuxiliar = new List<Cliente>();

            foreach (Cliente clienteCompra in clis.ListaClientes)
            {
                if (clienteCompra.Compras != null)
                    listaClienteAuxiliar.Add(clienteCompra);

            }



            //foreach (compra comp in listaCompraAuxiliar)
            //{
            //    cliente cli = clis.ListaClientes.Find(i => i.codCliente == comp.codCliente);
            //    listaClienteAuxiliar.Add(cli);

            //}

            QuickSort<Cliente> clienteOrdenado = new QuickSort<Cliente>();
            clienteOrdenado.sort(listaClienteAuxiliar, 0, listaClienteAuxiliar.Count - 1);

            string[] dados = new string[5];

            DateTime dataFinal = dtFinal.Value;

            DateTime dataInicial = dtInicial.Value;

            foreach (Cliente item in listaClienteAuxiliar)
                foreach (Compra comp in item.Compras)
                {
                    //compra comp = compras.ListaCompra.Find(i => i.codCliente == item.codCliente);
                    DateTime getDate = comp.dataCompra;

                    if (dataFinal >= getDate && dataInicial <= getDate)
                    {
                        Vendedor vend = vends.ListaVendedor.Find(i => i.codVendedor == comp.codVendedor);
                        //cliente cli = clis.ListaClientes.Find(i => i.codCliente == item.codCliente);

                        dados[0] = item.nome;
                        dados[1] = comp.codCompra.ToString();
                        dados[2] = comp.dataCompra.ToShortDateString();
                        dados[3] = vend.nome;
                        dados[4] = comp.valor_total.ToString();

                        tableCompras.Rows.Add(dados);
                        //listaCompraAuxiliar.Remove(comp);
                    }


                }

        }

        public void carregarTableOP2()
        {
            compras.CarregarLista();

            List<Compra> comprasAux = this.compras.ListaCompra;


            QuickSort<Compra> comprasOrdenadas = new QuickSort<Compra>();
            comprasOrdenadas.sort(comprasAux, 0, comprasAux.Count - 1);

            string[] dados = new string[5];

            DateTime dataFinal = dtFinal.Value;

            DateTime dataInicial = dtInicial.Value;


            foreach (Compra item in comprasAux)
            {
                DateTime getDate = item.dataCompra;

                if (dataFinal >= getDate && dataInicial <= getDate)
                {
                    Vendedor vend = vends.ListaVendedor.Find(i => i.codVendedor == item.codVendedor);
                    Cliente cli = clis.ListaClientes.Find(i => i.codCliente == item.codCliente);

                    dados[0] = cli.nome;
                    dados[1] = item.codCompra.ToString();
                    dados[2] = item.dataCompra.ToShortDateString();
                    dados[3] = vend.nome;
                    dados[4] = item.valor_total.ToString();

                    tableCompras.Rows.Add(dados);
                }
            }


        }

        public void carregarTableOP1()
        {


            List<Compra> comprasAux = this.compras.ListaCompra;

            QuickSort<Compra> comprasOrdenadas = new QuickSort<Compra>();

            comprasOrdenadas.sort(comprasAux, 0, comprasAux.Count - 1);


            Cliente cli = clis.ListaClientes.Find(i => i.CPF.Equals(maskedCPF.Text));

            if (cli == null)
            {
                MessageBox.Show("ERRO: Cliente não encontrado", "ERROR");
                return;
            }


            int cod = cli.codCliente;

            string[] dados = new string[5];

            foreach (Compra item in comprasAux)
            {
                if (item.codCliente == cod)
                {

                    Vendedor vend = vends.ListaVendedor.Find(i => i.codVendedor == item.codVendedor);

                    dados[0] = cli.nome;  //PRECISO PEGAR O NOME DO CLIENTE ATRAVES DESSA CHAVE ESTRANGEIRA
                    dados[1] = item.codCompra.ToString();
                    dados[2] = item.dataCompra.ToShortDateString();
                    dados[3] = vend.nome.ToString();   //PRECISO PEGAR O NOME DO VENDEDOR ATRAVES DESSA CHAVE ESTRANGEIRA
                    dados[4] = item.valor_total.ToString();
                    tableCompras.Rows.Add(dados);

                }
            }



        }

        private void maskedCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        #endregion
    }


}

