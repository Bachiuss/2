using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondChoice
{
    public class Employee
    {
        private int Salary;
            
        public string _employeeName { get; set; }

        public Employee(int salary, string Employeename)
        {
            _employeeName = Employeename;
            Salary = salary;
        }

        public string DisplayInfo()
        {
            return "Hi, i'm " + _employeeName + " and i earn " + Salary + " per year";
        }
    }
}
