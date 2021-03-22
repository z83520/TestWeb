<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TestBuy.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
  <meta name="description" content=""/>
  <meta name="author" content=""/>

  <title>Shop Homepage - Start Bootstrap Template</title>

      <!-- Bootstrap core CSS -->
  <link href="vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet"/>

  <!-- Custom styles for this template -->
  <link href="css/shop-homepage.css" rel="stylesheet"/>

</head>
<body>
    <form id="form1" runat="server" method="get">
        <!-- Navigation -->
  <nav class="navbar navbar-expand-lg navbar-dark bg-dark fixed-top">
    <div class="container">
      <a class="navbar-brand" href="index.aspx">購物商城</a>
      <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarResponsive">
        <ul class="navbar-nav ml-auto">
          <li class="nav-item">
            <a class="nav-link" href="Register.aspx">註冊</a>
          </li>
          <li class="nav-item">
            <a class="nav-link" href="Login.aspx">登入</a>
          </li>
        </ul>
      </div>
    </div>
  </nav>

         <!-- Page Content -->
        
  <div class="container">
      <h3>登入資訊</h3>
      <div>帳號</div>
        <asp:TextBox id="textBox1" runat="server" AutoPostBack="False"  ></asp:TextBox>
      <div>密碼</div>
              <asp:TextBox id="textBox2" runat="server" AutoPostBack="False"> </asp:TextBox>
      <div> </div>
      <asp:Button id="button1" runat="server" Text="確認" OnClick="button1_Click1" > </asp:Button>
      <div> </div>
      <div>--------------- 或 --------------- </div>
      <a href="#"><img src="/image/google.jpg" alt="" height="40" width="165"/></a>
      </div>
          <!-- /.container -->
    </form>

     <!-- Footer -->
  <footer class="py-5 bg-dark">
    <div class="container">
      <p class="m-0 text-center text-white">Copyright &copy; Your Website 2020</p>
    </div>
    <!-- /.container -->
  </footer>

  <!-- Bootstrap core JavaScript -->
  <script src="vendor/jquery/jquery.min.js"></script>
  <script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

</body>
</html>
