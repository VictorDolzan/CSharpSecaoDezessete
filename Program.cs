using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using CSharpSecaoDezessete.AtividadeIComparable;
using CSharpSecaoDezessete.AtividadeIComparable.Entities;
using CSharpSecaoDezessete.AtividadeDelegates;
using CSharpSecaoDezessete.AtividadeDelegates.Service;
using CSharpSecaoDezessete.AtividadeMulticastDelegates;
using CSharpSecaoDezessete.AtividadeMulticastDelegates.Services;

namespace CSharpSecaoDezessete
{
    class Program
    {
        public static void Main(string[] args)
        {
            //AtividadeIComparable.AtividadeIComparable.ExecutarAtividadeIComparable();
           //AtividadeDelegates.AtividadeDelegates.ExecutarAtividadeDelegate();
            AtividadeMulticastDelegates.AtividadeMulticastDelegates.ExecutarAtividadeMulticastDelegates();
        }
    }
}
