<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FeedBack.aspx.cs" Inherits="student_FeedBack" MasterPageFile="~/StudentMasterPage.master" %>

<script runat="server">

</script>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <center>
        <table style="width: 100%">
            <tr>
                <td style="height: 21px" align="center">
                    <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#FF0066"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Left">
                       
                            <table style="width: 100%">
                                <tr>
                                    <td align="right" class="style20" style="width: 7%; height: 23px;">
                                        Semester:</td>
                                    <td style="width: 19%; height: 23px;">
                                        <asp:Label ID="LblFName" runat="server" Font-Bold="True" 
                                            Font-Names="Microsoft Sans Serif" Font-Size="Small" ForeColor="#435C5B">2</asp:Label>
                                    </td>
                                    <td align="right" style="width: 10%; height: 23px;">
                                        &nbsp;</td>
                                    <td style="width: 23%; height: 23px;">
                                        <asp:Label ID="LblSubj" runat="server" Font-Bold="True" 
                                            Font-Names="Microsoft Sans Serif" Font-Size="Small" ForeColor="#435C5B"></asp:Label>
                                    </td>
                                    <td align="right" style="width: 11%; height: 23px; text-align: center;" 
                                        width="20">
                                        <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td style="width: 11%; height: 23px; text-align: center;">
                                        <asp:Label ID="Label14" runat="server" Text="Label" style="text-align: center"></asp:Label>
                                    </td>
                                    <td align="right" style="width: 11%; height: 23px; text-align: center;" 
                                        width="20">
                                        <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td style="width: 16%; height: 23px; text-align: center;" width="20">
                                        <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" class="style20" style="width: 7%">
                                        &nbsp;</td>
                                    <td style="width: 19%">
                                        <asp:Label ID="LblBranch0" runat="server" Font-Bold="True" 
                                            Font-Names="Microsoft Sans Serif" Font-Size="Small" ForeColor="#435C5B"></asp:Label>
                                    </td>
                                    <td align="right" style="width: 10%">
                                        &nbsp;</td>
                                    <td style="width: 23%">
                                        <asp:Label ID="LblSection0" runat="server" Font-Bold="True" 
                                            Font-Names="Microsoft Sans Serif" Font-Size="Small" ForeColor="#435C5B"></asp:Label>
                                    </td>
                                    <td align="right" style="width: 11%; text-align: center;">
                                        <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td style="width: 413px; text-align: center;">
                                        <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td align="right" style="width: 8%; text-align: center;">
                                        <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
                                    </td>
                                    <td style="width: 16%; text-align: center;">
                                        <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" colspan="8">
                                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" 
                                            CellPadding="4" ForeColor="#333333" GridLines="None" 
                                             Width="100%" onselectedindexchanged="GridView2_SelectedIndexChanged">
                                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                            <RowStyle BackColor="#E3EAEB" Font-Size="Small" HorizontalAlign="Left" 
                                                Width="100%" />
                                            <Columns>
                                                <asp:BoundField DataField="Details" HeaderText="Question" 
                                                    ItemStyle-Width="60%" >
                                                <ItemStyle Width="60%" />
                                                </asp:BoundField>
                                                <asp:TemplateField HeaderText="">
                                                    <ItemTemplate>
                                                        <asp:DropDownList ID="DropDownList2" runat="server">
                                                            <asp:ListItem>1</asp:ListItem>
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" Width="120px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="" ItemStyle-Width="5%">
                                                <ItemTemplate>
                                                        <asp:DropDownList ID="DropDownList3" runat="server">
                                                            <asp:ListItem>1</asp:ListItem>
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" Width="120px" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="">
                                                <ItemTemplate>
                                                        <asp:DropDownList ID="DropDownList4" runat="server">
                                                        <asp:ListItem>1</asp:ListItem>
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" Width="120px" /> 
                                                    </asp:TemplateField>
                                                <asp:TemplateField HeaderText="">
                                                <ItemTemplate>
                                                        <asp:DropDownList ID="DropDownList5" runat="server">
                                                        <asp:ListItem>1</asp:ListItem>
                                                            <asp:ListItem>2</asp:ListItem>
                                                            <asp:ListItem>3</asp:ListItem>
                                                            <asp:ListItem>4</asp:ListItem>
                                                            <asp:ListItem>5</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" Width="120px" /></asp:TemplateField>
                                            </Columns>
                                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" 
                                                HorizontalAlign="Left" />
                                            <EditRowStyle BackColor="#7C6F57" Font-Size="X-Small" />
                                            <AlternatingRowStyle BackColor="White" />
                                        </asp:GridView>
                                        <br />
                                        <asp:Button ID="ButtNext" runat="server" Font-Bold="True" 
                                            onclick="ButtNext_Click" Text="Next" />
                                        &nbsp;</td>
                                </tr>
                            </table>
                       
                            <br />
                            <br />
                            <center>
                                   </center>
                           <br />
                       
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            </table>
        <br />
    </center>
</asp:Content>

