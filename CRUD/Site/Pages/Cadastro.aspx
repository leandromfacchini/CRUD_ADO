<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="Site.Pages.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cadastro</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
<script src="Scripts/jquery-3.0.0.js"></script>
<script src="Scripts/bootstrap.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="offset-1">
                <div class="row">
                    <h3 class="card card-body text-center">Cadastro de Cliente</h3>
                </div>
                <div>
                    Nome do Cliente<br />
                    <asp:TextBox ID="txtNome" runat="server" placeholder="Nome Completo" Width="45%"
                        CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtNome" ErrorMessage="Informe um nome válido"
                        ForeColor="Red"
                        ID="requiredNome" />
                </div>
                <div>
                    Endereço do Cliente<br />
                    <asp:TextBox ID="txtEndereco" runat="server" placeholder="Endereço Residencial" Width="45%"
                        CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtNome" ErrorMessage="Informe um endereço válido"
                        ForeColor="Red"
                        ID="requiredEndereco" />
                </div>
                <div>
                    Email do Cliente<br />
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Email do Cliente" Width="45%"
                        CssClass="form-control" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="txtNome" ErrorMessage="Informe um email válido"
                        ForeColor="Red"
                        ID="requiredEmail" />
                </div>
                <div>
                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                    <asp:Button ID="btnCadastro" CssClass="btn btn-success" runat="server" OnClick="btnCadastro_Click" Text="Cadastrar" />
                    <a href="../Default.aspx" class="btn btn-info">Voltar</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
