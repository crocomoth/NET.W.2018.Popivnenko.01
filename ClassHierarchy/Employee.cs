using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    public class Employee : Person
    {
        protected Employee(string name, string department, int salary) : base(name, department, salary)
        {
        }

        public override void DecreaseSalary()
        {
            this.salary -= 100;
        }

        public override void IncreaseSalary()
        {
            this.salary += 100;
        }

        public override string GetBasicInfo()
        {
            return $"this is basic employee with name: {name}, department : {department}";
        }
    }
}
