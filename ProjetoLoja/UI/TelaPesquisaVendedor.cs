using System;
using System.Windows.Forms;
using ProjetoLoja.DAOs;
using ProjetoLoja.Model;

namespace ProjetoLoja.UI
{
    public partial class TelaPesquisaVendedor : Form
    {

        private VendedorDAO vendedores;
        

        public TelaPesquisaVendedor(VendedorDAO Vendedor)
        {
            InitializeComponent();
            this.vendedores = Vendedor;
        }


        #region METODOS
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            
            Vendedor vendFound = vendedores.ListaVendedor.Find(i => i.CPF == txtCPF.Text);

            if(vendFound == null)
            {
                MessageBox.Show("Vendedor não encontrado","Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            
            vendFound.RG = txtRG.Text;
            vendFound.nome = txtNome.Text;
            vendFound.telefone = txtTelefone.Text;

            MessageBox.Show("Dados do Cliente Atualizados com Sucesso!", "Atualização Realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpar_Travar_Tela();

            btnSalvar.Visible = false;
            btnCancel.Visible = false;
            vendedores.SalvarAlteracoes(vendFound);
            //vendedores.SalvarLista();
        }


        private void Lost_Focus(object sender, EventArgs e)
        {
            if (this.ContainsFocus == true)

                try {
                 Vendedor vendFound = vendedores.ListaVendedor.Find(i => i.CPF == txtCPF.Text);
                    if (vendFound == null)
                    {
                        txtCPF.Text = string.Empty;
                        if (this.ContainsFocus == true)
                            MessageBox.Show("Vendedor não encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        limpar_Travar_Tela();
                        return;
                    }
                    else
                    {

                        txtNome.Text = vendFound.nome;
                        txtRG.Text = vendFound.RG;
                        txtTelefone.Text = vendFound.telefone;
                        txtCod.Text = vendFound.codVendedor.ToString();

                        if (vendFound.sexo.Equals("M"))
                        {
                            radioButton1.Checked = true;
                        }
                        else
                        {
                            radioButton2.Checked = true;
                        }
                    }

                } catch (FormatException ex)
                {
                    MessageBox.Show("Digite o CPF do Cliente para procurá-lo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Vendedor não localizado: " + ex.Message);
                }


        }
        
        private void limpar_Travar_Tela()
        {
            txtNome.ReadOnly = true;
            txtRG.ReadOnly = true;
            txtTelefone.ReadOnly = true;

            txtNome.Text = string.Empty;
            txtCPF.Text = string.Empty;
            txtRG.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtCod.Text = string.Empty;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (!txtNome.Text.Equals(""))
            {
                txtRG.ReadOnly = false;
                txtTelefone.ReadOnly = false;
                txtNome.ReadOnly = false;

                btnEditar.Visible = false;
                btnSalvar.Visible = true;
                btnCancel.Visible = true;


            }
            else
            {
                MessageBox.Show("Busque por um Vendedor!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            limpar_Travar_Tela();
            btnEditar.Visible = true;
            btnSalvar.Visible = false;
            btnCancel.Visible = false;
        }

        private void TelaPesquisaVendedor_Load(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
