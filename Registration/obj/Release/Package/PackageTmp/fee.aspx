<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="fee.aspx.cs" Inherits="Registration.fee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br>
        <asp:Button class="btn btn-primary" ID="btn_home" runat="server" Text="Home" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/WebForm3.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_viewst" runat="server" Text="View Students" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/WebForm2.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_pay" runat="server" Text="Pay Fees" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/fee.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_his" runat="server" Text="View Payments" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/payments.aspx" />

                   
    </br>
    <asp:TextBox ID="txt_id" class="form-control" placeholder="Enter ID" runat="server" AutoPostBack ="True" OnTextChanged ="txt_id_TextChanged" Width="1030px"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txt_id" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        <br> 
        Select Month
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="">SELECT MONTH</asp:ListItem>
            <asp:ListItem Value="JAN">January</asp:ListItem>
            <asp:ListItem Value="FEB">February</asp:ListItem>
            <asp:ListItem Value="MAR">March</asp:ListItem>
            <asp:ListItem Value="APR">April</asp:ListItem>
            <asp:ListItem Value="MAY">May</asp:ListItem>
            <asp:ListItem Value="JUN">June</asp:ListItem>
            <asp:ListItem Value="JULY">July</asp:ListItem>
            <asp:ListItem Value="AUG">August</asp:ListItem>
            <asp:ListItem Value="SEP">September</asp:ListItem>
            <asp:ListItem Value="OCT">Octomber</asp:ListItem>
            <asp:ListItem Value="NOV">November</asp:ListItem>
            <asp:ListItem Value="DECEM">December</asp:ListItem>
    </asp:DropDownList>
                       <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="DropDownList1" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>

    </br>
    <br>
    <asp:Button class="btn btn-success" ID="btn_submit" runat="server" Text="Paid" Height="38px" Width="141px" OnClick="btn_submit_Click" />
    </br>

    <br>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" ForeColor="#CC0000"></asp:Label>
        <br>
        <asp:Label ID="Label2" runat="server" Font-Size="X-Large" ForeColor="#000066"></asp:Label>
            </br>
    </br>







</asp:Content>
