using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDezessete.AtividadePredicate.Entities
{
    class Product
    {
        public string Name  { get; set; }
        public double Price { get; set; }

        public Product(string externalName, double externalPrice)
        {
            Name = externalName;
            Price = externalPrice;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2");
        }
    }
}