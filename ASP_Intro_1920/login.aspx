<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="ASP_Intro_1920.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            Email:<asp:TextBox CssClass="form-control" ID="tbEmail" TextMode="Email" runat="server"></asp:TextBox><br />
            Password:<asp:TextBox CssClass="form-control" ID="tbPassword" TextMode="Password" runat="server"></asp:TextBox><br />
            <asp:Button CssClass="btn btn-lg btn-info" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /><br />
            <asp:Label ID="lbErro" runat="server" Text=""></asp:Label>

            <% if (Session["email"] != null) { %>
            <a href="logout.aspx">Terminar Sessão</a>
            <% } %>
        </div>
    </form>
</body>
</html>
