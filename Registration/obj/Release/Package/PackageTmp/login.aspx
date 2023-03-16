<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Registration.login" %>

<!DOCTYPE html>

<script type="text/javascript" src='https://ajax.aspnetcdn.com/ajax/jQuery/jquery-1.8.3.min.js'></script>
<script type="text/javascript" src='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/js/bootstrap.min.js'></script>
<link rel="stylesheet" href='https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/3.0.3/css/bootstrap.min.css' media="screen" />
<style type="text/css">
        .form-signin {
    max-width: 330px;
    padding: 15px;
    margin: 0 auto;
}

.form-signin input[type="text"],
.form-signin input[type="password"] {
    font-size: 16px;
    height: auto;
    padding: 10px;
}

.form-signin button {
    margin-top: 20px;
}

.form-signin label {
    font-size: 14px;
}

.logo {
  text-align: center;
}

    </style>

<form id="form1" class="form-signin" runat="server">
    <div class ="logo">

            <img src="logo1.png" alt="Logo" class="mb-4">

        </div>
<div class="container mt-5">
    <h2 class="form-signin-heading">
        Login</h2>
    <label for="txtUsername">
        Username</label>
    <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter Username"
        required Width="500px" />
    <br />
    <label for="txtPassword">
        Password</label>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"
        placeholder="Enter Password" required Width="500px" />
    <div class="checkbox">
        <asp:CheckBox ID="chkRememberMe" Text="Remember Me" runat="server" />
    </div>
    <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="ValidateUser" Class="btn btn-primary" />
    <br>
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
</br>
    <br />
    <br />
    
</div>
</form>