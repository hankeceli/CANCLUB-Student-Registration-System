<%@ Page Language="C#" AutoEventWireup="true" CodeFile="subject.aspx.cs" Inherits="coordinator_subject" MasterPageFile="~/coordinatorMasterPage.master"%>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div style="width:100%; text-align: center; height: 287px;"  >
       
            <table 
                align="center">
                <tr>
                    <td colspan="4" style="height: 2px" align="center">
                        &nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td align="right" style="height: 27px; " colspan="4">
                        <table style="width: 100%">
                            <tr>
                                <td align="right" style="width: 254px">
                        <asp:Label ID="Label57" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Course Name :"></asp:Label>
                                </td>
                                <td align="left" style="width: 350px">
                        <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" 
                            Font-Bold="True" ForeColor="Black" Height="24px" RepeatDirection="Horizontal" 
                            Width="422px" onselectedindexchanged="RadioButtonList2_SelectedIndexChanged">
                            <asp:ListItem Value="1">CENG 382 Web Development</asp:ListItem>
                            <asp:ListItem Value="2">CENG 328 Operating Systems</asp:ListItem>
                            <asp:ListItem Value="3">CENG 356 Database Management Systems</asp:ListItem>
                            <asp:ListItem Value="4">CENG 396 Software Engineering</asp:ListItem>
                        </asp:RadioButtonList>
                                </td>
                                <td align="left">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator33" runat="server" 
                            ControlToValidate="RadioButtonList2" ErrorMessage="Select Course Name" 
                            Font-Bold="True" Font-Size="Small" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 254px">
                                    &nbsp;</td>
                                <td align="left" style="width: 350px">
                                    &nbsp;</td>
                                <td align="left">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="height: 27px; width: 692px;">
                        <asp:Label ID="Label49" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Branch Name :"></asp:Label>
                    </td>
                    <td align="left" style="height: 27px; width: 681px;">
                        <asp:DropDownList ID="DDLBName" runat="server" AutoPostBack="True" 
                            Height="20px" Width="92px" >
                           <%-- onselectedindexchanged="DDLBName_SelectedIndexChanged">--%>
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Computer Science(BSc)</asp:ListItem>
                            <asp:ListItem>Computer Science(MSc)</asp:ListItem>
                            <asp:ListItem>Software Engineering (BSc)&amp;</asp:ListItem>
                            <asp:ListItem>Software Engineering(MSc)</asp:ListItem>
                        </asp:DropDownList>
                    &nbsp;<asp:Label ID="lblBranch" runat="server" Font-Bold="True"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" 
                            ControlToValidate="DDLBName" ErrorMessage="Select Branch Name" 
                            Font-Bold="True" Font-Size="Small" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td align="right" style="height: 27px; width: 214px;">
                        <asp:Label ID="Label59" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Core Subject :"></asp:Label>
                    </td>
                    <td align="left" style="height: 27px; width: 612px;">
                        <asp:DropDownList ID="DDLSem0" runat="server" AutoPostBack="True" 
                            Width="69px" style="margin-left: 2px" Height="20px">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Hard Core(HC)</asp:ListItem>
                            <asp:ListItem>Soft Core(SC)</asp:ListItem>
                            <asp:ListItem>Elective(EL)</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator35" runat="server" 
                            ControlToValidate="DDLSem0" ErrorMessage="Enter core subject" 
                            Display="Dynamic" Font-Bold="True" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="height: 27px; width: 692px;">
                        <asp:Label ID="Label51" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Year :"></asp:Label>
                    </td>
                    <td align="left" style="height: 27px; width: 681px;">
                        <asp:DropDownList ID="DDLYear" runat="server" AutoPostBack="True" Height="20px" style="margin-left: 2px" 
                            Width="92px">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                        </asp:DropDownList>
                     &nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" 
                            ControlToValidate="DDLYear" ErrorMessage="Select Year" 
                            Font-Bold="True" Font-Size="Small" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td align="right" style="height: 27px; width: 214px;">
                        <asp:Label ID="Lblsem" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Semester :"></asp:Label>
                                </td>
                    <td align="left" style="height: 27px; width: 612px;">
                        <asp:DropDownList ID="DDLSem" runat="server" AutoPostBack="True" 
                            Width="69px" style="margin-left: 2px" Height="20px">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator32" runat="server" 
                            ControlToValidate="DDLSem" ErrorMessage="Select Semester" 
                            Font-Bold="True" Font-Size="Small" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                                </td>
                </tr>
                <tr>
                    <td align="right" style="height: 27px; width: 692px;">
                        <asp:Label ID="Label53" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Subject Code :"></asp:Label>
                    </td>
                    <td align="left" style="height: 27px; width: 681px; font-weight: 700;">
                        <asp:TextBox ID="TBSCode" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator29" runat="server" 
                            ControlToValidate="TBSCode" ErrorMessage="Enter Code" 
                            Display="Dynamic" Font-Bold="True" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                    <td align="right" style="height: 27px; width: 214px;">
                        <asp:Label ID="Label58" runat="server" Font-Bold="True" Text="Subject Name :"></asp:Label>
                    </td>
                    <td align="left" style="height: 27px; width: 612px;">
                        <asp:TextBox ID="TBSName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator34" runat="server" 
                            ControlToValidate="TBSName" ErrorMessage="Enter Name" 
                            Display="Dynamic" Font-Bold="True" Font-Size="Small" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="height: 27px; " colspan="4">
                        </td>
                </tr>
                <tr>
                    <td align="center" style="height: 27px; " colspan="4">
                        <asp:Button ID="ButtSave" runat="server" Font-Bold="True" 
                            
                             style="height: 26px" Text="Save" Width="77px" onclick="ButtSave_Click" />
                        &nbsp;
                        <asp:Button ID="ButtReset" runat="server" CausesValidation="False" 
                            Font-Bold="True" Height="26px" 
                             Text="Reset" 
                            Width="69px" onclick="ButtReset_Click"  />
                    &nbsp;&nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="center" style="height: 27px; " colspan="4">
                        <asp:LinkButton ID="LinkButton12" runat="server" CausesValidation="False" 
                            Font-Bold="True" ForeColor="Blue" 
                            PostBackUrl="~/coordinator/viewsubject.aspx" onclick="LinkButton12_Click">View
                        </asp:LinkButton>
                    </td>
                </tr>
                </table>
      
    </div>
</asp:Content>