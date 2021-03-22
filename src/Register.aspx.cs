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
    public partial class Register : System.Web.UI.Page
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

        protected void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        protected void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        protected void button1_Click(object sender, EventArgs e)
        {
            String username, password, repassword, email;

            username = textBox1.Text;
            password = textBox2.Text;
            repassword = textBox3.Text;
            email = textBox4.Text;

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestshopConnectionString"].ConnectionString);
            conn.Open();
            SqlCommand pass = new SqlCommand("select account from Seller where account = '" + username + "'", conn);
            SqlDataReader sqlDataReader = pass.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                Response.Write("<script>alert('" + "已註冊!" + "');location.href='./Register.aspx';</script>");
            }
            else
            {
                conn.Close();
                conn.Open();
                SqlCommand ins = new SqlCommand("INSERT INTO Seller (account , password ,email) VALUES ( '" + username + " ',' " + password + " ',' " + email + "') ", conn);
                ins.ExecuteNonQuery();
                conn.Close();
                Response.Write("<script>alert('" + "註冊成功!" + "');location.href='./Login.aspx';</script>");
                conn.Close();
            }

            /* SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestshopConnectionString"].ConnectionString);
             conn.Open();
             SqlCommand ins = new SqlCommand("INSERT INTO Seller (account , password ,email) VALUES ( '" + username + " ',' " + password + " ',' " + email + "') ", conn);
             ins.ExecuteNonQuery();
             */

            /*SqlCommand cmd = new SqlCommand("select * FROM  Seller ", conn);
            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dataTable);
            GridView1.DataSource = dataTable; //告訴GridView資料來源為誰
            GridView1.DataBind();//綁定
            *
            */

        }
    }
}