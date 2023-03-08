<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="Registration.WebForm2" %>
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
        <asp:Button class="btn btn-primary" ID="btn_viewst" runat="server" Text="View Data" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/WebForm2.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_his" runat="server" Text="View Payments" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/payments.aspx" />

                   
    </br>
        <br>
            <asp:Label ID="Label1" runat="server" Text="Select Month -"></asp:Label>
            </br>
        <br>
        <asp:DropDownList ID="ddl_Month" runat="server">
            <asp:ListItem Value="1">January</asp:ListItem>
            <asp:ListItem Value="2">February</asp:ListItem>
            <asp:ListItem Value="3">March</asp:ListItem>
            <asp:ListItem Value="4">April</asp:ListItem>
            <asp:ListItem Value="5">May</asp:ListItem>
            <asp:ListItem Value="6">June</asp:ListItem>
            <asp:ListItem Value="7">July</asp:ListItem>
            <asp:ListItem Value="8">August</asp:ListItem>
            <asp:ListItem Value="9">September</asp:ListItem>
            <asp:ListItem Value="10">Octomber</asp:ListItem>
            <asp:ListItem Value="11">November</asp:ListItem>
            <asp:ListItem Value="12">December</asp:ListItem>
        </asp:DropDownList>
        </br>
        <br>
            <asp:DropDownList ID="ddl_items" runat="server"></asp:DropDownList>
        </br>

        <br>
                    <asp:Button class="btn btn-warning" ID="btn_view" runat="server" Text="View" Height="38px" Width="141px" CausesValidation="false" OnClick="btn_view_Click1" />

        </br>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="236px" Width="100%" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" AllowSorting="True" HorizontalAlign="Center" PageSize="1000">
                <Columns>
            <asp:BoundField DataField="date" HeaderText="Date" ItemStyle-Width="100" >
<ItemStyle Width="100px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="item_name" HeaderText="Item Name" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="company_name" HeaderText="Company Name" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="brand_name" HeaderText="Brand Name" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="quantity" HeaderText="Quantity" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="initial_stock" HeaderText="Initial Stock" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="invoice_number" HeaderText="Invoice Number" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            
           
            
            
         


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
