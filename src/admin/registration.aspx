<%@ Page Language="C#" AutoEventWireup="true" CodeFile="registration.aspx.cs" Inherits="registration" MasterPageFile="~/RegistrationMasterPage.master" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"> 
    <div style="text-align: center; font-size: xx-large">
    
        <asp:Label ID="Label1" runat="server" ForeColor="Black" 
            style="font-weight: 700; " Text="REGISTRATION FORM"></asp:Label>
    
    </div>
    <table class="style1">
        <tr>
            <td class="style32">
                Student Name:</td>
            <td class="style33">
                <asp:TextBox ID="username" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style34">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="username" ErrorMessage="User name is required" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style35">
                E-mail:</td>
            <td class="style21">
                <asp:TextBox ID="email" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style22">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="email" ErrorMessage="E-mail is required" ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="email" ErrorMessage="you must enter the valid email-id" 
                    ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style24">
                Password:
            </td>
            <td class="style25">
                <asp:TextBox ID="password" runat="server" TextMode="Password" Width="180px"></asp:TextBox>
            </td>
            <td class="style26">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="password" ErrorMessage="Password is required" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style27">
                Confirm Password:</td>
            <td class="style8">
                <asp:TextBox ID="confirmpassword" runat="server" TextMode="Password" 
                    Width="180px"></asp:TextBox>
            </td>
            <td class="style28">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="confirmpassword" ErrorMessage="Confirm Password is required" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
                <br />
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToCompare="password" ControlToValidate="confirmpassword" 
                    ErrorMessage="Both Password must be same" ForeColor="Red"></asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="style32">
                Department:</td>
            <td class="style33">
                <asp:DropDownList ID="DropDownListcourse" runat="server" Width="180px">
                    <asp:ListItem>select department</asp:ListItem>
                    <asp:ListItem Value="1">Computer Science</asp:ListItem>
                    <asp:ListItem Value="2">Industrial Engineering</asp:ListItem>
                    <asp:ListItem Value="3">Law</asp:ListItem>
                    <asp:ListItem Value="4">Economy</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="style34">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
                    ControlToValidate="DropDownListcourse" ErrorMessage="Select the course" 
                    ForeColor="Red" InitialValue="select course"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style36">
                Mobile No.:</td>
            <td class="style37">
                <asp:TextBox ID="mobileno" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style38">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
                    ControlToValidate="mobileno" ErrorMessage="mobile number is required" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style42">
                Date Of Birth:</td>
            <td class="style43">
                <asp:TextBox ID="dateofjoining" runat="server" Width="180px"></asp:TextBox>
            </td>
            <td class="style44">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
                    ControlToValidate="dateofjoining" ErrorMessage="enter date of joining" 
                    ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <%--<tr>
            <td class="style39">
                Designation:</td>
            <td class="style40">
                <asp:DropDownList ID="DropDownListDesignation" runat="server" Width="180px">
                    <asp:ListItem>select Designation</asp:ListItem>
                    <asp:ListItem>Student</asp:ListItem>
                    <asp:ListItem>Co-ordinator</asp:ListItem>
                </asp:DropDownList>
                </td>
            <td class="style41">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" 
                    ControlToValidate="DropDownListDesignation" ErrorMessage="Select the Designation" 
                    ForeColor="Red" InitialValue="select the designation"></asp:RequiredFieldValidator>
                </td>
        </tr>--%>
        <tr>
            <td class="style32">
                </td>
            <td class="style33">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                    Text="Submit " Width="67px" />
                <input id="Reset1" type="reset" value="Reset" onclick="return Reset1_onclick()" /></td>
            <td class="style34">
                </td>
        </tr>
    </table>
      </asp:Content>
<asp:Content ID="Content3" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style8
        {
            width: 269px;
            height: 35px;
        }
        .style21
        {
            height: 13px;
            width: 269px;
        }
        .style22
        {
            width: 923px;
            height: 13px;
        }
        .style24
        {
            width: 451px;
            height: 36px;
        }
        .style25
        {
            height: 36px;
            width: 269px;
        }
        .style26
        {
            width: 923px;
            height: 36px;
        }
        .style27
        {
            width: 451px;
            height: 35px;
        }
        .style28
        {
            width: 923px;
            height: 35px;
        }
        .style32
        {
            width: 451px;
            height: 30px;
        }
        .style33
        {
            width: 269px;
            height: 30px;
        }
        .style34
        {
            width: 923px;
            height: 30px;
        }
        .style35
        {
            width: 451px;
            height: 13px;
        }
        .style36
        {
            width: 451px;
            height: 32px;
        }
        .style37
        {
            width: 269px;
            height: 32px;
        }
        .style38
        {
            width: 923px;
            height: 32px;
        }
        .style39
        {
            width: 451px;
            height: 31px;
        }
        .style40
        {
            width: 269px;
            height: 31px;
        }
        .style41
        {
            width: 923px;
            height: 31px;
        }
        .style42
        {
            width: 451px;
            height: 29px;
        }
        .style43
        {
            width: 269px;
            height: 29px;
        }
        .style44
        {
            width: 923px;
            height: 29px;
        }
    </style>
</asp:Content>
