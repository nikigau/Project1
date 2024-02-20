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
    public partial class stucomplain : System.Web.UI.Page
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string a = (string)Session["semail"];
                txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                string path = ConfigurationManager.AppSettings["db"];
                con = new SqlConnection(path);
                con.Open();
                string s1 = "select * from studentreg where Email=@Email1";
                com = new SqlCommand(s1, con);
                com.Parameters.AddWithValue("Email1",a);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    txtCname.Text = dr["Cname"].ToString();
                    txtSname.Text = dr["Sname"].ToString();
                    txtEmail.Text = dr["Email"].ToString();
                    txtBranch.Text = dr["branch"].ToString();

                }

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string a, b, c, d, f, g, h;
            a = txtCname.Text;
            b = txtSname.Text;
            c = txtEmail.Text;
            d = txtBranch.Text;
            f = ddlComplain.SelectedValue;
            g = txtMsg.Text;
            h = txtDate.Text;
            sutdent s1 = new sutdent();
            s1.input1(a, b, c, d, f, g, h);
            lblMsg.Text = "Added Successfully";
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["db"];
            con = new SqlConnection(path);
            con.Open();
            string s2 = "select * from complaindb";
            com = new SqlCommand(s2, con);
            dr = com.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();


        }
    }
}