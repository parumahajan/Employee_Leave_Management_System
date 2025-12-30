using System;
using System.Linq;
using EmployeeLeaveManagementSystem.Models;

namespace EmployeeLeaveManagementSystem
    {
    public partial class ApplyLeave : System.Web.UI.Page
        {
        protected void btnApply_Click(object sender, EventArgs e)
            {
            int empId = (int)Session["EmployeeId"];

            DateTime from = DateTime.Parse(txtFrom.Text);
            DateTime to = DateTime.Parse(txtTo.Text);

            if (from >= to)
                {
                lblMsg.Text = "Invalid date range";
                return;
                }

            using (var db = new DatabaseContext())
                {
                bool overlap = db.LeaveRequests.Any(l =>
                    l.EmployeeId == empId &&
                    l.Status == "Approved" &&
                    from <= l.ToDate &&
                    to >= l.FromDate);

                if (overlap)
                    {
                    lblMsg.Text = "Overlapping leave not allowed";
                    return;
                    }

                db.LeaveRequests.Add(new LeaveRequests
                    {
                    EmployeeId = empId,
                    FromDate = from,
                    ToDate = to,
                    Reason = txtReason.Text,
                    Status = "Pending",
                    CreatedAt = DateTime.Now
                    });

                db.SaveChanges();
                lblMsg.Text = "Leave applied successfully";
                }
            }

        protected void Page_Load(object sender, EventArgs e)
            {

            }
        }
    }
