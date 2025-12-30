<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ApplyLeave.aspx.cs"
    Inherits="EmployeeLeaveManagementSystem.ApplyLeave" %>

<!DOCTYPE html>
<html>
<head>
    <title>Apply Leave</title>
</head>
<body>
<form runat="server">

    <h2>Apply Leave</h2>

    From:
    <asp:TextBox ID="txtFrom" runat="server" TextMode="Date" /><br /><br />

    To:
    <asp:TextBox ID="txtTo" runat="server" TextMode="Date" /><br /><br />

    Reason:
    <asp:TextBox ID="txtReason" runat="server" /><br /><br />

    <asp:Button ID="btnApply" runat="server"
        Text="Apply Leave" OnClick="btnApply_Click" />
    <br /><br />

    <asp:Label ID="lblMsg" runat="server"/>
   

</form>
</body>
</html>
