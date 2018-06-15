<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Site.Pages.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Detalhes</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
<script src="Scripts/jquery-3.0.0.js"></script>
<script src="Scripts/bootstrap.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="offset-1">
                <div class="row">
                    <h3 class="card card-body text-center">Detalhes do Cliente</h3>
                </div>
                <div class="row">
                    Código do Cliente
                </div>
                <div class="row">
                    <asp:TextBox ID="txtCodigo" runat="server" placeholder="Código" Width="10%" CssClass="form-control" />
                    &nbsp;&nbsp;
                    <asp:Button ID="btnPesquisar" runat="server" Text="Pesquisar" CssClass="btn btn-info" Width="10%" OnClick="btnPesquisar_Click" />
                    &nbsp;&nbsp;
                    <a href="../Default.aspx" style="width: 10%" class="btn btn-dark">Voltar</a>
                    <br />
                </div>

                <asp:Panel ID="plnDados" runat="server">
                    <div class="row py-2">
                        <asp:TextBox runat="server" ID="txtNome" Text="Pesquisar" CssClass="form-control" Width="30%" />
                    </div>
                    <div class="row py-2">
                        <asp:TextBox runat="server" ID="txtEmail" Text="Email" CssClass="form-control" Width="30%" />
                    </div>
                    <div class="row py-2">
                        <asp:TextBox runat="server" ID="txtEndereco" Text="Endereço" CssClass="form-control" Width="30%" />
                    </div>
                    <div>
                        <div class="row">
                            <asp:Button ID="btnExcluir" runat="server" Text="Excluir" CssClass="btn btn-warning" Width="80px" OnClick="btnExcluir_Click" />
                            &nbsp;&nbsp;
                    <asp:Button ID="btnAtualiza" runat="server" Text="Atualizar" CssClass="btn btn-danger" Width="80px" OnClick="btnAtualiza_Click" />
                            &nbsp;&nbsp;
                    
                        </div>
                    </div>
                </asp:Panel>
                <div class="row">
                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
