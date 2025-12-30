using System.ComponentModel.DataAnnotations;

namespace EmployeeLeaveManagementSystem.Models
    {
    public class Employees
        {
        [Key] 
        public int EmployeeId { get; set; }

        public string FullName { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        public bool IsActive { get; set; }
        }
    }
