using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._01.ClassHierarchy
{
    public class PartTimeEmployee : Employee
    {
        private string WorkingHours;

        protected PartTimeEmployee(string name, string department, int salary,string workingHours) : base(name, department, salary)
        {
            this.WorkingHours = workingHours;
        }

        public override string GetBasicInfo()
        {
            return $"this is part time employee with name {this.name}, department {this.department} and shedule {this.WorkingHours}";
        }
    }
}
