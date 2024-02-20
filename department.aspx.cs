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
    public partial class department : System.Web.UI.Page
    {
        //creating objects
        SqlConnection con;
        SqlCommand com;
        SqlDataReader dr;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtCName.Text = (string)Session["cname"];
                txtCcode.Text = (string)Session["code"];
                Button1.Visible = false;

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string a, b, c;
            a = txtCName.Text;
            b = txtCcode.Text;
            c = txtDepart.Text;
            Admin a1 = new Admin();
            a1.input2(a,b,c);
            lblMsg.Text = "Added Successfuly";
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            //Accessing Configuration File
            string path = ConfigurationManager.AppSettings["db"];
            con = new SqlConnection(path);
            con.Open();
            string s = "select * from  depart";
            com = new SqlCommand(s, con);
            dr = com.ExecuteReader();
            GridView1.DataSource = dr;
            GridView1.DataBind();
            dr.Close();
            Button1.Visible = true;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow r1 in GridView1.Rows)
            {
                CheckBox check = (CheckBox)r1.FindControl("check");
                try
                {
                    if (check != null && check.Checked)
                    {
                        string a = (string)Session["code"];
                        string path = ConfigurationManager.AppSettings["db"];
                        con = new SqlConnection(path);
                        con.Open();
                        string s4 = "DELETE from departuser where CCode=@CCode1";
                        com = new SqlCommand(s4, con);
                        com.Parameters.AddWithValue("CCode1", a);
                        com.ExecuteNonQuery();
                        GridView1.DataBind();
                        Response.Write("<script> alert('Deleted') </script>");
                    }
                }
                catch (Exception obj)
                {
                    Response.Write(obj);

                }
            }

           }
        }
   }
