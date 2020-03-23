<%@ Page Language="C#" MasterPageFile="~/Faculty.master" AutoEventWireup="true" CodeFile="AddStudent.aspx.cs" Inherits="Administrator_AssignSubject" Title="Student Feedback System" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align: center">
          <table 
                align="center" dir="ltr">
                <tr>
                    <td colspan="5" style="height: 2px" align="center">
                        &nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td align="right" style="height: 27px; " colspan="5">
                        <table style="width: 100%" align="right">
                            <tr>
                                <td align="right" style="width: 235px">
                        <asp:Label ID="Label50" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Course Name :"></asp:Label>
                                </td>
                                <td align="left" colspan="2">
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" 
                            Font-Bold="True" ForeColor="Black" Height="24px" RepeatDirection="Horizontal" 
                            Width="422px" onselectedindexchanged="RadioButtonList1_SelectedIndexChanged" 
                                        DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="id">
                            <asp:ListItem>B.Tech</asp:ListItem>
                            <asp:ListItem>M.Tech</asp:ListItem>
                            <asp:ListItem>MCA</asp:ListItem>
                            <asp:ListItem>MBA</asp:ListItem>
                        </asp:RadioButtonList>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                        ConnectionString="<%$ ConnectionStrings:RegistrationConnectionString %>" 
                                        SelectCommand="Select id,name from Courses"></asp:SqlDataSource>
                                </td>
                                <td align="left">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator26" runat="server" 
                            ControlToValidate="RadioButtonList1" ErrorMessage="Select Course Name" 
                            Font-Bold="True" Font-Size="Small"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right" style="width: 235px">
                                    &nbsp;</td>
                                <td align="right">
                                    &nbsp;</td>
                                <td align="left" style="width: 211px">
                                    &nbsp;</td>
                                <td align="left">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                   <tr>
                                <td align="right" style=" width: 972px; height: 24px;" valign="top">
                                <asp:Label ID="lblsem" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Semester :"></asp:Label>
                                </td>
                                <td align="left" style="height: 24px; width: 365px;">
                        <asp:DropDownList ID="DDLSemester" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="DDLSemester_SelectedIndexChanged" 
                                        ontextchanged="DDLSemester_TextChanged">
                            <asp:ListItem>Select</asp:ListItem>
                        </asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RFVSem" runat="server" 
                            ControlToValidate="DDLSemester" ErrorMessage="Select Semister" 
                            Font-Bold="True" Font-Size="Small" Display="Dynamic"></asp:RequiredFieldValidator>
                                </td>
                                <td align="right" valign="top" style="width: 306px; height: 24px;" 
                                    class="style46">
                                    &nbsp;</td>
                                <td align="left" valign="top" style="height: 24px">
                                    &nbsp;</td>
                                <td align="left" style="height: 24px; ">
                                    &nbsp;</td>
                            </tr>
                   <tr>
                    <td align="right" style="height: 25px; width: 972px;">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Subject :"></asp:Label>
                                </td>
                    <td align="left" style="height: 25px; width: 365px;">
                        <asp:DropDownList ID="DDLSubject" runat="server" 
                            onselectedindexchanged="DDLSubject_SelectedIndexChanged">
                            <asp:ListItem>Select</asp:ListItem>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                            ControlToValidate="DDLSubject" ErrorMessage="Select Subject" 
                            Font-Bold="True" Font-Size="Small" Display="Dynamic"></asp:RequiredFieldValidator>
                                </td>
                    <td align="left" style="height: 25px; width: 306px;">
                        &nbsp;</td>
                    <td align="left" style="height: 25px; width: 97px;">
                        &nbsp;</td>
                    <td align="left" style="height: 25px; ">
                        &nbsp;</td>
                </tr>
                   <tr>
                    <td align="right" style="height: 25px; width: 972px;">
                                    <asp:Label ID="Label60" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Student Name :"></asp:Label>
                                </td>
                    <td align="left" style="height: 25px; width: 365px;">
                                    <asp:DropDownList ID="DDLFName" runat="server">
                                        <asp:ListItem>Select</asp:ListItem>
                                    </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator38" runat="server" 
                            ControlToValidate="DDLFName" ErrorMessage="Select Faculty Name" 
                            Font-Bold="True" Font-Size="Small"></asp:RequiredFieldValidator>
                                </td>
                    <td align="left" style="height: 25px; width: 306px;">
                        &nbsp;</td>
                    <td align="left" style="height: 25px; width: 97px;">
                        &nbsp;</td>
                    <td align="left" style="height: 25px; ">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" style="height: 27px; " colspan="5">
                        <asp:Button ID="ButtSave" runat="server" Font-Bold="True" 
                            
                             style="height: 26px" Text="Save" Width="77px" onclick="ButtSave_Click" />
                        &nbsp;
                        <asp:Button ID="ButtReset" runat="server" CausesValidation="False" 
                            Font-Bold="True" Height="26px" 
                             Text="Reset" 
                            Width="69px" onclick="ButtReset_Click"  />
                    </td>
                </tr>
                <tr>
                    <td align="center" style="height: 347px; " colspan="5">
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

