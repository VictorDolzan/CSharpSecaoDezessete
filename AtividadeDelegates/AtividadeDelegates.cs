using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDezessete.AtividadeDelegates.Service;

namespace CSharpSecaoDezessete.AtividadeDelegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class AtividadeDelegates
    {
        public static void ExecutarAtividadeDelegate()
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;


            double result = op.Invoke(a, b);

            Console.WriteLine(result);
        }
    }
}