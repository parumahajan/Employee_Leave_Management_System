<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="ApproveLeave.aspx.cs"
    Inherits="EmployeeLeaveManagementSystem.ApproveLeave" %>

<!DOCTYPE html>
<html>
<head>
    <title>Approve Leave</title>
</head>
<body>
<form runat="server">

    <h2>Pending Leave Requests</h2>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
        <Columns>

            <asp:BoundField DataField="LeaveId" HeaderText="Leave ID" />
            <asp:BoundField DataField="EmployeeId" HeaderText="Employee ID" />
            <asp:BoundField DataField="FromDate" HeaderText="From" />
            <asp:BoundField DataField="ToDate" HeaderText="To" />

            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Button runat="server" Text="Approve"
                        CommandArgument='<%# Eval("LeaveId") %>'
                        OnClick="Approve_Click" />

                    <asp:Button runat="server" Text="Reject"
                        CommandArgument='<%# Eval("LeaveId") %>'
                        OnClick="Reject_Click" />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>

</form>
</body>
</html>
