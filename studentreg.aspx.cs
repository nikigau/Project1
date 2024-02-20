using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;



namespace WebApplication1
{
    public partial class studentlogin : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {

            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            if (!IsPostBack)
            {
                string a = (string)Session["code"];
                string path = ConfigurationManager.AppSettings["db"];
                con = new SqlConnection(path);
                con.Open();
                string i = "select * from clgreg where CCode= @CCode1";
                com = new SqlCommand(i, con);
                com.Parameters.AddWithValue("CCode1", a);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    // ddlDepart.Items.Add(dr["DName"].ToString());
                    ddlClg.Items.Add(dr["CName"].ToString());
                    
                }
                dr.Close();
               
                string i1 = "select * from depart where CCode= @CCode1";
                com = new SqlCommand(i1, con);
                com.Parameters.AddWithValue("CCode1", a);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    
                    ddlBranch.Items.Add(dr["DName"].ToString());

                }
                dr.Close();


            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string a, b, c, d, f, g, h,i;
            a = ddlClg.SelectedValue;
            b = txtSname.Text;
            c = ddlBranch.SelectedValue;
            d = txtEmail.Text;
            f = txtMobile.Text;
            g = txtSemester.Text;
            h = txtPass.Text;
            i = txtDate.Text;
            sutdent s1 = new sutdent();
            s1.input(a,b,c,d,f,g,h,i);
            Session["semail"] = d;
            Session["spass"] = h;
            lblMsg.Text = "Added Successfully";
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("slogin.aspx?d="+txtEmail.Text+ "&h=" +txtPass.Text);
        }
    }
}