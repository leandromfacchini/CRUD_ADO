<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="Site.Pages.Consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Consulta</title>
    <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
<script src="Scripts/jquery-3.0.0.js"></script>
<script src="Scripts/bootstrap.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="offset-1">
                <div class="row">
                    <h3 class="card card-body text-center">Lista de Clientes</h3>
                </div>
                <div>
                    <asp:GridView ID="grdCliente" runat="server" CssClass="table table-striped" GridLines="None" AutoGenerateColumns="false" BackColor="#cccccc">
                        <Columns>
                            <asp:BoundField DataField="Codigo" HeaderText="Código" />
                            <asp:BoundField DataField="Nome" HeaderText="Nome" />
                            <asp:BoundField DataField="Endereco" HeaderText="Endereço" />
                            <asp:BoundField DataField="Email" HeaderText="Email" />
                        </Columns>
                        <RowStyle CssClass="table-hover" />

                    </asp:GridView>
                </div>
                <div>
                    <p>
                        <asp:Label ID="lblMensagem" runat="server" />
                    </p>
                    <a href="../Default.aspx" class="btn btn-info">Voltar</a>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
