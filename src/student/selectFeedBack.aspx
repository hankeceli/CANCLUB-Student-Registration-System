<%@ Page Language="C#" AutoEventWireup="true" CodeFile="selectFeedBack.aspx.cs" Inherits="student_chngpwd" MasterPageFile="~/StudentMasterPage.master" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <b>&nbsp;</b><table width="100%">
        <tr>
            <td align="right" style="text-align: center; height: 23px;" colspan="3">
                <b>Select Semester&nbsp; </b></td>
        </tr>
        <tr style="color: #000000">
            <td align="right" style="width: 469px">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    style="margin-left: 0px" Text="First" Width="116px" />
                <b>
&nbsp; </b></td>
            <td align="right" style="width: 64px" class="style20">
                &nbsp;</td>
            <td align="left">
                <asp:Button ID="Button7" runat="server" onclick="Button7_Click" 
                    style="margin-left: 0px" Text="Second" Width="116px" />
            </td>
        </tr>
        <tr>
            <td align="right" style="height: 11px;">
                <asp:Button ID="Button10" runat="server" onclick="Button3_Click" 
                    style="margin-left: 0px" Text="Third" Width="116px" />
            </td>
            <td align="right" style="height: 11px;">
                &nbsp;</td>
            <td align="left" style="height: 11px">
                &nbsp;<asp:Button ID="Button8" runat="server" onclick="Button4_Click" 
                    style="margin-left: 0px" Text="Fourth" Width="116px" />
            </td>
        </tr>
        <tr>
            <td align="center" style="height: 26px; text-align: right;">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button11" runat="server" onclick="Button5_Click" 
                    style="margin-left: 0px" Text="Fifth" Width="116px" />
            </td>
            <td align="center" style="height: 26px; text-align: right;">
                &nbsp;</td>
            <td align="center" style="height: 26px; text-align: left;">
                <asp:Button ID="Button9" runat="server" onclick="Button6_Click" 
                    style="margin-left: 0px" Text="Sixth" Width="116px" />
            </td>
        </tr>
        <tr>
            <td align="center" colspan="3">
            </td>
        </tr>
    </table>
     </asp:Content>


