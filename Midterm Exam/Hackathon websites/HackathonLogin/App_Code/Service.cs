using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Webservice : System.Web.Services.WebService
{

    public Webservice()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string Signup(string firstname, string lastname, string email, string username, string password)
    {


        //Connection String
        string cs = ConfigurationManager.ConnectionStrings["csGiftfinder"].ConnectionString;

        //Creating Sqlconnection object and establishing connection

        SqlConnection con = new SqlConnection(cs);

        con.Open();
        SqlCommand cmd = new SqlCommand("Select Signupusername from Signup where Signupusername=username", con);


        string result = cmd.ExecuteScalar().ToString();

        int count = string.Compare(result, username);

        if (count == 0)
        {


            con.Close();

            return "Account already exists";



        }
        else
        {

            SqlCommand cmd1 = new SqlCommand("Insert into Signup(Signupfirstname,Signuplastname,Signupemail,Signuppassword) Values ('" + firstname + "','" + lastname + "','" + email + "', '" + username + "' '" + password + "')", con);

            cmd1.ExecuteNonQuery();

            cmd1.Dispose();

            con.Close();

            return "Registration Successful";
        }
    }


    [WebMethod]

    public string User_Login(string username, string password)
    {
        //Connection String
        string cs = ConfigurationManager.ConnectionStrings["csHackathon"].ConnectionString;

        //Creating Sqlconnection object and establishing connection

        SqlConnection con = new SqlConnection(cs);

        SqlCommand cmd = new SqlCommand();

        cmd.Connection = con;

        cmd.CommandText = "Select Signuppassword From Signup where Signupusername ='" + username + "'";

        con.Open();

        SqlDataReader dr = cmd.ExecuteReader();

        if (!dr.Read() || dr["Signuppassword"].ToString() != password)
        {
            con.Close();
            return "Login Failed";

        }
        else
        {
            con.Close();
            return "Login Successful";

        }

    }

}