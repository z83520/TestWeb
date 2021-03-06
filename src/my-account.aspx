<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="my-account.aspx.cs" Inherits="TestBuy.my_account" %>

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
            <a id="register" runat="server"></a>
          </li>
          <li class="nav-item">
           <a id="login" runat="server" ></a>
          </li>
        </ul>
      </div>
    </div>
  </nav>

                <!-- Page Content -->
  <div class="container">

    <div class="row">

      <div class="col-lg-3">

        <h1 class="my-4" id="name" runat="server"></h1>
        <div class="list-group">
            <asp:LinkButton class="list-group-item" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">個人資料</asp:LinkButton>
            <asp:LinkButton class="list-group-item" ID="Information" runat="server" OnClick="Information_Click">密碼修改</asp:LinkButton>
            <asp:LinkButton class="list-group-item" ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">訂單</asp:LinkButton>
            <asp:LinkButton class="list-group-item" ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">登出</asp:LinkButton>
        </div>

      </div>

       <!-- /.col-lg-3 -->

      <div class="col-lg-9">

        <div id="carouselExampleIndicators" class="carousel slide my-4" data-ride="carousel">

          <div class="carousel-inner" role="listbox">
                
                <span runat="server" id="info"></span>
          </div>
            <div class="carousel-inner" role="listbox">

<%--                <div>密碼</div>   
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <div>信箱</div>   
                     <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <div>更改密碼</div>
                     <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <div>登出</div>
                <asp:Button ID="Button2" runat="server" Text="Button" /> --%>

                </div>
        </div>


      </div>
      <!-- /.col-lg-9 -->

    </div>
    <!-- /.row -->

 </div>
  <!-- /.container -->

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


    </form>
      </body>
</html>