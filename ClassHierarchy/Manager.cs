using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    public class Manager : Person
    {

        private List<Person> employees;

        

        protected Manager(string name, string department, int salary,List<Person> list) : base(name, department, salary)
        {
            if (list != null)
            {
                employees = list;
            }
            else
            {
                employees = new List<Person>();
            }
            
        }

        public override void DecreaseSalary()
        {
            this.salary -= 250;
        }

        public override void IncreaseSalary()
        {
            this.salary += 250;
        }

        public override string GetBasicInfo()
        {
            return $"this is a manager with name {this.name}, and department {this.department} and with {employees.Count} employees";
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
    }
}
