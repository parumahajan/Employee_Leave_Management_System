using System.Data.Entity;

namespace EmployeeLeaveManagementSystem.Models
    {
    public class DatabaseContext : DbContext
        {
        public DatabaseContext()
            : base("name=EMP_LEAVE_Connection")
            {
            }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<LeaveRequests> LeaveRequests { get; set; }
        }
    }
