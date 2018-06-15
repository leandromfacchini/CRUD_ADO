<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Site.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link type="text/css" rel="stylesheet" href="Pages/Content/bootstrap.css" />
</head>
<script src="Pages/Scripts/jquery-3.0.0.js"></script>
<script src="Pages/Scripts/bootstrap.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="jumbotron">
            <h1>Projeto CRUD - Controle de Clientes</h1>

            Selecione a operação desejada:
            <asp:DropDownList ID="ddlMenu" runat="server">
                <asp:ListItem Value="0" Text=" - Escolha uma opção - " />
                <asp:ListItem Value="1" Text=" - Cadastrar Cliente - " />
                <asp:ListItem Value="2" Text=" - Consultar Cliente - " />
                <asp:ListItem Value="3" Text=" - Obter dados do Cliente - " />
            </asp:DropDownList>

            <asp:Button ID="btnMenu" runat="server" Text="Acessar" CssClass="btn btn-primary" OnClick="btnMenu_Click" />
            <br />
            <asp:Label ID="lblMensagem" runat="server" />
        </div>
    </form>
</body>
</html>
