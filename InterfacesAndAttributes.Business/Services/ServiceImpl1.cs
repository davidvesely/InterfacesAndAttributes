using System;

namespace InterfacesAndAttributes.Business
{
    [Code(Constants.ALPHA_CONS_1)]
    public class ServiceImpl1 : IService
    {
        public void DoWork()
        {
            Console.WriteLine("ServiceImpl1.DoWork()");
        }
    }
}
