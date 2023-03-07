<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Registration.WebForm2" %>
<!DOCTYPE html>
<html lang="en">
<head>
  <title>Edit Data</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>

<head>
    <style type="text/css">
        .auto-style1 {
            height: 559px;
            width: 1531px;
        }
        .auto-style2 {
            height: 42px;
        }
        .auto-style4 {
            width: 100%;
            height: 326px;
        }
        .auto-style7 {
            width: 657px;
            height: 42px;
        }
        .auto-style8 {
            width: 657px;
            height: 43px;
        }
        .auto-style9 {
            height: 43px;
        }
    </style>
</head>

<body style="height: 563px; width:100%;">

    <form id="form1" runat="server" class="auto-style1">
         
        <br>
        <asp:Button class="btn btn-primary" ID="btn_home" runat="server" Text="Home" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/WebForm3.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_viewst" runat="server" Text="View Students" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/WebForm2.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_pay" runat="server" Text="Pay Fees" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/fee.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_his" runat="server" Text="View Payments" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/payments.aspx" />

                   
    </br>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="236px" Width="100%" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" AllowSorting="True" HorizontalAlign="Center" PageSize="1000">
        <Columns>
            <asp:BoundField DataField="MEMBERSHIP_NO" HeaderText="ID" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="NAME" HeaderText="Full Name" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="DOB" HeaderText="Date Of Birth" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="SCHOOL" HeaderText="School" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="AGE" HeaderText="Age" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            
            
         


            <asp:BoundField DataField="GENDER" HeaderText="Gender" />
            <asp:BoundField DataField="ADDRESS" HeaderText="Address" />
            <asp:BoundField DataField="CONTACT_NO" HeaderText="Contact Number" />
            <asp:BoundField DataField="PARENT_NAME" HeaderText="Parent Name" />
            <asp:BoundField DataField="EMERGENCY_CONTACT" HeaderText="Emergency Contact" />
            <asp:BoundField DataField="GMAIL" HeaderText="Email" />
            <asp:BoundField DataField="PAYMENT_METHOD" HeaderText="Payment Method" />
            
            
         


            <asp:HyperLinkField HeaderText="Last Fees Payment" NavigateUrl="~/payments.aspx" Text="View" />
            
            
         


        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#000000" />
        <HeaderStyle BackColor="#0099FF" Font-Bold="True" ForeColor="Black" />
        <PagerSettings PageButtonCount="100" />
        <PagerStyle ForeColor="#000000" HorizontalAlign="Center" BackColor="#FFFFCC" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#000000" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
       
        <br />
        </form>
</body>
</html>
