using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDezessete.AtividadeDelegateFunc.Entities;

namespace CSharpSecaoDezessete.AtividadeDelegateFunc
{
    class AtividadeDelegateFunc
    {
        public static void ExecutarAtividadeDelegateFunc()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            //Func<Product, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();
            //List<string> result = list.Select(NameUpper ou func).ToList();

            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }

        // static string NameUpper(Product p)
        // {
        //     return p.Name.ToUpper();
        // }
    }
}