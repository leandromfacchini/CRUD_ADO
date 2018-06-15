using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CRUD.DAL.Model;
using CRUD.DAL.Persistence;

namespace Site.Pages
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.Nome = txtNome.Text;
                pessoa.Email = txtEmail.Text;
                pessoa.Endereco = txtEmail.Text;

                PessoaDAL dal = new PessoaDAL();
                dal.GravarDados(pessoa);

                txtNome.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtEndereco.Text = string.Empty;

                lblMensagem.Text = string.Format("CLIENTE {0} CADASTRADO COM SUCESSO", pessoa.Nome);
            }
            catch (Exception ex)
            {

                lblMensagem.Text = ex.ToString();
            }
            finally
            {

            }
        }
    }
}