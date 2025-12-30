using System;
using System.Linq;
using EmployeeLeaveManagementSystem.Models;

namespace EmployeeLeaveManagementSystem
    {
    public partial class Login : System.Web.UI.Page
        {
        protected void btnLogin_Click(object sender, EventArgs e)
            {
            using (var db = new DatabaseContext())
                {
                var emp = db.Employees
                    .FirstOrDefault(x => x.Email == txtEmail.Text && x.IsActive);

                if (emp == null)
                    {
                    lblMsg.Text = "Invalid user";
                    return;
                    }

                Session["EmployeeId"] = emp.EmployeeId;
                Session["Role"] = emp.Role;

                if (emp.Role == "Employee")
                    Response.Redirect("~/Pages/ApplyLeave.aspx");
                else if (emp.Role == "Manager")
                    Response.Redirect("~/Pages/ApproveLeave.aspx");
                else
                    Response.Redirect("~/Pages/ViewLeaves.aspx");
                }
            }
        }
    }
