<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Warlockbeta.WebForm1"  EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
 
 
  <title>Sign-Up/Login Form</title>
  <link href='https://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">

  
      <link rel="stylesheet" href="css/style.css">

 <%-- <%@ Page ... EnableEventValidation="false" ... %>--%>

</head>
<body>
    <form id="form1" runat="server">
        <div>
             
  <div class="form">
      
      <ul class="tab-group">
        <li class="tab active"><a href="#signup">Sign Up</a></li>
        <li class="tab"><a href="#login">Log In</a></li>
      </ul>
      
      <div class="tab-content">
        <div id="signup">   
          <h1>Sign Up for Free</h1>
          
          <form action="/" method="post">
          
          <div class="top-row">
            <div class="field-wrap">
              <label>
                Nickname<span class="req">*</span>
              </label>
                <asp:TextBox ID="Tb_Nickname" runat="server" type="text"></asp:TextBox>
            </div>
        
            <div class="field-wrap">
              <label>
                Complete Name<span class="req">*</span>
              </label>
              <asp:TextBox ID="Tb_Name" runat="server" type="text"></asp:TextBox>
            </div>
          </div>

          <div class="field-wrap">
            <label>
              Email Address<span class="req">*</span>
            </label>
            <asp:TextBox ID="Tb_Email" runat="server" type="text" OnTextChanged="Tb_Email_TextChanged"></asp:TextBox>
          </div>
          
          <div class="field-wrap">
            <label>
              Set A Password<span class="req">*</span>
            </label>
            <asp:TextBox ID="Tb_Password" runat="server" type="password"></asp:TextBox>
          </div>
          
<%--          <button type="submit" class="button button-block">--%>

              <asp:Button ID="Button1" runat="server" Text="Get Free" OnClick="Button1_Click" />
                        
          </form>

        </div>
        
        <div id="login">   
          <h1>Welcome Back!</h1>
          
          <form action="/" method="post">
          
            <div class="field-wrap">
            <label>
              Nickname<span class="req">*</span>
            </label>
           <asp:TextBox ID="Tb_LNickname" runat="server" type="text"></asp:TextBox>
          </div>
          
          <div class="field-wrap">
            <label>
              Password<span class="req">*</span>
            </label>
             <asp:TextBox ID="Tb_Lpass" runat="server" type="password"></asp:TextBox>
          </div>
          

          
        <%--  <button class="button button-block">--%>
              <asp:Button ID="Bt_Log" runat="server" Text="Log In" OnClick="Bt_Log_Click"/>
          
          </form>

        </div>
        
      </div><!-- tab-content -->
      
</div> <!-- /form -->
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

  

    <script  src="js/index.js"></script>




        </div>
    </form>
</body>
</html>
