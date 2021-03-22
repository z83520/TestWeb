using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace TestBuy
{
    public partial class account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null || string.IsNullOrWhiteSpace(Session["username"].ToString()))
            {
                Response.Redirect("./index.aspx");
                register.InnerHtml += "<a class='nav-link' href='Register.aspx'> 註冊";

                login.InnerHtml += "<a class='nav-link' href='Login.aspx'> 登入";
            }
            else
            {
                register.InnerHtml += "<a class='nav-link' href=#>" + Session["username"];
                login.InnerHtml += " <a class='nav-link' href='my-account.aspx'> 後台資訊 ";
            }
            name.InnerHtml += Session["username"];

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("./my-account.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("./order.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("./index.aspx");
        }
        protected void Information_Click(object sender, EventArgs e)
        {
            Response.Redirect("./account.aspx");
        }

        protected void password_TextChanged(object sender, EventArgs e)
        {

        }

        protected void newpassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void ch_newpassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void mail_TextChanged(object sender, EventArgs e)
        {

        }
        protected void Button1_Click1(object sender, EventArgs e)
        {
            if(password.Text == Session["password"].ToString())
            {
                if(newpassword.Text == ch_newpassword.Text)
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestshopConnectionString"].ConnectionString);
                    conn.Open();
                    SqlCommand update = new SqlCommand("update seller set password='"+newpassword.Text+"'where account='"+Session["username"] +"'", conn);
                    update.ExecuteReader();
                    conn.Close();
                    Response.Write("<script>alert('"+"密碼修改成功，請重新登入!"+ "');location.href='./Login.aspx';</script>");
                    Session.Abandon();
                }
                else
                {
                    Response.Write("<script>alert('" + "資料有誤請輸入正確資料!" + "');location.href='./account.aspx';</script>");

                }
            }
            else
            {
                Response.Write("<script>alert('" + "資料有誤請輸入正確資料!" + "');location.href='./account.aspx';</script>");

            }
        }
    }
}