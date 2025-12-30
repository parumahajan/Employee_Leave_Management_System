using System;
using System.Linq;
using EmployeeLeaveManagementSystem.Models;

namespace EmployeeLeaveManagementSystem
    {
    public partial class ViewLeaves : System.Web.UI.Page
        {
        protected void Page_Load(object sender, EventArgs e)
            {
            if (!IsPostBack)
                {
                using (var db = new DatabaseContext())
                    {
                    string role = Session["Role"].ToString();
                    int empId = (int)Session["EmployeeId"];

                    if (role == "HR")
                        GridView1.DataSource = db.LeaveRequests.ToList();
                    else
                        GridView1.DataSource = db.LeaveRequests
                            .Where(l => l.EmployeeId == empId)
                            .ToList();

                    GridView1.DataBind();
                    }
                }
            }
        }
    }
