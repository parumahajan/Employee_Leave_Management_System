<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewLeaves.aspx.cs" Inherits="EmployeeLeaveManagementSystem.ViewLeaves" %>

<!DOCTYPE html>
<html>
<head>
    <title>View Leaves</title>
</head>
<body>
<form runat="server">

    <h2>Leave Records</h2>

    <asp:GridView ID="GridView1" runat="server"
        AutoGenerateColumns="true" />

</form>
</body>
</html>
