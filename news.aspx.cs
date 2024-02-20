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
    public partial class news : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblCCode.Text = (string)Session["code"];
                lblCname.Text = (string)Session["cname"];
                txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string a, b, c, d, f;
            a = lblCCode.Text;
            b = lblCname.Text;
            c = txtNews.Text;
            d = txtMsg.Text;
            f = txtDate.Text;
            Admin a1 = new Admin();
            a1.input4(a,b,c,d,f);
            lblMsg.Text = "Added Successfuly";

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["db"];
            con = new SqlConnection(path);
            con.Open();
            string s1 = "select * from newsdb";
            com = new SqlCommand(s1, con);
            dr = com.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();

        }
    }
}