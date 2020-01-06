<%@ Page Language="C#" AutoEventWireup="true" ViewStateMode="Disabled" CodeBehind="index.aspx.cs" Inherits="ASP_Intro_1920.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Número 1:<asp:TextBox ID="TextBox1" runat="server" Width="244px"></asp:TextBox>
            <br />
&nbsp;Numero 2:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Somar" />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
