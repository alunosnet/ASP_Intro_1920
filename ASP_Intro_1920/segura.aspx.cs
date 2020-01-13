﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Intro_1920
{
    public partial class segura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //verificar se iniciou sessão
            if (Session["email"] == null)
                Response.Redirect("login.aspx");
            //testar perfil
            if(Session["perfil"]==null ||
                Session["perfil"].Equals("0")==false)
                Response.Redirect("login.aspx");
        }
    }
}