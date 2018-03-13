using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._01.ClassHierarchy
{
    public class Manager : Person
    {
        private List<Employee> employees;

        protected Manager(string name, string department, int salary,List<Employee> list) : base(name, department, salary)
        {
            this.employees = list;
        }

        public override void IncreaseSalary()
        {
            this.salary -= 250;
        }

        public override void ReduceSalary()
        {
            this.salary += 250;
        }

        public override string GetBasicInfo()
        {
            return $"this is manager with name {this.name} department {this.department} and number of employes {employees.Count}";
        }

        public void AddEmployee(Employee employee)
        {
            if (employees == null)
            {
                throw new NullReferenceException("error with calling employees");
            }
            this.employees.Add(employee);
        }
    }
}
