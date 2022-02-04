using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDezessete.ExercicioFixacao.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string externalName, string externalEmail, double externalSalary)
        {
            Name = externalName;
            Email = externalEmail;
            Salary = externalSalary;
        }
    }
}