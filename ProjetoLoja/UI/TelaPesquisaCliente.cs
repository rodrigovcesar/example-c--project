using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLoja.DAOs;
using ProjetoLoja.Model;


//SALVAR AS ATUALIZAÇÕES QUANDO FECHA TUDO



namespace ProjetoLoja.UI
{
    public partial class TelaPesquisaCliente : Form
    {

        private ClienteDAO clienteDAO;

        public TelaPesquisaCliente(ClienteDAO cli)
        {
            InitializeComponent();
            this.clienteDAO = cli;
        }



        #region METODOS
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if(!txtNome.Text.Equals(""))
            {
                txtEndereco.ReadOnly = false;
                txtRG.ReadOnly = false;
                txtTelefone.ReadOnly = false;
                txtNome.ReadOnly = false;

                btnEditar.Visible = false;
                btnSalvar.Visible = true;
                btnCancel.Visible = true;
                btnEditar.Visible = false;
                

            } else
            {
                MessageBox.Show("Busque por um Cliente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        

        


        private void txtCPF_LostFocus(object sender, EventArgs e)
        {
            if (this.ContainsFocus == true)
                try
                {
                       
                        Cliente clienteEncontrado = clienteDAO.ListaClientes.Find(i => i.CPF == txtCPF.Text);

                        if (clienteEncontrado == null)
                        {
                            txtCPF.Text = string.Empty;
                            if (this.ContainsFocus == true)
                                MessageBox.Show("Cliente não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpar_Travar_Tela();
                        return;
                        }
                        else
                        {
                            txtNome.Text = clienteEncontrado.nome;
                            txtEndereco.Text = clienteEncontrado.endereco;
                            txtRG.Text = clienteEncontrado.RG;
                            txtTelefone.Text = clienteEncontrado.telefone;
                            dtNascimento.Value = clienteEncontrado.dtNascimento;

                            if (clienteEncontrado.sexo.Equals("M"))
                            {
                                radioButton1.Checked = true;
                            }
                            else
                            {
                                radioButton2.Checked = true;
                            }
                            
                        }

                  
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Digite o CPF do Cliente para procurá-lo");
                }
        

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            limpar_Travar_Tela();
            btnEditar.Visible = true;
            btnSalvar.Visible = false;
            btnCancel.Visible = false;

        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Cliente clienteEncontrado = clienteDAO.ListaClientes.Find(i => i.CPF == txtCPF.Text);

            clienteEncontrado.RG = txtRG.Text;
            clienteEncontrado.nome = txtNome.Text;
            clienteEncontrado.endereco = txtEndereco.Text;
            clienteEncontrado.telefone = txtTelefone.Text;
            clienteEncontrado.dtNascimento = dtNascimento.Value;
            
            MessageBox.Show("Dados do Cliente Atualizados com Sucesso!", "Atualização Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar_Travar_Tela();

            btnSalvar.Visible = false;
            btnCancel.Visible = false;
            clienteDAO.SalvarAlteracoes(clienteEncontrado);
            //clienteDAO.SalvarLista();
        }
        
    


        private void limpar_Travar_Tela()
        {
            txtNome.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtRG.ReadOnly = true;
            txtTelefone.ReadOnly = true;

            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtEndereco.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void txtCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        #endregion

        private void txtRG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
