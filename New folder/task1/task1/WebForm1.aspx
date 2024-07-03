<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="task1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <h2>Contact Form</h2>
    <table>
        <tr>
            <td>Name</td>
            <td><asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email</td>
            <td><asp:TextBox ID="EmailTextBox" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:RadioButtonList ID="GenderRadioButtonList" runat="server">
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td>Courses</td>
            <td>
                <asp:CheckBoxList ID="CoursesCheckBoxList" runat="server">
                    <asp:ListItem Text="C" Value="C"></asp:ListItem>
                    <asp:ListItem Text="C++" Value="C++"></asp:ListItem>
                    <asp:ListItem Text="C#" Value="C#"></asp:ListItem>
                </asp:CheckBoxList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
            </td>
        </tr>
    </table>
</div>
<div>
    <h3>Personal Information</h3>
    <asp:Label ID="PersonalInfoLabel" runat="server" />
        </div>
    </form>
</body>
</html>
