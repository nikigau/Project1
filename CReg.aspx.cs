using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class CReg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Breaking Page Refreshment
            if (!IsPostBack)
            {
                //for auto display of date
                txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                //ClientScript.RegisterStartupScript(this.GetType(), "validateEmailScript", "validateEmail();", true);
                //ClientScript.RegisterStartupScript(this.GetType(), "validateMobileScript", "validateMobile();", true);
            }

        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string mobile = txtMobile.Text;

            // Validate the email using a regular expression
            var emailRegex = new System.Text.RegularExpressions.Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$");
            bool isEmailValid = emailRegex.IsMatch(email);

            // Validate the mobile number using a regular expression
            var mobileRegex = new System.Text.RegularExpressions.Regex(@"^\d{10}$");
            bool isMobileValid = mobileRegex.IsMatch(mobile);

            if (isEmailValid && isMobileValid)
            {

                string a, b, c, d, f, g;
                a = txtCname.Text;
                b = txtCcode.Text;
                c = txtPname.Text;
                d = txtEmail.Text;
                g = txtMobile.Text;
                f = txtPass.Text;
                Admin a1 = new Admin();
                a1.input(a, b, c, d, g, f, txtDate.Text);
                Session["code"] = b;
                Session["cpass"] = f;
                Session["cname"] = a;
                lblmsg.Text = "Successfully Added";
        }
    else
    {
        // Displaying an error message if validation fails
        Response.Write(" <script> alert(' Validation failed. Please enter valid email and mobile number.')</script> ");
    }

}
protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("clogin.aspx?a=" + txtCname.Text + "&f=" + txtPass.Text +"&b" +txtCcode.Text);
        }
    }
}