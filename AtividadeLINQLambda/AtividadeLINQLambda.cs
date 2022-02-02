using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDezessete.AtividadeLINQLambda.Entities;

namespace CSharpSecaoDezessete.AtividadeLINQLambda
{
    class AtividadeLINQLambda
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        public static void ExecutarAtividadeLINQLambda()
        {
            Category c1 = new Category(){
                Id = 1,
                Name = "Tools",
                Tier = 2
            };
            Category c2 = new Category(){
                Id = 2,
                Name = "Computers",
                Tier = 1
            };
            Category c3 = new Category(){
                Id = 3,
                Name = "Electronics",
                Tier = 1
            };

            List<Product> products = new List<Product>()
            {
                new Product(){ PId = 1, PName = "Computer", Price = 1100.0, PCategory = c2 },
                new Product(){ PId = 2, PName = "Hammer", Price = 90.0, PCategory = c1},
                new Product(){ PId = 3, PName = "TV", Price = 1700.0, PCategory = c3},
                new Product(){ PId = 4, PName = "Notebook", Price = 1300.0, PCategory = c2},
                new Product(){ PId = 5, PName = "Saw", Price = 80.0, PCategory = c1},
                new Product(){ PId = 6, PName = "Tablet", Price = 700.0, PCategory = c2},
                new Product(){ PId = 7, PName = "Camera", Price = 700.0, PCategory = c3},
                new Product(){ PId = 8, PName = "Printer", Price = 350.0, PCategory = c3},
                new Product(){ PId = 9, PName = "MacBook", Price = 1800.0, PCategory = c2},
                new Product(){ PId = 10, PName = "Sound Bar", Price = 700.0, PCategory = c3},
                new Product(){ PId = 11, PName = "Level", Price = 70.0, PCategory = c1}
            };

            var r1 = products
            .Where(p => p.PCategory.Tier == 1 && p.Price < 900.0);
            Print("Tier 1 and Price < 900: ", r1);
            
            var r2 = products
            .Where(p => p.PCategory.Name == "Tools")
            .Select(p => p.PName);
            Print("Names of Products from Tools: ", r2);

            var r3 = products
            .Where(p => p.PName[0] == 'C')
            .Select(p => new{ p.PName, p.Price, CategoryName = p.PCategory.Name });
            Print("Names of Products that starts with letter C: ", r3);

            var r4 = products
            .Where(p => p.PCategory.Tier == 1)
            .OrderBy(p => p.Price)
            .ThenBy(p => p.PName);
            Print("Products with tier 1 order by price then by name: ", r4);

            var r5 = r4.Skip(2).Take(4);
            Print("Tier 1 order by price then by name skip 2 take 4: ", r5);

            var r6 = products
            .FirstOrDefault();
            Console.WriteLine("First or Default test1: " + r6);

            var r7 = products
            .Where(p => p.Price > 3000.0).FirstOrDefault();
            Console.WriteLine("First or Default test2: " + r7);

            var r8 = products
            .Where(p => p.PId == 3)
            .SingleOrDefault();
            Console.WriteLine("Single or Default test1: " + r8);

             var r9 = products
            .Where(p => p.PId == 30)
            .SingleOrDefault();
            Console.WriteLine("Single or Default test2: " + r9);
        }
    }
}

