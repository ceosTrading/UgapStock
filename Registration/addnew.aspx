<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addnew.aspx.cs" Inherits="Registration.addnew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="auto-style2">
  <center><h2>Add New Products</h2></center>
     
    <br>
        <asp:Button class="btn btn-info" ID="btn_home" runat="server" Text="Home" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/WELCOME !!!.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_viewst" runat="server" Text="View Items" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/View.aspx" OnClick="btn_viewst_Click" />
        <asp:Button class="btn btn-success" ID="btn_in" runat="server" Text="Stock In" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/Additems.aspx" />
         <asp:Button class="btn btn-danger" ID="stockout" runat="server" Text="Stock Out" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/stockout.aspx" />

    </br>
                <div class="auto-style1">
      <label for="Student_id"> Product:</label>
      
       
        <br>
        <asp:DropDownList ID="ddl_products" runat="server"></asp:DropDownList>
    </br>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddl_products" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        
    
        <br />
        <label for="comp_Name">
        Company Name</label>
        <asp:TextBox ID="txt_prodname" class="form-control" input type="name" placeholder="Enter Product Name" runat="server"></asp:TextBox>
        <br />
        </div>
        </div>
    </form>
</body>
</html>
