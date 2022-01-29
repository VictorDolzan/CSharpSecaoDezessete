using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDezessete.AtividadePredicate.Entities;

namespace CSharpSecaoDezessete.AtividadePredicate
{
    class AtividadePredicate
    {
        public static void ExecutarAtividadePredicate()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.RemoveAll(p => p.Price >= 100);
            list.RemoveAll(ProductTest);

            foreach(Product prod in list)
            {
                Console.WriteLine(prod);
            }
        }

        public static bool ProductTest(Product p)
        {
            return p.Price >= 100.00;
        }
    }
}