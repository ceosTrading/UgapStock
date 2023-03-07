<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Registration.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
  <title>Bootstrap Example</title>
  <meta charset="utf-8">
  <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css">
  <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
  <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js"></script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
            height: 413px;
        }
        .auto-style3 {
            width: 118px;
        }
        .auto-style5 {
            width: 118px;
            height: 23px;
        }
        .auto-style6 {
            width: 368px;
            height: 23px;
        }
        .auto-style7 {
            width: 118px;
            height: 63px;
        }
        .auto-style8 {
            width: 368px;
            height: 63px;
        }
        .auto-style9 {
            height: 370px;
        }
        .auto-style10 {
            width: 368px
        }
        </style>

</head>
<body>

    <form id="form1" runat="server">

        
        <div class="container">
            <asp:Label ID="Label1" runat="server" Font-Names="Century Gothic" Font-Size="XX-Large" ForeColor="#0066FF" Text="Students Registration"></asp:Label>
            <br />
            <br />
            <table class="table table-dark">
                <tr>
                    <td class="auto-style3">First Name</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox1" runat="server" Width="301px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Last Name</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox2" runat="server" Width="301px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Email</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox3" runat="server" Width="301px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Phone Number</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox4" runat="server" Width="301px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">ID</td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox5" runat="server" Width="301px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8">
                        <asp:Button 
                            ID="btn_add" runat="server" Text="Add Student" Width="132px" OnClick="btn_add_Click" />


                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button 
                            ID="btn_remove" runat="server" OnClick="Button1_Click" Text="Remove Student" Width="132px" />
                        <br />
                        <br />
                        <asp:Button Button class="btn btn-primary" 
                            ID="btn_view" runat="server" OnClick="Button2_Click1" Text="View Data" Width="133px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button Button class="btn btn-primary" 
                            ID="btn_update" runat="server" OnClick="Button3_Click" Text="Update Data" Width="133px" />
                        <br />
                        <br />
                        <asp:Label ID="Label2" runat="server" Font-Size="Large" ForeColor="#FF5050"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

