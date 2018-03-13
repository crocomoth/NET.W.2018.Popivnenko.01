using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._01.ClassHierarchy
{
    public abstract class Person
    {
        public Person(string name, string department, int salary)
        {
            this.name = name;
            this.department = department;
            this.salary = salary;
        }

        public string name { get; protected set; }
        public string department { get; protected set; }
        public int salary { get; protected set; }

        public virtual string GetBasicInfo()
        {
            return "some info";
        }

        public abstract void ReduceSalary();
        public abstract void IncreaseSalary();
        
    }
}
