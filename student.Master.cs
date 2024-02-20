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
    public partial class student : System.Web.UI.MasterPage
    {
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblEmail.Text = (string)Session["semail"];
                string a = (string)Session["code"];
                string path = ConfigurationManager.AppSettings["db"];
                con = new SqlConnection(path);
                con.Open();
                string s1 = "select * from newsdb where Ccode=@Ccode1";
                com = new SqlCommand(s1, con);
                com.Parameters.AddWithValue("Ccode1", a);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    lblNews.Text = dr["NewsT"].ToString();
                }
            }
        }
    }
}