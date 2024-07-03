<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="task1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container">
     
     <div>
         <label for="number1">Number 1: </label>
         <asp:TextBox ID="number1TextBox" runat="server"></asp:TextBox>
     </div>
     <div>
         <label for="number2">Number 2: </label>
         <asp:TextBox ID="number2TextBox" runat="server"></asp:TextBox>
         <br />
     </div>
     <div class="buttons">
         <asp:Button ID="addButton" runat="server" Text="+" OnClick="AddButton_Click" />
         <asp:Button ID="subtractButton" runat="server" Text="-" OnClick="SubtractButton_Click" />
         <asp:Button ID="multiplyButton" runat="server" Text="*" OnClick="MultiplyButton_Click" />
         <br />
     </div>
     <div class="result">
         <asp:Label ID="result" runat="server" Text=""></asp:Label>
     </div>
 </div>
    </form>
</body>
</html>
