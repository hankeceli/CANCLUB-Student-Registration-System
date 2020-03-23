<%@ Page Language="C#" AutoEventWireup="true" CodeFile="feedbackreport.aspx.cs" Inherits="feedbackreport" MasterPageFile="~/admin.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<table width="100%">
    <tr>
        <td align="right" style="width: 64px">
            <strong>Course:</strong><b>&nbsp; </b>
        </td>
        <td align="right" style="width: 130px; text-align: left;">
            <asp:DropDownList ID="ddlCourse" runat="server" AutoPostBack="True" 
                DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="id" 
                onselectedindexchanged="ddlCourse_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:RegistrationConnectionString %>" 
                SelectCommand="Select id,name from Courses"></asp:SqlDataSource>
        </td>
        <td align="left" style="width: 12px; text-align: right;">
            <strong>Semester:</strong></td>
        <td align="left" style="width: 86px">
            <asp:DropDownList ID="ddlSem" runat="server" AutoPostBack="True" 
                onselectedindexchanged="ddlSem_SelectedIndexChanged">
            </asp:DropDownList>
        </td>
        <td align="left" style="width: 73px; text-align: right;">
            <strong>Month:</strong></td>
        <td align="left" style="width: 90px">
            <asp:DropDownList ID="ddlMonth" runat="server" style="font-weight: bold">
                <asp:ListItem Value="1">First</asp:ListItem>
                <asp:ListItem Value="2">Second</asp:ListItem>
                <asp:ListItem Value="3">Third</asp:ListItem>
                <asp:ListItem Value="4">Fourth</asp:ListItem>
                <asp:ListItem Value="5">Fifth</asp:ListItem>
                <asp:ListItem Value="6">Sixth</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td align="left" style="text-align: right">
            <b style="text-align: right">Subject:</b></td>
        <td align="left">
            <asp:DropDownList ID="ddlSubject" runat="server" style="font-weight: bold">
                <asp:ListItem Value="1">First</asp:ListItem>
                <asp:ListItem Value="2">Second</asp:ListItem>
                <asp:ListItem Value="3">Third</asp:ListItem>
                <asp:ListItem Value="4">Fourth</asp:ListItem>
                <asp:ListItem Value="5">Fifth</asp:ListItem>
                <asp:ListItem Value="6">Sixth</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td align="left">
            <asp:Button ID="Button1" runat="server" style="text-align: right" 
                Text="Display" Width="81px" onclick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" style="text-align: right" Text="Clear" 
                Width="81px" />
        </td>
    </tr>
    <tr style="color: #000000">
        <td align="right" style="height: 23px; text-align: center;" colspan="9">
            <asp:Label ID="Label1" runat="server" 
                style="text-align: left; font-weight: 700" Text="The average feedback for "></asp:Label>
            <b style="text-align: center">
&nbsp; 
            <asp:Label ID="Label2" runat="server" 
                style="text-align: center; text-decoration: underline" Text="-------"></asp:Label>
&nbsp; subject is
            <asp:Label ID="Label3" runat="server" style="text-decoration: underline" 
                Text="------"></asp:Label>
&nbsp;which is given by
            <asp:Label ID="Label4" runat="server" style="text-decoration: underline" 
                Text="-------"></asp:Label>
&nbsp;students to their subject teacher
            <asp:Label ID="Label5" runat="server" style="text-decoration: underline" 
                Text="--------."></asp:Label>
            </b>
        </td>
    </tr>
    <tr>
        <td align="right" style="height: 11px;" colspan="2">
            <b>
&nbsp; </b>
        </td>
        <td align="left" style="height: 11px" colspan="7">
            <b></b></td>
    </tr>
    <tr>
        <td align="center" colspan="9" style="height: 26px">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
    </tr>
    <tr>
        <td align="center" colspan="9">
            <asp:GridView ID="GridView1" runat="server" 
                onselectedindexchanged="GridView1_SelectedIndexChanged" 
                style="margin-left: 0px" Width="452px">
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>