using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class clogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               
            }

        }

       
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("CReg.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string a = (string)Session["cname"];
            string b = (string)Session["code"];
            string c = (string)Session["cpass"];

            if (b == txtCid.Text && c == txtPass.Text)
            {
                Response.Redirect("clgadmin.aspx?a=" +"&b=" +txtCid.Text );
            }
            else
            {
                Response.Redirect("<script> alert('Invalid') </script>");
            }
        }
    }
}