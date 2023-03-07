<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="WebForm3.aspx.cs" Inherits="Registration.WebForm3" %>
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
  <center><h2>Student Registration</h2></center>
     
    <br>
        <asp:Button class="btn btn-primary" ID="btn_home" runat="server" Text="Home" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/WebForm3.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_viewst" runat="server" Text="View Students" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/WebForm2.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_pay" runat="server" Text="Pay Fees" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/fee.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_his" runat="server" Text="View Payments" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/payments.aspx" />

                   
    </br>
    <div class="auto-style1">
      <label for="Student_id"> Student ID:</label>
      
       
        
        <asp:TextBox ID="txt_id" class="form-control" placeholder="Enter ID" runat="server" AutoPostBack ="True" OnTextChanged="txt_id_TextChanged" Width="1030px"></asp:TextBox>
        
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_id" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        
    
        <br />
        <label for="first_name">
        Full Name</label>
        <asp:TextBox ID="txt_firstname" class="form-control" input type="name" placeholder="Enter Full Name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txt_firstname" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <label for="last_name">
        Date of Birth</label>
        <asp:TextBox ID="txt_lastname" class="form-control" input type="date" placeholder="Enter Birth Day" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txt_lastname" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <span class="auto-style3">School</span><label for="email">:</label>
        <asp:TextBox ID="txt_email" class="form-control" input type="name" placeholder="Enter School" runat="server"></asp:TextBox>
        
        <br />
        <label for="Phone_number">
        Age:</label>
        <asp:TextBox ID="txt_phonenum" class="form-control" input type="number" placeholder="Enter Age" runat="server" MaxLength="2"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txt_phonenum" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />








        <label for="gender">
        Gender:</label>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem Value="MALE">Male</asp:ListItem>
            <asp:ListItem Value="FEMALE">Female</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="RadioButtonList1" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />


        <label for="address">
        Address:</label>
        <asp:TextBox ID="txt_address" class="form-control" input type="name" placeholder="Enter Address" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txt_address" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

         <label for="contactno">
        Contact No:</label>
        <asp:TextBox ID="txt_contact" class="form-control" input type="number" placeholder="Enter Contact" runat="server" MaxLength="10"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txt_contact" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

         <label for="parent">
       Parent Name:</label>
        <asp:TextBox ID="txt_parent" class="form-control" input type="name" placeholder="Enter Parent Name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txt_parent" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

         <label for="emergency_name">
       Emergency Contact Name:</label>
        <asp:TextBox ID="txt_emename" class="form-control" input type="name" placeholder="Enter Name" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txt_emename" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

          <label for="emergency">
       Emergency Contact:</label>
        <asp:TextBox ID="txt_emeCon" class="form-control" input type="number" placeholder="Enter Number" runat="server" MaxLength="10"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txt_emeCon" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

         <label for="email">
       Email:</label>
        <asp:TextBox ID="txt_mail" class="form-control" input type="name" placeholder="Enter Email" runat="server"></asp:TextBox>
        <br />

          <label for="payment">
       Payment Method:</label>
        <asp:RadioButtonList ID="RadioButtonList2" runat="server" RepeatDirection="Horizontal">
            <asp:ListItem>Cash</asp:ListItem>
            <asp:ListItem>Card</asp:ListItem>
        </asp:RadioButtonList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="RadioButtonList2" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        
    
    </div>
    <br />



    <asp:Button class="btn btn-primary" ID="btn_submit" runat="server" Text="Submit Data" Height="38px" Width="141px" OnClick="btn_submit_Click" />
    &nbsp;&nbsp;&nbsp;



    <asp:Button class="btn btn-primary" ID="btn_edit" runat="server" Text="Update Data" Height="38px" Width="141px" OnClick="btn_edit_Click" />
    &nbsp;&nbsp;&nbsp;



    <asp:Button class="btn btn-primary" ID="btn_view" runat="server" Text="View Data" Height="38px" Width="141px" OnClick="btn_view_Click" CausesValidation="false" />
    &nbsp;&nbsp;&nbsp;



    <asp:Button class="btn btn-danger" ID="btn_delete" runat="server" Text="Delete Data" Height="38px" Width="141px" OnClick="btn_delete_Click"  OnClientClick="return confirm('Are you sure?')" />
        &nbsp;&nbsp;&nbsp;

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Names="Calibri" Font-Size="Large" ForeColor="#FF6600"></asp:Label>
    </form>



</body>
</html>
