using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Intro_1920
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                TextBox1.Text = "0";
                TextBox2.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n1, n2;

            n1 = int.Parse(TextBox1.Text);
            n2 = int.Parse(TextBox2.Text);

            int s = n1 + n2;

            Label1.Text = s.ToString();
        }
    }
}