using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    public class PartTimeEmployee : Employee
    {

        public string WorkingHours { get; protected set; }

        protected PartTimeEmployee(string name, string department, int salary, string workingHours) : base(name, department, salary)
        {
            this.WorkingHours = workingHours;
        }

        public override void DecreaseSalary()
        {
            base.DecreaseSalary();
        }

        public override string GetBasicInfo()
        {
            return $"this is part time employee with name {this.name}, department {this.department} and shedule {this.WorkingHours}";
        }

        public override void IncreaseSalary()
        {
            base.IncreaseSalary();
        }
    }
}
