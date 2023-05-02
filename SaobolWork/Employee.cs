using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaobolWork
{
    public class Employee
    {
        private static int _counter = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; private set; }
        public string Departament { get; set; }
        public double EmployeeSalary { get; set; }

        public Employee(string lastname, string name, string middlename, string departament, double employeeSalary)
        {
            Id = _counter++;

            Name = name;
            LastName = lastname;
            MiddleName = middlename;
            Departament = departament;
            EmployeeSalary = employeeSalary;
        }

    }
}
