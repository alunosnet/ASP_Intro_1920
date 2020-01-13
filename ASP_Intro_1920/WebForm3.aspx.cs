using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Intro_1920
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bt1_Click(object sender, EventArgs e)
        {
            //verificar se existe algum ficheiro
            if (FileUpload1.HasFile)
            {
                //verificar o tipo de ficheiro
                if(FileUpload1.PostedFile.ContentType!="image/jpeg"
                    && FileUpload1.PostedFile.ContentType!="image/png")
                {
                    Response.Write("<script>alert('O tipo de ficheiro não é suportado.')</script>");
                    return;
                }
                //verificar tamanho
                if(FileUpload1.PostedFile.ContentLength>0 &&
                    FileUpload1.PostedFile.ContentLength < 5000000)
                {
                    //guardar ficheiro
                    string caminho = Server.MapPath(@"~\Ficheiros\");
                    caminho += FileUpload1.FileName;
                    FileUpload1.SaveAs(caminho);
                }
                else
                {
                    Response.Write("<script>alert('O ficheiro é muito grande.')</script>");
                }

            }


        }
    }
}