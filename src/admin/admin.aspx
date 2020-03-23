<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin" MasterPageFile="~/admin.master" %>


    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
        <asp:SqlDataSource ID="SqlDataSourceRegistration" runat="server" 
            ConnectionString="<%$ ConnectionStrings:RegistrationConnectionString %>" 
            SelectCommand="Select Students.name,Students.email,Students.password,Courses.name,Students.contactno,Students.doj From Students, Courses
WHERE Students.course_id=Courses.id"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AllowSorting="True" CellPadding="4" 
            DataSourceID="SqlDataSourceRegistration" ForeColor="#333333" 
            GridLines="None" Height="383px" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" 
    Width="904px" AutoGenerateColumns="False" BorderStyle="None" 
    style="margin-left: 0px" >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="name" HeaderText="Student Name" 
                    SortExpression="name" />
                <asp:BoundField DataField="email" HeaderText="E-mail" SortExpression="email" />
                <asp:BoundField DataField="password" HeaderText="Password" 
                    SortExpression="password" />
                <asp:BoundField DataField="name1" HeaderText="Course" 
                    SortExpression="name1" />
                <asp:BoundField DataField="contactno" HeaderText="ContactNumber" 
                    SortExpression="contactno" />
                <asp:BoundField DataField="doj" HeaderText="Date of Birth" 
                    SortExpression="doj" DataFormatString="{0:dd/MM/yyyy}" />
            </Columns>
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <SortedAscendingCellStyle BackColor="#FDF5AC" />
            <SortedAscendingHeaderStyle BackColor="#4D0000" />
            <SortedDescendingCellStyle BackColor="#FCF6C0" />
            <SortedDescendingHeaderStyle BackColor="#820000" />
        </asp:GridView>
        <%--<asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Delete" />--%>
        <asp:Button ID="Back" runat="server" onclick="Back_Click" Text="Back" />
    
    </asp:Content>
