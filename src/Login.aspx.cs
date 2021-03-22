using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Configuration;

namespace TestBuy
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }

        protected void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void textBox2_TextChanged(object sender, EventArgs e)
        {
        }


        protected void button1_Click1(object sender, EventArgs e)
        {
            String username, password;

            username = textBox1.Text;
            password = textBox2.Text;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestshopConnectionString"].ConnectionString);
            conn.Open();
            SqlCommand pass = new SqlCommand ("select account , password from Seller where account ='" + username + "'and password ='" + password + "'" ,conn) ;
            SqlDataReader sqlDataReader = pass.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                Session.Add("username" , username);
                Session.Add("password" , password);
                Session.Timeout = 30;
                Response.Redirect("./index.aspx");
                conn.Close();
            }
            else
            {
                Response.Write("<script>alert('" + "帳號密碼有誤!" + "');location.href='./Login.aspx';</script>");
                conn.Close();
            }
        }
    }
}