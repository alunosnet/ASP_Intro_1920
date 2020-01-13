using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Intro_1920
{
    public partial class webform2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["valor"] != null)
            {
                string qs = Server.UrlDecode(Request.QueryString["valor"]);
                divQQ.InnerText = qs;

                //para escrever na página podemos fazer

                Response.Write(qs);
            }
        }
    }
}