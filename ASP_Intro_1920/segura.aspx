<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="segura.aspx.cs" Inherits="ASP_Intro_1920.segura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Olá <% Response.Write(Session["email"].ToString()); %>

            <a href="logout.aspx">Terminar Sessão</a>
        </div>
    </form>
</body>
</html>
