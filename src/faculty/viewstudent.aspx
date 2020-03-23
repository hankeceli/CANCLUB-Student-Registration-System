<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewstudent.aspx.cs" Inherits="faculty_viewstudent" MasterPageFile="~/Faculty.master"%>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
          <table 
                align="center" dir="ltr">
                 <tr>
                    <td align="center" colspan="5" class="style31">
                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" 
                            ForeColor="#333333" GridLines="None" Width="80%" 
                            
                            AutoGenerateColumns="False" 
                           >
                            <PagerSettings Mode="NextPreviousFirstLast" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <RowStyle BackColor="#E3EAEB" />
                            <PagerStyle BackColor="Silver" ForeColor="White" HorizontalAlign="Right" />
                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <Columns>
                                <asp:BoundField HeaderText="Course" DataField="name"/>
                                <asp:BoundField HeaderText="Semester" DataField="name1"/>
                                <asp:BoundField HeaderText="Subject" DataField="name2"/>
                                <asp:BoundField HeaderText="Student" DataField="name3"/>
                            </Columns>
                            <EditRowStyle BackColor="#7C6F57" />
                            <AlternatingRowStyle BackColor="White" />
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:RegistrationConnectionString %>" SelectCommand="Select Courses.name,Semesters.name,Subjects.name,Faculties.name
from
Courses,Semesters,Subjects,Faculties,subject_faculty
where
subject_faculty.sub_id=Subjects.id AND subject_faculty.faculty_id=Faculties.id
AND Courses.id=Subjects.course_id AND Semesters.id=Subjects.semester_id"></asp:SqlDataSource>
                    </td>
                </tr>
            </table>
            </div>
</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style31
        {
            height: 347px;
            width: 604px;
        }
    </style>
</asp:Content>

