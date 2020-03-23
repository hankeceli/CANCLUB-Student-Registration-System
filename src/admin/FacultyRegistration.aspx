<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FacultyRegistration.aspx.cs" Inherits="admin_FacultyRegistration" MasterPageFile="~/admin.master"%>

  

<script runat="server">

   
    
  
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <div style="text-align: center;" align="center">
            <table 
                align="center" width="100%">
                <tr>
                    <td colspan="4" style="height: 2px" align="center">
                        &nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td align="right" style="height: 27px; " colspan="4">
                        <table style="width: 100%">
                            <tr>
                                <td align="right">
                        <asp:Label ID="Label57" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Course Name :"></asp:Label>
                                </td>
                                <td align="left" style="width: 350px">
                        <asp:RadioButtonList ID="RadioButtonList2" runat="server" AutoPostBack="True" 
                            Font-Bold="True" ForeColor="Black" Height="24px" RepeatDirection="Horizontal" 
                            Width="422px">
                            <asp:ListItem Value="1">CENG 382 Web Development</asp:ListItem>
                            <asp:ListItem Value="2">CENG 328 Operating Systems</asp:ListItem>
                            <asp:ListItem Value="3">CENG 356 Database Management Systems</asp:ListItem>
                            <asp:ListItem Value="4">CENG 396 Software Engineering</asp:ListItem>
                        </asp:RadioButtonList>
                                </td>
                                <td align="left">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator32" runat="server" 
                            ControlToValidate="RadioButtonList2" ErrorMessage="Select Course Name" 
                            Font-Bold="True" Font-Size="Small"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td align="right">
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
                    <td align="right" style="height: 27px; width: 673px;">
                        <asp:Label ID="Label49" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Name :"></asp:Label>
                    </td>
                    <td align="left" style="height: 27px; width: 579px;">
                        <asp:TextBox ID="TBName" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator25" runat="server" 
                            ControlToValidate="TBName" ErrorMessage="Enter Name" Font-Bold="True" 
                            Font-Size="Small"></asp:RequiredFieldValidator>
                    </td>
                    <td align="right" class="style6" style="width: 140px">
                        <asp:Label ID="Label52" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Department :"></asp:Label>
                    </td>
                    <td align="left" style="height: 27px; width: 840px;">
                        <asp:DropDownList ID="DDLDept" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="DDLDept_SelectedIndexChanged" Height="16px">
                            <asp:ListItem>Select</asp:ListItem>
                            <asp:ListItem>Computer Science</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="lblDept" runat="server" Font-Bold="True"></asp:Label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator28" runat="server" 
                            ControlToValidate="DDLDept" ErrorMessage="Select Department" 
                            Font-Bold="True" Font-Size="Small"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="height: 42px; width: 673px;">
                        <asp:Label ID="Label54" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Email Id :"></asp:Label>
                    </td>
                    <td align="left" style="height: 42px; width: 579px;">
                        <asp:TextBox ID="TBEmailId" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                            ControlToValidate="TBEmailId" ErrorMessage="Plz Enter Valid format" 
                            Font-Bold="True" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                            Font-Size="Small"></asp:RegularExpressionValidator>
                            
                    </td>
                    <td align="right" style="height: 42px; width: 140px;">
                        <asp:Label ID="Label58" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Password :"></asp:Label>
                    </td>
                    <td align="left" style="height: 42px; width: 840px;">
                <asp:TextBox ID="password" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="password" ErrorMessage="Password is required" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="height: 27px; width: 673px;">
                        <asp:Label ID="Label53" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Address :"></asp:Label>
                    </td>
                    <td align="left" style="height: 27px; width: 579px;">
                        <asp:TextBox ID="TBAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
                            
                    </td>
                    <td align="right" style="height: 27px; width: 140px;">
                        <asp:Label ID="Label55" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Mobile :"></asp:Label>
                    </td>
                    <td align="left" style="width: 840px">
                        <asp:TextBox ID="TBMobile" runat="server" MaxLength="10"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator31" runat="server" 
                            ControlToValidate="TBMobile" ErrorMessage="Enter Mobile No" 
                            Font-Bold="True" Font-Size="Small"></asp:RequiredFieldValidator>
                         <br />
      
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" 
                            ControlToValidate="TBMobile" Display="Dynamic" ErrorMessage="Enter Digits(10)" 
                            Font-Bold="True" Font-Size="Small" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="height: 27px; width: 673px;">
                        <asp:Label ID="Label56" runat="server" Font-Bold="True" ForeColor="Black" 
                        Text="Remarks :"></asp:Label>
                    </td>
                    <td align="left" style="height: 27px; width: 579px;">
                        <asp:TextBox ID="TBRemarks" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                    <td align="left" style="height: 27px; " colspan="2">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td align="center" style="height: 27px; " colspan="4">
                        <asp:Button ID="Save" runat="server" Font-Bold="True" 
                            
                             style="height: 26px" Text="Save" Width="77px" onclick="Save_Click" />
                        &nbsp;
                        <asp:Button ID="Reset" runat="server" CausesValidation="False" 
                            Font-Bold="True" Height="26px" 
                             Text="Reset" 
                            Width="69px" onclick="Reset_Click"  />
                    </td>
                </tr>
                <tr>
                    <td align="center" style="height: 27px; " colspan="4">
                        <asp:SqlDataSource ID="SqlDataSourceFaculty_Details" runat="server" 
                            ConnectionString="<%$ ConnectionStrings:RegistrationConnectionString %>" 
                            SelectCommand="Select Faculties.name,Faculties.email,Faculties.password,Courses.name,Faculties.mobile
,Faculties.address,Faculties.remark from Faculties,Courses
WHERE Faculties.course_id=Courses.id"></asp:SqlDataSource>
                        <asp:GridView ID="GridView5" runat="server" AllowSorting="True" 
                            AutoGenerateColumns="False"  BackColor="White" 
                            BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                            DataSourceID="SqlDataSourceFaculty_Details" GridLines="Vertical" 
                            OnRowCancelingEdit="GridView5_RowCancelingEdit" OnRowEditing="GridView5_RowEditing" OnRowUpdating="GridView5_RowUpdating">
                            <AlternatingRowStyle BackColor="Gainsboro" />
                            <Columns>
                                <asp:BoundField DataField="name" HeaderText="Faculty Name" 
                                    SortExpression="name" />
                                <asp:BoundField DataField="email" HeaderText="E-mail" 
                                    SortExpression="email" />
                                <asp:BoundField DataField="password" HeaderText="Password" 
                                    SortExpression="password" />
                                <asp:BoundField DataField="name1" HeaderText="Course" 
                                    SortExpression="name1" />
                                <asp:BoundField DataField="mobile" HeaderText="Mobile" 
                                    SortExpression="mobile" />
                                <asp:BoundField DataField="address" HeaderText="Address" 
                                    SortExpression="address" />
                                <asp:BoundField DataField="remark" HeaderText="Remark" 
                                    SortExpression="remark" />
                                <asp:CommandField ShowEditButton="true" />
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
                        <asp:Label ID="lblMessage1" runat="server" Font-Bold="True" ForeColor="#FF3399"></asp:Label>
                    </td>
                </tr>
                </table>
        
    </div>
</asp:Content>


