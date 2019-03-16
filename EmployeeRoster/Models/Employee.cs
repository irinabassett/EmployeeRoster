using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeRoster.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public DateTime HireDate { get; set; }

        public virtual ICollection<Employment> Employments { get; set; }
    }
}

