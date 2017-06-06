using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAttributes.Business
{
    [Code(Constants.ALPHA_CONS_1)]
    [Code(Constants.BETA_CONST_2)]
    public class ServiceImplMulti : IService
    {
        public void DoWork()
        {
            Console.WriteLine("ServiceImplMulti.DoWork()");
        }
    }
}
