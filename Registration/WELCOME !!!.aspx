<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WELCOME !!!.aspx.cs" Inherits="Registration.WELCOME____" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" rel="stylesheet" />
</head>
<body id="bodyID" runat="server">
    <form id="form1" runat="server">
        <div class="container text-center">
            <h1 class="display-3">Welcome</h1>
                <asp:Button ID="btnstockin" Text="Stock In" runat="server" OnClick="ValidateUser" Class="btn btn-success" />
                &nbsp;&nbsp;&nbsp;
                <asp:Button ID="stockout" Text="Stock Out" runat="server" OnClick="ValidateUser1" Class="btn btn-danger" />
            &nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnview" Text="View Stock" runat="server" OnClick="ValidateUser2" Class="btn btn-info" />
        </div>
    </form>
</body>
</html>
