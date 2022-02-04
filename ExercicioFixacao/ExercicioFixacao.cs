using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDezessete.ExercicioFixacao.Entities;

namespace CSharpSecaoDezessete.ExercicioFixacao
{
    class ExercicioFixacao
    {
        public static void ExecutarExercicioFixacao()
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double sal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] fields = sr.ReadLine().Split(',');
                        string name = fields[0];
                        string em = fields[1];
                        double amount = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        list.Add(new Employee(name, em, amount));
                    }
                }

                var emails = list
                .Where(p => p.Salary > sal)
                .OrderBy(p => p.Email)
                .Select(p => p.Email);

                 var sum = list
                .Where(p => p.Name[0] == 'M')
                .Sum(p => p.Salary);

                Console.WriteLine("Email of people whose salary is more than " 
                + sal.ToString("F2", CultureInfo.InvariantCulture));
                foreach (string obj in emails)
                {
                    Console.WriteLine(obj);
                }               

                Console.WriteLine("Sum of salary of people whose name starts with 'M': "
                + sum.ToString("F2", CultureInfo.InvariantCulture));


            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    
    }
}