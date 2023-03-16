<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stockout.aspx.cs" Inherits="Registration.stockout" %>

<!DOCTYPE html>
<html lang="en">
<head>

  <title>Welcome !</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

    <style type="text/css">
        .auto-style1 {
            margin-bottom: 15px;
            width: 1030px;
        }
        .auto-style2 {
            width: 1170px;
            height: 575px;
            margin-left: auto;
            margin-right: auto;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style3 {
            font-weight: bold;
        }
    </style>
</head>
<body style="height: 620px; width: 1258px;">

    <form id="form1"  runat="server">

<div class="auto-style2">
  <center><h2>Stock Out</h2></center>
     
    <br>
        <asp:Button class="btn btn-info" ID="btn_home" runat="server" Text="Home" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/WELCOME !!!.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_viewst" runat="server" Text="View Items" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/View.aspx" OnClick="btn_viewst_Click" />
        <asp:Button class="btn btn-success" ID="btn_in" runat="server" Text="Stock In" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/Additems.aspx" />
                   
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
        <asp:TextBox ID="txt_compName" class="form-control" input type="name" placeholder="Enter Company" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox1" class="form-control" input type="number" Visible ="false" runat="server"></asp:TextBox>

        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_compName" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <label for="brand_name">
        Brand Name</label>
        <asp:TextBox ID="txt_brandName" class="form-control" input type="name" placeholder="Enter Brand Name" runat="server"></asp:TextBox>
        
        <br />
        <span class="auto-style3">Invoice Number</span><label for="inv_Num">:</label>
        <asp:TextBox ID="txt_invNum" class="form-control" input type="number" placeholder="Enter Invoice Number" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_invNum" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <label for="quantity">
        Quantity:</label>
        <asp:TextBox ID="txt_quantity" class="form-control" input type="number" placeholder="Enter Quantity" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_quantity" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />








       
        
    
    </div>
    <br />



    <asp:Button class="btn btn-danger" ID="btn_submit" runat="server" Text="Out Items From Stock" Height="38px" Width="170px" OnClick="btn_submit_Click" />
    &nbsp;&nbsp;&nbsp;



   



    



    
        &nbsp;&nbsp;&nbsp;

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="lbl_message" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Large" ForeColor="#FF6600"></asp:Label>
    </form>



</body>
</html>

