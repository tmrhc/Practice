using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

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
           
        SqlCommand cmd1 = new SqlCommand("Insert into Signup(Signupfirstname,Signuplastname,Signupemail, Signupusername, Signuppassword) Values ('" + firstname + "','" + lastname + "','" + email + "', '" + username + "','" + password + "')", con);

            cmd1.ExecuteNonQuery();

            cmd1.Dispose();

            con.Close();

            return "Registration Successful";
        
    }


    [WebMethod]

    public string User_Login(string username, string password)
    {
        //Connection String
        string cs = ConfigurationManager.ConnectionStrings["csGiftfinder"].ConnectionString;

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