using System;

namespace InterfacesAndAttributes.Business
{
    [Code(Constants.BETA_CONST_2)]
    public class ServiceImpl2 : IService
    {
        public void DoWork()
        {
            Console.WriteLine("ServiceImpl2.DoWork()");
        }
    }
}
