<%@ Page Language="C#" AutoEventWireup="true" CodeFile="feedbackquestions.aspx.cs" Inherits="coordinator_feedbackquestions"   MasterPageFile="~/coordinatorMasterPage.master"%>

 <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
     <div style="text-align: center; ">
       
            <table 
                align="center" style="height: 230px; width: 100%">
                <tr>
                    <td align="right" style="height: 27px; width: 403px;">
                        &nbsp;</td>
                    <td align="left" style="height: 27px">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="right" style="height: 27px; " colspan="2">
                        <table style="width: 100%">
                            <tr>
                                <td style="width: 413px">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" 
                            Text="Add Your Proposals :" style="text-align: justify"></asp:Label>
                                </td>
                                <td align="left">
                        <asp:TextBox ID="TextBox2" runat="server" Width="272px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" 
                            ControlToValidate="TextBox2" ErrorMessage="*"></asp:RequiredFieldValidator>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="center" style="height: 27px; " colspan="2">
                        <asp:Button ID="Button4" runat="server" Font-Bold="True" 
                            
                             style="height: 26px" Text="Save" Width="77px" onclick="Button4_Click" 
                            Height="26px" />
                        &nbsp;
                        <asp:Button ID="Button6" runat="server" CausesValidation="False" 
                            Font-Bold="True" Height="26px" 
                             Text="Reset" 
                            Width="69px" onclick="Button6_Click" />
                    </td>
                </tr>
                <tr>
                    <td align="center" style="height: 27px; " colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" style="height: 27px; " colspan="2" width=" ">
                        <asp:SqlDataSource ID="SqlDataSourcequestion" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:RegistrationConnectionString %>" 
                            SelectCommand="Select questions.id,questions.Details from questions"></asp:SqlDataSource>
                        
                        <asp:GridView ID="GridView3" runat="server" AllowPaging="True" 
                            AutoGenerateColumns="False" BackColor="White" 
                            BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="4" 
                            DataSourceID="SqlDataSourcequestion" GridLines="Vertical" 
                            onrowcommand="GridView3_RowCommand" onrowdeleting="GridView3_RowDeleting"> 
                             
                            <AlternatingRowStyle BackColor="#DCDCDC" />
                            <Columns>
                                <asp:TemplateField HeaderText="Question No">
                                    <ItemTemplate><%# Container.DataItemIndex + 1 %></ItemTemplate>
                                </asp:TemplateField>
                                
                                <asp:BoundField DataField="Details" HeaderText="Question" 
                                    SortExpression="Details" />
                                
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#0000A9" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#000065" />
                        </asp:GridView>
                        
                        <br />
                    </td>
                </tr>
            </table>
       
    </div>
</asp:Content>