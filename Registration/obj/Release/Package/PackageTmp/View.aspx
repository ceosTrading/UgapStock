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
        .rounded {
            top: 0px;
            left: 0px;
        }
        .mydatagrid
{
width: 80%;
border: solid 2px black;
min-width: 80%;
}
.header
{
background-color: #646464;
font-family: Arial;
color: White;
border: none 0px transparent;
height: 25px;
text-align: center;
font-size: 16px;
}

.rows
{
background-color: #fff;
font-family: Arial;
font-size: 14px;
color: #000;
min-height: 25px;
text-align: left;
border: none 0px transparent;
}
.rows:hover
{
background-color: #ff8000;
font-family: Arial;
color: #fff;
text-align: left;
}
.selectedrow
{
background-color: #ff8000;
font-family: Arial;
color: #fff;
font-weight: bold;
text-align: left;
}
.mydatagrid a /** FOR THE PAGING ICONS **/
{
background-color: Transparent;
padding: 5px 5px 5px 5px;
color: #fff;
text-decoration: none;
font-weight: bold;
}

.mydatagrid a:hover /** FOR THE PAGING ICONS HOVER STYLES**/
{
background-color: #000;
color: #fff;
}
.mydatagrid span /** FOR THE PAGING ICONS CURRENT PAGE INDICATOR **/
{
background-color: #c9c9c9;
color: #000;
padding: 5px 5px 5px 5px;
}
.pager
{
background-color: #646464;
font-family: Arial;
color: White;
height: 30px;
text-align: left;
}

.mydatagrid td
{
padding: 5px;
}
.mydatagrid th
{
padding: 5px;
}
    </style>
</head>

<body style="height: 563px; width:100%;">

    <form id="form1" runat="server" class="auto-style1">
        <br>
        <asp:Button ID="btnhome" Text="Home" runat="server" PostBackUrl ="~/WELCOME !!!.aspx" Class="btn btn-info" />
        <asp:Button ID="btnstockin" Text="Stock In" runat="server" PostBackUrl ="~/Additems.aspx" Class="btn btn-success" />
         <asp:Button ID="stockout" Text="Stock Out" runat="server" PostBackUrl ="~/stockout.aspx" Class="btn btn-danger" />
                   
    </br>

        <br>
            <asp:Label ID="Label1" runat="server" Text="Select Month -"></asp:Label>
            </br>
        <br>
        <asp:DropDownList ID="ddl_Month" class="btn btn-info dropdown-toggle" runat="server" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
            <asp:ListItem></asp:ListItem>
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
            <asp:DropDownList ID="ddl_items" runat="server">
        </asp:DropDownList>
        </br>
        
        <br>
                    <asp:Button class="btn btn-warning" ID="btn_view" runat="server" Text="View" Height="38px" Width="141px" CausesValidation="false" OnClick="btn_view_Click1" />
            
        </br>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="236px" Width="100%" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" AllowSorting="True" HorizontalAlign="Center" PageSize="1000" CssClass="mydatagrid">
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

        <%--<FooterStyle BackColor="#FFFFCC" ForeColor="#000000" />
        <HeaderStyle BackColor="#0099FF" Font-Bold="True" ForeColor="Black" />
        <PagerSettings PageButtonCount="100" />
        <PagerStyle ForeColor="#000000" HorizontalAlign="Center" BackColor="#FFFFCC" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#000000" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />--%>
    </asp:GridView>

        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" Height="236px" Width="100%" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" AllowSorting="True" HorizontalAlign="Center" PageSize="1000" CssClass="mydatagrid">
                <Columns>
            <asp:BoundField DataField="date" HeaderText="Date" ItemStyle-Width="100" >
<ItemStyle Width="100px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="item_name" HeaderText="Item Name" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="initial_stock" HeaderText="Initial Stock" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="invoice_number" HeaderText="Invoice Number" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            
           
            
            
         


        </Columns>

        <%--<FooterStyle BackColor="#FFFFCC" ForeColor="#000000" />
        <HeaderStyle BackColor="#0099FF" Font-Bold="True" ForeColor="Black" />
        <PagerSettings PageButtonCount="100" />
        <PagerStyle ForeColor="#000000" HorizontalAlign="Center" BackColor="#FFFFCC" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#000000" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />--%>
    </asp:GridView>
       
        <br />
        </form>
</body>
</html>
