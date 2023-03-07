<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Registration.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" Height="262px" Width="578px">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:studentdbConnectionString %>" ProviderName="<%$ ConnectionStrings:studentdbConnectionString.ProviderName %>" SelectCommand="SELECT [first_name], [last_name], [email], [phone_number], [studentid] FROM [student]"></asp:SqlDataSource>
    </form>
</body>
</html>
