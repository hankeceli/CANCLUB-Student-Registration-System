<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" MasterPageFile="~/LoginMasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 

 <div class="style1">
    
        <strong style="text-align: center">ADMIN LOGIN PAGE</strong></div>
       <table align="center" cellspacing="1" style="width: 100%">
   
        <tr>
            <td align="center" style="width: 687px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
                    ID="Label1" runat="server" Font-Bold="True" 
                    Font-Names="Monotype Corsiva" Font-Size="Large" ForeColor="#000066" 
                    Text="CANCLUB " 
                    style="font-size: xx-large; font-style: italic; text-align: left"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
        </tr>
        <tr>
            <td style="height: 21px; width: 687px;">
            </td>
        </tr>
        </table>
    
    <table class="style2" style="height: 202px; width: 607px; margin-right: 56px">
        <tr>
            <td class="style10">
                User Name :
             
            </td>
            <td class="style5" style="width: 189px">
                <asp:TextBox ID="lusername" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style9">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="lusername" ErrorMessage="Please enter User name" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style10">
                Password : </td>
            <td class="style5" style="width: 189px">
                <asp:TextBox ID="lpassword" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            </td>
            <td class="style9">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="lpassword" ErrorMessage="Please enter Password" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style10">
                &nbsp;</td>
            <td class="style5" style="width: 189px">
                <asp:Button ID="Login_Button" runat="server" Height="34px" 
                    onclick="Login_Button_Click" Text="Login" Width="103px" />
            </td>
            <td class="style9">
                 
            </td>
        </tr>
        <tr>
            <td class="style10">
                &nbsp;</td>
            <td class="style5" style="width: 189px">
                &nbsp;</td>
            <td class="style9">
                &nbsp; </td>
        </tr>
    </table>
    </asp:Content>
        
 

        
 