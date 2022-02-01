using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CSharpSecaoDezessete.AtividadeIntroducaoLINQ
{
    class AtividadeIntroducaoLINQ
    {
        public static void ExecutarAtividadeIntroducaoLINQ()
        {
            //Specify data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define the query expression
            var result = numbers
            .Where(x => x % 2 == 0)
            .Select(x => x * 10);

            //Excecute the query
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }
        }
    }
}