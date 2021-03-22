using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestBuy
{
    public partial class my_account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string username = "" ;
            
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
            
            info.InnerHtml += Session["username"] + " 您好 (不是 " + Session["username"]  + " 嗎？"  + "<a href='index.aspx'>登出" + ")";

            
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
    }
}