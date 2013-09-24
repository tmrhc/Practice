using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(op1.Text);
        int b = Convert.ToInt32(op2.Text);
        ServiceReference1.CalculatorserviceSoapClient p = new ServiceReference1.CalculatorserviceSoapClient();
        int result= p.Addition(a, b);
        op3.Text = result.ToString();

            }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(op1.Text);
        int b = Convert.ToInt32(op2.Text);
        ServiceReference1.CalculatorserviceSoapClient p = new ServiceReference1.CalculatorserviceSoapClient();
        int result = p.Subtraction(a, b);
        op3.Text = result.ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {

        int a = Convert.ToInt32(op1.Text);
        int b = Convert.ToInt32(op2.Text);
        ServiceReference1.CalculatorserviceSoapClient p = new ServiceReference1.CalculatorserviceSoapClient();
        int result = p.Multiplication(a, b);
        op3.Text = result.ToString();
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        int a = Convert.ToInt32(op1.Text);
        int b = Convert.ToInt32(op2.Text);
        ServiceReference1.CalculatorserviceSoapClient p = new ServiceReference1.CalculatorserviceSoapClient();
        int result = p.Division(a, b);
        op3.Text = result.ToString();
    }
}