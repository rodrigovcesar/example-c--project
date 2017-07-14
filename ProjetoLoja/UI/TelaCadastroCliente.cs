using ProjetoLoja.DAOs;
using ProjetoLoja.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjetoLoja
{
    public partial class TelaCadastroCliente : Form
    {
        //private DAO<cliente> clienteDAO;
        private ClienteDAO clienteDAO;

        #region CONTRUTOR
        public TelaCadastroCliente(ClienteDAO clienteDao)
        {
            InitializeComponent();
            this.clienteDAO = clienteDao;
        }
        #endregion

        #region AÇÕES

        private void btnSalvar_Click(object sender, EventArgs e)  
        {
            Cliente novoCliente = new Cliente();


            novoCliente.nome = txtNome.Text;
            char sexo = 'M';
            if (radioButton2.Checked)
                sexo = 'F';
            novoCliente.sexo = sexo.ToString();
            novoCliente.telefone = txtTelefone.Text;
            novoCliente.endereco = txtEndereco.Text;
            novoCliente.RG = txtRG.Text;
            novoCliente.CPF = txtCPF.Text;
            novoCliente.dtNascimento = dtNascimento.Value;

            if (clienteDAO.verificarDuplicidade(novoCliente.RG, novoCliente.CPF) == true)
            {
                MessageBox.Show("Ja existe um cliente com esse RG ou CPF\n" + "Por favor verifique!");
                txtRG.Text = string.Empty;
                txtCPF.Text = string.Empty;
                txtRG.Focus();
                return;
            }

            clienteDAO.Salvar(novoCliente);
            limparTela();
            MessageBox.Show("Cliente Cadastrado com Sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void dtNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        

        #endregion


        private void limparTela()
        {
            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEndereco.Text = string.Empty;            
            radioButton1.Checked = false;
            radioButton2.Checked = false;            
        }

    }
}
