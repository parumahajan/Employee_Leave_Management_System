using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeLeaveManagementSystem.Models
    {
    public class LeaveRequests
        {
        [Key]  
        public int LeaveId { get; set; }

        public int EmployeeId { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime ToDate { get; set; }

        public string Reason { get; set; }

        public string Status { get; set; }

        public DateTime CreatedAt { get; set; }
        }
    }
