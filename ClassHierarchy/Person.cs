using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassHierarchy
{
    public abstract class Person
    {
        protected Person(string name, string department, int salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }

        public string name { get; protected set; }
        public string department { get;protected set; }
        public int salary { get; protected set; }

        public virtual string GetBasicInfo()
        {
            return "this is a person";
        }

        public abstract void IncreaseSalary();
        public abstract void DecreaseSalary();
    }
}
