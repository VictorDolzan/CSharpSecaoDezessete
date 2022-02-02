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
using CSharpSecaoDezessete.AtividadePredicate;
using CSharpSecaoDezessete.AtividadePredicate.Entities;
using CSharpSecaoDezessete.AtividadeDelegateAction;
using CSharpSecaoDezessete.AtividadeDelegateAction.Entities;
using CSharpSecaoDezessete.AtividadeDelegateFunc;
using CSharpSecaoDezessete.AtividadeDelegateFunc.Entities;
using CSharpSecaoDezessete.AtividadeIntroducaoLINQ;
using CSharpSecaoDezessete.AtividadeLINQLambda;
using CSharpSecaoDezessete.AtividadeLINQLambda.Entities;

namespace CSharpSecaoDezessete
{
    class Program
    {
        public static void Main(string[] args)
        {
            //AtividadeIComparable.AtividadeIComparable.ExecutarAtividadeIComparable();
           //AtividadeDelegates.AtividadeDelegates.ExecutarAtividadeDelegate();
            //AtividadeMulticastDelegates.AtividadeMulticastDelegates.ExecutarAtividadeMulticastDelegates();
            //AtividadePredicate.AtividadePredicate.ExecutarAtividadePredicate();
            //AtividadeDelegateAction.AtividadeDelegateAction.ExecutarAtividadeDelegateAction();
            //AtividadeDelegateFunc.AtividadeDelegateFunc.ExecutarAtividadeDelegateFunc();
           // AtividadeIntroducaoLINQ.AtividadeIntroducaoLINQ.ExecutarAtividadeIntroducaoLINQ();
           AtividadeLINQLambda.AtividadeLINQLambda.ExecutarAtividadeLINQLambda();
        }
    }
}
