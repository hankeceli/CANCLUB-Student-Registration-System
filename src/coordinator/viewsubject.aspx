<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewsubject.aspx.cs" Inherits="coordinator_viewsubject" MasterPageFile="~/coordinatorMasterPage.master"%>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div style="width:100%; text-align: center "  >
       
            <table  align="center">
             
       
                    <td align="center" style="height: 27px; " colspan="4">
                        <asp:SqlDataSource ID="SqlDataSourceaddsubject" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:RegistrationConnectionString %>" 
                            SelectCommand="Select Subjects.name, Subjects.short_name,Courses.name,Semesters.name
from Subjects,Courses,Semesters
where Subjects.course_id=Courses.id and Subjects.semester_id=Semesters.id"></asp:SqlDataSource>
                                           &nbsp;&nbsp;&nbsp;&nbsp;<asp:GridView ID="GridView2" runat="server" 
                            AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" 
                            BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" 
                            CellPadding="4" CellSpacing="2" DataSourceID="SqlDataSourceaddsubject" 
                            ForeColor="Black" Width="664px">
                            <Columns>
                                <asp:BoundField DataField="name" HeaderText="Subject Name" 
                                    SortExpression="name" />
                                <asp:BoundField DataField="short_name" HeaderText="Code Name" 
                                    SortExpression="short_name" />
                                <asp:BoundField DataField="name1" HeaderText="Course" 
                                    SortExpression="name1" />
                                <asp:BoundField DataField="name2" HeaderText="Semester" 
                                    SortExpression="name2" />
                            </Columns>
                            <FooterStyle BackColor="#CCCCCC" />
                            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                            <RowStyle BackColor="White" />
                            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                            <SortedAscendingCellStyle BackColor="#F1F1F1" />
                            <SortedAscendingHeaderStyle BackColor="#808080" />
                            <SortedDescendingCellStyle BackColor="#CAC9C9" />
                            <SortedDescendingHeaderStyle BackColor="#383838" />
                        </asp:GridView>
&nbsp;<asp:Label ID="lblMessage1" runat="server" Font-Bold="True" ForeColor="#FF33CC"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="4">
                        <asp:Button ID="Button1" runat="server" CausesValidation="False" 
                            Font-Bold="True" PostBackUrl="~/coordinator/subject.aspx" Text="Back" />
                    </td>
                </tr>
          </table>
        
    </div>
</asp:Content>



