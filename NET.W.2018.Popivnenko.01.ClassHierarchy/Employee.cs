using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._01.ClassHierarchy
{
    public class Employee : Person
    {
        protected Employee(string name, string department, int salary) : base(name, department, salary)
        {
        }

        public override void IncreaseSalary()
        {
            this.salary -= 100;
        }

        public override void ReduceSalary()
        {
            this.salary += 100;
        }

        public override string GetBasicInfo()
        {
            return $"this is employee with name {this.name} and department {this.department}";
        }
    }
}
