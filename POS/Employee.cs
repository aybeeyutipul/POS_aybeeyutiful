using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public int PersonId { get; set; }
        public int EmployeeStatus { get; set; }
        public int EmployeeType { get; set; }
        public DateTime DateCreated { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
