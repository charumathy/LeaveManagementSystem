using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveManagementSystem.Models
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set;}

        public string EmployeeFirstName { get; set; }

        public string EmployeeLastName { get; set; }

        public string YearsOfExperience { get; set; }

        public string EmployeeDesignation { get; set; }

        public string EmployeeRole { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public DateTime DateOfJoining { get; set; }

        public string PhoneNumber { get; set; }

        public string PersonalEmailID { get; set; }

        public string OfficialEmailID { get; set; }

        public string Address { get; set; }


    }
}