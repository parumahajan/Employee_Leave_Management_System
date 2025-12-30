using System;
using System.Linq;
using EmployeeLeaveManagementSystem.Models;

namespace EmployeeLeaveManagementSystem
    {
    public partial class ApproveLeave : System.Web.UI.Page
        {
        protected void Page_Load(object sender, EventArgs e)
            {
            if (!IsPostBack)
                LoadData();
            }

        void LoadData()
            {
            using (var db = new DatabaseContext())
                {
                GridView1.DataSource = db.LeaveRequests
                    .Where(l => l.Status == "Pending")
                    .ToList();

                GridView1.DataBind();
                }
            }

        protected void Approve_Click(object sender, EventArgs e)
            {
            UpdateStatus(sender, "Approved");
            }

        protected void Reject_Click(object sender, EventArgs e)
            {
            UpdateStatus(sender, "Rejected");
            }

        void UpdateStatus(object sender, string status)
            {
            int leaveId =
                int.Parse(((System.Web.UI.WebControls.Button)sender).CommandArgument);

            using (var db = new DatabaseContext())
                {
                var leave = db.LeaveRequests.Find(leaveId);
                leave.Status = status;
                db.SaveChanges();
                }

            LoadData();
            }
        }
    }