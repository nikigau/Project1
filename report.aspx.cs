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
    public partial class report : System.Web.UI.Page
    {
        //creating objects
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string a = (string)Session["code"];
                string path = ConfigurationManager.AppSettings["db"];
                con = new SqlConnection(path);
                con.Open();
                string s1 = "select * from depart where CCode=@CCode1";
                com = new SqlCommand(s1, con);
                com.Parameters.AddWithValue("CCode1", a);
                dr = com.ExecuteReader();
                if (dr.Read())
                {

                    ddlDepart1.Items.Add(dr["DName"].ToString());

                }

            }

        }

        protected void btnFind_Click(object sender, EventArgs e)
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

            // string path = ConfigurationManager.AppSettings["db"];
            //con = new SqlConnection(path);
            // con.Open();
            // string s1 = "select * from departuser where CCode=@CCode1";
            // com = new SqlCommand(s1, con);
            ////com.Parameters.AddWithValue("CCode1", a);
            // dr = com.ExecuteReader();
            // GridView1.DataSource = dr;
            // GridView1.DataBind();
            // dr.Close();
            foreach (GridViewRow r1 in GridView1.Rows)
            {

                DropDownList ddl = (DropDownList)r1.FindControl("ddlFac");
                string a = (string)Session["code"];
                string path1 = ConfigurationManager.AppSettings["db"];
                con = new SqlConnection(path1);
                con.Open();
                string s3 = "select * from departuser where CCode=@CCode1";
                com = new SqlCommand(s3, con);
                com.Parameters.AddWithValue("CCode1", a);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    ddl.Items.Add(new ListItem(dr["Uname"].ToString()));


                }
                dr.Close();
                foreach (GridViewRow r2 in GridView1.Rows)
                {
                    DropDownList ddlsta = (DropDownList)r2.FindControl("ddlStatus");
                    ddlsta.Items.Add(new ListItem("CLOSE"));
                    ddlsta.Items.Add(new ListItem("PENDING"));
                    ddlsta.Items.Add(new ListItem("FORWARD"));
                }

            }

            }

        }
}


   
