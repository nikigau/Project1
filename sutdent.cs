using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    
    public class sutdent
    {
        SqlConnection con;
        SqlCommand com;
       // SqlDataReader dr;
        public string input(string cname, string sname, string branch, string email, string mobile, string semester, string pass, string date)
        {
            string path = ConfigurationManager.AppSettings["db"];
            con = new SqlConnection(path);
            con.Open();
            string ins = "insert into studentreg (Cname,Sname,branch,Email,Mobile,Sem,Pass,Date) values(@Cname1,@Sname1,@branch1,@Email1,@Mobile1,@Sem1,@Pass1,@Date1)";
            com = new SqlCommand(ins, con);
            com.Parameters.AddWithValue("Cname1", cname);
            com.Parameters.AddWithValue("Sname1", sname);
            com.Parameters.AddWithValue("branch1", branch);
            com.Parameters.AddWithValue("Email1", email);
            com.Parameters.AddWithValue("Mobile1", mobile);
            com.Parameters.AddWithValue("Sem1", semester);
            com.Parameters.AddWithValue("Pass1", pass);
            com.Parameters.AddWithValue("Date1", date);
            com.ExecuteNonQuery();
            return ins;
        }
        public string input1(string cname1,string sname1,string email1,string barnch1,string complain,string msg,string date)
        {
            string path = ConfigurationManager.AppSettings["db"];
            con = new SqlConnection(path);
            con.Open();
            string s1 = "insert into complaindb(Cname,Stuname,Email,Branch,Complain,Msg,Date) values(@Cname1,@Stuname1,@Email1,@Branch1,@Complain1,@Msg1,@Date1)";
            com = new SqlCommand(s1, con);
            com.Parameters.AddWithValue("Cname1", cname1);
            com.Parameters.AddWithValue("Stuname1", sname1);
            com.Parameters.AddWithValue("Email1", email1);
            com.Parameters.AddWithValue("Branch1", barnch1);
            com.Parameters.AddWithValue("Complain1", complain);
            com.Parameters.AddWithValue("Msg1", msg);
            com.Parameters.AddWithValue("Date1", date);
            com.ExecuteNonQuery();
            return s1;


        }
    }
   
}