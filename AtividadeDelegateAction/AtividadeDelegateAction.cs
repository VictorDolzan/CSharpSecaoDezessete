using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDezessete.AtividadeDelegateAction.Entities;

namespace CSharpSecaoDezessete.AtividadeDelegateAction
{
    class AtividadeDelegateAction
    {
        public static void ExecutarAtividadeDelegateAction()
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.00));
            list.Add(new Product("HD Case", 80.90));

            //Action<Product> act = UpdatePrice;
            // Action<Product> act = p => {
            //     p.Price += p.Price * 0.1;
            // };

            list.ForEach(p => {
                p.Price += p.Price * 0.1;
            });
            //list.ForEach(act);
            //list.ForEach(UpdatePrice);
            foreach(Product p in list)
            {
                Console.WriteLine(p);
            }
        }
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}