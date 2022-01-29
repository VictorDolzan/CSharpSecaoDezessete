using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDezessete.AtividadeMulticastDelegates.Services;

namespace CSharpSecaoDezessete.AtividadeMulticastDelegates
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class AtividadeMulticastDelegates
    {
        public static void ExecutarAtividadeMulticastDelegates()
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;

            op.Invoke(a, b);
        }
    }
}