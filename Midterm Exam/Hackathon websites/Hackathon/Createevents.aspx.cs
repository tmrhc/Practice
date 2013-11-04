using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Createevents : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnaddevent_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["csGiftfinder"].ConnectionString;

        SqlConnection con = new SqlConnection(cs);
        
        con.Open();
        
        SqlCommand cmd1 = new SqlCommand("Insert into Events(Eventname,Eventaddress,Eventdetails) Values ('" + txteventname.Text +"' , '" + txteventaddress.Text +"', '" + txteventdetails.Text +"' )", con);

        cmd1.ExecuteNonQuery();

        cmd1.Dispose();

        con.Close();

        lblSuccess1.Text = "Events added successfully";

    }
}