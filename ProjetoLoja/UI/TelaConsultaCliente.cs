using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLoja.Control;
using ProjetoLoja.DAOs;
using ProjetoLoja.Model;

namespace ProjetoLoja.UI
{

    public partial class TelaConsultaCliente : Form
    {
        private ClienteDAO obj;

        public TelaConsultaCliente(ClienteDAO cli)
        {
            InitializeComponent();
            this.obj = cli;


            List<Cliente> clientes = new List<Cliente>();
            clientes = cli.ListaClientes;
            
            QuickSort<Cliente> clientesOrdenados = new QuickSort<Cliente>();

            clientesOrdenados.sort(clientes, 0, clientes.Count - 1);


            foreach (Cliente item in clientes)
            {
                string [] dados = {item.nome, item.CPF, item.RG, item.sexo, item.dtNascimento.ToShortDateString(), item.telefone, item.endereco };
                tableConsulta.Rows.Add(dados);
            }
            }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void TelaConsultaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
