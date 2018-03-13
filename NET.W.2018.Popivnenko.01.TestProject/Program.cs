using NET.W._2018.Popivnenko._01.ClassHierarchy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.W._2018.Popivnenko._01.TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("smth", "smth", 4000);
            employee.GetBasicInfo();
            Console.ReadLine();
        }
    }
}
