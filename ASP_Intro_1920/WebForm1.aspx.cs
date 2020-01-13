using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Intro_1920
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string dados = "IP:" + Request.UserHostAddress + "\n" +
                "Tipo de pedido:" + Request.RequestType + "\n" +
                "Nome: " + Request.UserHostName + "\n" +
                "Método http: " + Request.HttpMethod;

            divDados.InnerText = dados;

            //ler o parâmetro ====QueryString
            if (Request.QueryString["valor"] != null)
            {
                string qs = Request.QueryString["valor"];

                divDados.InnerText += "<br/>" + qs;
            }

        }

        protected void bt1_Click(object sender, EventArgs e)
        {
            string qs = "webform2.aspx";
            qs += "?valor=" + Server.UrlEncode(TextBox1.Text);
            Response.Redirect(qs);
        }
    }
}