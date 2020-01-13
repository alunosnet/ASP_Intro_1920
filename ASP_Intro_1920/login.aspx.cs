using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Intro_1920
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //testar login
            string email = tbEmail.Text;
            string password = tbPassword.Text;
            if(email=="joaquim@gmail.com" &&
                password == "12345")
            {
                //iniciar sessão
                Session["email"] = email;
                Session["data_hora"] = DateTime.Now;
                Session["perfil"] = "0";
                Response.Redirect("segura.aspx");
            }
            lbErro.Text = "Login falhou.";
        }
    }
}