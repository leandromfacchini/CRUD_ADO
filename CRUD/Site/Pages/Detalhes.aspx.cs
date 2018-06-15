using CRUD.DAL.Model;
using CRUD.DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Site.Pages
{
    public partial class Detalhes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            plnDados.Visible = false;
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                lblMensagem.Text = string.Empty;

                int codigo = Convert.ToInt32(txtCodigo.Text);

                PessoaDAL dAL = new PessoaDAL();
                Pessoa pessoa = dAL.ListarPessoa(codigo);

                if (pessoa != null)
                {
                    txtNome.Text = pessoa.Nome;
                    txtEmail.Text = pessoa.Email;
                    txtEndereco.Text = pessoa.Endereco;

                    plnDados.Visible = true;

                }
                else
                {
                    lblMensagem.Text = "Cliente não encontrado !";
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtCodigo.Text))
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);

                    PessoaDAL dAL = new PessoaDAL();
                    dAL.Excluir(codigo);

                    txtNome.Text = string.Empty;
                    txtEmail.Text = string.Empty;
                    txtEndereco.Text = string.Empty;

                    txtCodigo.Text = string.Empty;
                    txtCodigo.Focus();
                }
                else
                {
                    lblMensagem.Text = "Informe um código válido !";
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }

        protected void btnAtualiza_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(txtCodigo.Text))
                {
                    int codigo = Convert.ToInt32(txtCodigo.Text);

                    PessoaDAL dAL = new PessoaDAL();
                    Pessoa pessoa = new Pessoa();

                    pessoa.Email = txtEmail.Text;
                    pessoa.Endereco = txtEndereco.Text;
                    pessoa.Nome = txtNome.Text;

                    if (dAL.Atualizar(pessoa) > 0)
                    {
                        txtEmail.Text = string.Empty;
                        txtEndereco.Text = string.Empty;
                        txtNome.Text = string.Empty;

                        txtCodigo.Text = string.Empty;
                        txtCodigo.Focus();
                    }

                }
                else
                {
                    lblMensagem.Text = "Informe um código válido !";
                }
            }
            catch (Exception ex)
            {
                lblMensagem.Text = ex.Message;
            }
        }
    }
}