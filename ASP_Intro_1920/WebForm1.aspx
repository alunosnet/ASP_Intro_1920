<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASP_Intro_1920.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="divDados" runat="server">
        </div>

        Valor a passar para a outra página: <asp:TextBox runat="server" ID="TextBox1" />
        <asp:Button runat="server" ID="bt1" OnClick="bt1_Click" />
    </form>
</body>
</html>
