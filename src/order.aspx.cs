using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace TestBuy
{
    public partial class order : System.Web.UI.Page
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

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestshopConnectionString"].ConnectionString);
            conn.Open();
            //SqlCommand pass = new SqlCommand("select product_id, product_name ,priduct_quantity ,priduct_price from order_info where account ='"+Session["username"]+"'", conn);
            SqlCommand pass = new SqlCommand("select product_id AS 訂單編號, product_name AS 商品,priduct_quantity AS 商品數量 ,priduct_price AS 商品價格 from order_info where account ='" + Session["username"] + "'", conn);

            //SqlDataReader sqlDataReader = pass.ExecuteReader();

            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(pass);
            da.Fill(dataTable);

            GridView1.DataSource = dataTable; //告訴GridView資料來源為誰
            GridView1.DataBind();//綁定
            conn.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TestshopConnectionString"].ConnectionString);
            conn.Open();
            //SqlCommand pass = new SqlCommand("select product_id, product_name ,priduct_quantity ,priduct_price from order_info where account ='"+Session["username"]+"'", conn);
            SqlCommand pass = new SqlCommand("select * from order_info ", conn);

            //SqlDataReader sqlDataReader = pass.ExecuteReader();

            DataTable dataTable = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(pass);
            da.Fill(dataTable);
            
            /*
            GridView1.Columns[0].HeaderText = "訂單編號";
            GridView1.Columns[1].HeaderText = "商品";
            GridView1.Columns[2].HeaderText = "商品數量";
            GridView1.Columns[3].HeaderText = "商品價格";
            */
            /*
            GridView1.DataSource = dataTable; //告訴GridView資料來源為誰
            GridView1.DataBind();//綁定
            conn.Close();
            */
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

        protected void pay_Click(object sender, EventArgs e)
        {
            Session["product_name"] = GridView1.Rows[0].Cells[1].Text.Trim();
            Session["product_quantity"] = GridView1.Rows[0].Cells[2].Text.Trim();
            Session["product_price"] = GridView1.Rows[0].Cells[3].Text.Trim();

            int total_price = 0 , product_quantity , product_price;
            product_quantity = Int32.Parse(Session["product_quantity"].ToString());
            product_price =Int32.Parse(Session["product_price"].ToString());
            total_price = product_price * product_quantity;
            Session["total_price"] = total_price;

            Response.Redirect("./ECPay.aspx");
        }
    }
}