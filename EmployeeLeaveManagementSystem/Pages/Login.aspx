<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EmployeeLeaveManagementSystem.Login" %>

<!DOCTYPE html>
<html>
<head>
    <title>Login</title>
</head>
<body>
<form runat="server">

    Email:
    <asp:TextBox ID="txtEmail" runat="server" />
    <br /><br />

    <asp:Button ID="btnLogin" runat="server"
        Text="Login" OnClick="btnLogin_Click" />
    <br /><br />

    <asp:Label ID="lblMsg" runat="server" />

</form>
</body>
</html>
