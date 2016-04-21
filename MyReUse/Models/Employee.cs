using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyReUse.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public override string ToString()
        {
            return FirstName+" "+LastName+" "+Salary;
        }
    }
}