using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestBuy
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string username = "" ;
            if (Session["username"] == null || string.IsNullOrWhiteSpace(Session["username"].ToString()))
            {
                register.InnerHtml += "<a class='nav-link' href='Register.aspx'> 註冊";
                
                login.InnerHtml += "<a class='nav-link' href='Login.aspx'> 登入";
            }
            else
            {
                register.InnerHtml += "<a class='nav-link' href=#>" + Session["username"] ;
                login.InnerHtml += " <a class='nav-link' href='my-account.aspx'> 後台資訊 ";
            }
        }

    }
}