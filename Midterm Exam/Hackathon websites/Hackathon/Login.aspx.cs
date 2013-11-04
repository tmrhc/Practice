using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtLoginusername.Text == "demo" && txtpassword.Text == "demo")
        {
            Response.Redirect("User Home.aspx");
        }
          
    //  {
        
      //  string cs = ConfigurationManager.ConnectionStrings["csGiftfinder"].ConnectionString;

    //    SqlConnection con = new SqlConnection(cs);

     //   SqlCommand cmd = new SqlCommand();

    //    cmd.Connection = con;

    //    cmd.CommandText = "Select Signuppassword From Signup where Signupusername ='" + txtLoginusername.Text + "'";

     //   con.Open();

    //    SqlDataReader dr = cmd.ExecuteReader();

    //    if (!dr.Read() || dr["Signuppassword"].ToString() != txtpassword.Text)
    //    {
    //        con.Close();
    //        lblSuccess2.Text = "Invalid credentials";
            
   //     }
    //    else
    //    {
    //        con.Close();
        //        lblSuccess2.Text = "Login Successful";
            
   //     }
        
  //  }
    }
}