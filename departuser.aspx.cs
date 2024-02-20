using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Adding Libraray
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public partial class departuser : System.Web.UI.Page
    {
        //creating objects
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string a = (string)Session["cname"];
                txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
                string b = (string)Session["code"];
                btnFind.Visible = false;
                //Accessing Configuration File
                string path = ConfigurationManager.AppSettings["db"];
                con = new SqlConnection(path);
                con.Open();
                string s1 = "select * from depart where CCode=@CCode1";
                com=new SqlCommand(s1, con);
                com.Parameters.AddWithValue("CCode1", b);
                dr = com.ExecuteReader();
                if (dr.Read())
                {
                    txtCname.Text = dr["CName"].ToString();
                    txtCcode.Text = dr["CCode"].ToString();
                    ddlDepart.Items.Add(dr["DName"].ToString());
                   
                }
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string a, b, c, d, h, g;
            a = txtCname.Text;
            b = txtCcode.Text;
            c = ddlDepart.SelectedValue;
            d = txtFaculty.Text;
            int f = int.Parse(txtUser.Text);
            h = txtPass.Text;
            g = txtDate.Text;
            Admin a1 = new Admin();
            a1.input3(a,b,c,d,f,h,g);

            lblMsg.Text = "Added Successfully";

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            string a = (string)Session["code"];
            //Accessing Configuration File
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
                btnFind.Visible = true;

            }
        }

        protected void btnFind_Click(object sender, EventArgs e)
        {
            string path = ConfigurationManager.AppSettings["db"];
            con = new SqlConnection(path);
            con.Open();
            string s2 = "select * from departuser";
            com = new SqlCommand(s2, con);
            dr = com.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            GridViewRow r1 = ((Button)sender).NamingContainer as GridViewRow;
            string a = (string)Session["code"];
            Button btnDel = (Button)r1.FindControl("btnDelete");
            string path = ConfigurationManager.AppSettings["db"];
            con = new SqlConnection(path);
            con.Open();
            string s4 = "DELETE from departuser where CCode=@CCode1";
            com = new SqlCommand(s4, con);
            com.Parameters.AddWithValue("CCode1", a);
            com.ExecuteNonQuery();
            Response.Write("<script> alert('Deleted') </script>");

        }
    }
}