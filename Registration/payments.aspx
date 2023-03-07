<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="payments.aspx.cs" Inherits="Registration.payments" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br>
        <asp:Button class="btn btn-primary" ID="btn_home" runat="server" Text="Home" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/WebForm3.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_viewst" runat="server" Text="View Students" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/WebForm2.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_pay" runat="server" Text="Pay Fees" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/fee.aspx" />
        <asp:Button class="btn btn-primary" ID="btn_his" runat="server" Text="View Payments" Height="38px" Width="141px" CausesValidation="false" PostBackUrl ="~/payments.aspx" />

                   
    </br>

    <br>
    <asp:TextBox ID="txt_id" class="form-control" placeholder="Enter ID" runat="server" AutoPostBack ="True" Width="1030px"></asp:TextBox>
        
    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txt_id" Display="Dynamic" ErrorMessage="Required" ForeColor="Red"></asp:RequiredFieldValidator>
        
    </br>

    <br>
    <asp:Button class="btn btn-success" ID="btn_submit" runat="server" Text="View" Height="38px" Width="141px" OnClick="btn_submit_Click" />
    </br>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="236px" Width="100%" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowSorting="True" HorizontalAlign="Center" PageSize="1000" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="MEMBERSHIP_NO" HeaderText="ID" ItemStyle-Width="150" >
<ItemStyle Width="150px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField HeaderText="January" DataField="JAN" ItemStyle-Width="150" >
            </asp:BoundField>
            <asp:BoundField HeaderText="February" DataField="FEB" ItemStyle-Width="150" >
            </asp:BoundField>
            <asp:BoundField HeaderText="March" DataField="MAR" ItemStyle-Width="150" >
            </asp:BoundField>
            <asp:BoundField HeaderText="April" DataField="APR" ItemStyle-Width="150" >
            </asp:BoundField>
            
            
         


            <asp:BoundField HeaderText="May"  DataField="MAY" ItemStyle-Width="150" />
            <asp:BoundField HeaderText="June" DataField="JUN" ItemStyle-Width="150" />
            <asp:BoundField HeaderText="July" DataField="JULY" ItemStyle-Width="150" />
            <asp:BoundField HeaderText="August" DataField="AUG" ItemStyle-Width="150" />
            <asp:BoundField HeaderText="September" DataField="SEP" ItemStyle-Width="150" />
            <asp:BoundField HeaderText="Octomber" DataField="OCT" ItemStyle-Width="150" />
            <asp:BoundField HeaderText="November" DataField="NOV" ItemStyle-Width="150" />                   
            <asp:BoundField HeaderText="December" DataField="DECEM" ItemStyle-Width="150" />
            
            
         


        </Columns>
        <EditRowStyle BackColor="#2461BF" />
        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <PagerSettings PageButtonCount="100" />
        <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
        <RowStyle BackColor="#EFF3FB" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F5F7FB" />
        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
        <SortedDescendingCellStyle BackColor="#E9EBEF" />
        <SortedDescendingHeaderStyle BackColor="#4870BE" />
    </asp:GridView>
</asp:Content>
