<%@ Page Language="C#" AutoEventWireup="true" CodeFile="default.aspx.cs" Inherits="login" MasterPageFile="~/LoginMasterPage.master" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 

 <div class="style1">
    
        </div>
       <table align="center" cellspacing="1" style="width: 100%">
   
        <tr>
            <td align="center" style="width: 687px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label 
                    ID="Label1" runat="server" Font-Bold="True" 
                    Font-Names="Monotype Corsiva" Font-Size="Large" ForeColor="#000066" 
                    Text="CANCLUB" 
                    style="font-size: xx-large; font-style: normal; text-align: left"></asp:Label>
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
                <asp:LinkButton ID="LinkButton1" PostBackUrl="login.aspx" runat="server">ADMIN LOGIN</asp:LinkButton>
             
            </td>
            <td class="style5" style="width: 189px">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10">
                &nbsp;<asp:LinkButton ID="LinkButton3" PostBackUrl="~/admin/registration.aspx" runat="server">STUDENT REGISTER</asp:LinkButton>
            </td>
            <td class="style5" style="width: 189px">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style10">
                <asp:LinkButton ID="LinkButton4" PostBackUrl="studentlogin.aspx" runat="server">STUDENT LOGIN</asp:LinkButton>
            </td>
            <td class="style5" style="width: 189px">
                &nbsp;</td>
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
        
 

        
 