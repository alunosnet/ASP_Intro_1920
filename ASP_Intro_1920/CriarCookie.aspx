<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CriarCookie.aspx.cs" Inherits="ASP_Intro_1920.CriarCookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divCookie" runat="server">
            Este site utiliza cookies.
            <asp:Button ID="bt1" runat="server"
                Text="Aceitar" OnClick="bt1_Click" />
        </div>
    </form>
</body>
</html>
