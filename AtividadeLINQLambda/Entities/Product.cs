using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDezessete.AtividadeLINQLambda.Entities
{
    class Product
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public double Price { get; set; }
        public Category PCategory { get; set; }

        public override string ToString()
        {
            return PId
            + ", "
            + PName
            + ", "
            + Price.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + PCategory.Name
            + ", "
            + PCategory.Tier;
        }
    }
}