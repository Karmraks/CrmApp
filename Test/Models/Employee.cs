using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public int PositionId { get; set; }

        public string PositionName { get; set; } = string.Empty;

        public virtual Position Position { get; set; }

        public decimal Salary { get; set; }

        public DateTime Hired { get; set; }

        public DateTime? Fired { get; set; }
    }
}