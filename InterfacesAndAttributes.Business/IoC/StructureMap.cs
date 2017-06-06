using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAttributes.Business.IoC
{
    public class StructureMap
    {
        public static IContainer Default { get; set; }

        static StructureMap()
        {
            Default = Container.For<ConsoleRegistry>();
        }
    }
}
