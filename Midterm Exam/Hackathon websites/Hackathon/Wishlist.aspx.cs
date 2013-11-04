using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Wishlist : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnadditem_Click(object sender, EventArgs e)
    {
        string cs = ConfigurationManager.ConnectionStrings["csGiftfinder"].ConnectionString;

        SqlConnection con = new SqlConnection(cs);

        con.Open();

        SqlCommand cmd1 = new SqlCommand("Insert into wishlist(Wishlistitem) Values ('" + txtwishlist.Text + "')", con);

        cmd1.ExecuteNonQuery();

        cmd1.Dispose();

        con.Close();

        lblSuccess3.Text = "Wish List Added";
    }
}