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
    public partial class TelaCadastroVendedor : Form
    {

        private VendedorDAO vendedorDAO;

        #region CONSTRUTOR
        public TelaCadastroVendedor(VendedorDAO vendedorDao)
        {
            InitializeComponent();
            this.vendedorDAO = vendedorDao;
        }
        #endregion

        #region AÇOES
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Vendedor novoVendedor = new Vendedor();
            novoVendedor.nome = txtNome.Text;
            
            char sexo = 'M';
            if (rbFeminino.Checked)
                sexo = 'F';

            novoVendedor.sexo = sexo.ToString();
            novoVendedor.telefone = txtTelefone.Text;
            novoVendedor.RG = txtRG.Text;
            novoVendedor.CPF = txtCPF.Text;

            if (vendedorDAO.verificarDuplicidade(novoVendedor.RG, novoVendedor.CPF) == true)
            {
                MessageBox.Show("Ja existe um cliente com esse RG ou CPF!\n" + "Por favor verifique!");
                txtRG.Text = string.Empty;
                txtCPF.Text = string.Empty;
                txtRG.Focus();
                return;
            }

            vendedorDAO.Salvar(novoVendedor);
            limparTela();
            MessageBox.Show("Vendedor Cadastrado com Sucesso!","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        private void TelaCadastroVendedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            //vendedorDAO.SalvarLista();
        }
        #endregion

        public void limparTela()
        {
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            rbMasculino.Checked = false;
            rbFeminino.Checked = false;
        }

        
    }
}
