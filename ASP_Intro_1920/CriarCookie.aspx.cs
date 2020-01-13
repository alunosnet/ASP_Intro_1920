using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Intro_1920
{
    public partial class CriarCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar se o cookie existe
            HttpCookie existe = Request.Cookies["PSIM17"];
            if (existe != null)
                divCookie.Visible = false;
        }

        protected void bt1_Click(object sender, EventArgs e)
        {
            //criar cookie
            HttpCookie novo = new HttpCookie("PSIM17");
            novo.Expires = DateTime.Now.AddDays(1);

            //enviar cookie para o browser
            Response.Cookies.Add(novo);

            //esconder a div
            divCookie.Visible = false;
        }
    }
}