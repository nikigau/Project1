using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Adding Libraray
using System.Data.SqlClient;
using System.Configuration;

namespace WebApplication1
{
    public class Admin
    {
        //creating objects
        SqlConnection con;
        SqlCommand com;
        //SqlDataReader dr;
        public string input(string Cname,string Ccode,string Prin,string Email,string Mobile,string Pass,string Date)
        {
            //Accessing Configuration File
            string path = ConfigurationManager.AppSettings["db"];
            con = new SqlConnection(path);
            con.Open();
            //query for inserting values
            string ins = "insert into clgreg(CName,CCode,Principle,Email,Mobile,Pass,Date) values(@CName1,@CCode1,@Principle1,@Email1,@Mobile1,@Pass1,@Date1)";
            com = new SqlCommand(ins, con);
            com.Parameters.AddWithValue("CName1",Cname);
            com.Parameters.AddWithValue("CCode1", Ccode);
            com.Parameters.AddWithValue("Principle1", Prin);
            com.Parameters.AddWithValue("Email1", Email);
            com.Parameters.AddWithValue("Mobile1", Mobile);
            com.Parameters.AddWithValue("Pass1", Pass);
            com.Parameters.AddWithValue("Date1", Date);
            com.ExecuteNonQuery();
            return ins;
        }
        public string input2(string clgname , string clgcode , string clgdepart )
        {
            //Accessing Configuration File
            string path = ConfigurationManager.AppSettings["db"];
            con = new SqlConnection(path);
            con.Open();
            string ins = "insert into depart (CName,CCode,DName) values(@CName1,@CCode1,@DName1)";
            com = new SqlCommand(ins, con);
            com.Parameters.AddWithValue("CName1", clgname);
            com.Parameters.AddWithValue("CCode1", clgcode);
            com.Parameters.AddWithValue("DName1", clgdepart);
            com.ExecuteNonQuery();
            return ins;

        }
        public string input3(string cname1,string code1,string cdepart,string uname,int uid,string pass1,string date1)
        {
            string path = ConfigurationManager.AppSettings["db"];
            con = new SqlConnection(path);
            con.Open();
            string i = "insert into departuser(CName,CCode,Dname,Uname,uid,Pass,Date) values(@CName1,@CCode1,@Dname1,@Uname1,@uid1,@Pass1,@Date1)";
            com = new SqlCommand(i,con);
            com.Parameters.AddWithValue("CName1", cname1);
            com.Parameters.AddWithValue("CCode1", code1);
            com.Parameters.AddWithValue("Dname1", cdepart);
            com.Parameters.AddWithValue("Uname1",uname);
            com.Parameters.AddWithValue("uid1",uid);
            com.Parameters.AddWithValue("Pass1", pass1);
            com.Parameters.AddWithValue("Date1", date1);
            com.ExecuteNonQuery();
            return i;

        }
        public string input4(string ccode2,string cname2,string newst,string msg,string date2 )
        {
            string path = ConfigurationManager.AppSettings["db"];
            con = new SqlConnection(path);
            con.Open();
            string i = "insert into newsdb (Ccode,Cname,NewsT,Msg,Date) values(@Ccode1,@Cname1,@NewsT1,@Msg1,@Date1)";
            com = new SqlCommand(i, con);
            com.Parameters.AddWithValue("Ccode1", ccode2);
            com.Parameters.AddWithValue("Cname1", cname2);
            com.Parameters.AddWithValue("NewsT1", newst);
            com.Parameters.AddWithValue("Msg1", msg);
            com.Parameters.AddWithValue("Date1",date2);
            com.ExecuteNonQuery();
            return i;
        }
    }
}