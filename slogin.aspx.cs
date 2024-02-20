using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class slogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }

        }

       

        protected void btnAccount_Click1(object sender, EventArgs e)
        {
            Response.Redirect("studentreg.aspx");

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if(txtSemail.Text == (string)Session["semail"] && txtSpass.Text == (string)Session["spass"])
            {
                Response.Redirect("studentpanel.aspx");
            }
        }
    }
}