using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PopUp.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required (ErrorMessage ="This field is required Message come from model")]
        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required")]
        public string Position { get; set; }
        public string Office { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
    }
}