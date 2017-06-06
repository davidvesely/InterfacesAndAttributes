using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAttributes.Business.IoC
{
    public class ConsoleRegistry : Registry
    {
        public ConsoleRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.Assembly("InterfacesAndAttributes.Business");
                scan.WithDefaultConventions();
                scan.AddAllTypesOf<IService>();
            });

            For<IServiceResolver>().Use<ServiceResolver>();
        }
    }
}
