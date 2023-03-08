<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Registration.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title>Welcome !</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
    <script>
    $(document).ready(function() {
        $("#btnLogin").click(function() {
            var username = $("#txtUsername").val();
            var password = $("#txtPassword").val();
            $.ajax({
                type: "POST",
                url: "Login.aspx/Login",
                data: JSON.stringify({username: username, password: password}),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function(response) {
                    if (response.d == "success") {
                        window.location.href = "Additems.aspx";
                    } else {
                        alert("Invalid username or password.");
                    }
                },
                error: function() {
                    alert("Error logging in.");
                }
            });
        });
    });
    </script>
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

    </style>


</head>
<body>
    
<div class="container mt-5">
   <form class="form-signin">
       
    <div class="row">
    <img src="logo.png" alt="Logo" class="mb-4">

        <label for="inputUsername" class="sr-only">Username</label>

        <asp:TextBox ID="inputUsername" runat="server"></asp:TextBox>
<%--<asp:TextBox ID="inputUsername" runat="server" class="form-control mb-3" type="name" placeholder="Username"></asp:TextBox>--%>

<label for="inputPassword" class="sr-only">Password</label>

 <asp:TextBox ID="inputPassword" runat="server" class="form-control mb-3" type="name" placeholder="Password" ></asp:TextBox>

<asp:Button class="btn btn-lg btn-primary btn-block" ID="btn_log" OnClick="btn_login_Click" runat="server" Text="Sign in" />


</div>

</form>

</div>

    
</body>
</html>
