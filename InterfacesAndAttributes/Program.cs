using InterfacesAndAttributes.Business;
using InterfacesAndAttributes.Business.IoC;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = Business.IoC.StructureMap.Default.GetInstance<IServiceResolver>();
            Console.WriteLine("executing first constant");
            test.Execute(Constants.ALPHA_CONS_1);
            Console.WriteLine();
            Console.WriteLine("executing second constant");
            test.Execute(Constants.BETA_CONST_2);
        }
    }
}
