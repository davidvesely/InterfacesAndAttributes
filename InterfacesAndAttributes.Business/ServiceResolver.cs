using System;
using System.Collections.Generic;
using System.Linq;

namespace InterfacesAndAttributes.Business
{
    public class ServiceResolver : IServiceResolver
    {
        private Dictionary<string, IEnumerable<Type>> registeredTypes;

        public ServiceResolver()
        {
            // Retrieve all registered types of particular plugin type (interface)
            List<Type> serviceTypes = IoC.StructureMap.Default.Model
                .AllInstances
                .Where(a => a.PluginType == typeof(IService))
                .Select(a => a.ReturnedType)
                .ToList();

            // Flatten types and codes in a 2D collection
            // And then group by code in dictionary
            registeredTypes = 
                serviceTypes.SelectMany(type => 
                    type.GetCustomAttributes(inherit: false)
                    .OfType<CodeAttribute>()
                    .Select(b => b.Code),
                    (type, code) =>
                    {
                        return new
                        {
                            Code = code,
                            Type = type
                        };
                    }
                ).GroupBy(a => a.Code)
                .Select(a => new
                {
                    Code = a.Key,
                    Types = a.Select(b => b.Type)
                })
                .ToDictionary(a => a.Code, b => b.Types);
        }

        public void Execute(string code)
        {
            if (registeredTypes.ContainsKey(code))
            {
                IEnumerable<Type> types = registeredTypes[code];

                if (types != null)
                {
                    foreach (Type type in types)
                    {
                        var instance = IoC.StructureMap.Default.GetInstance(type) as IService;
                        instance.DoWork();
                    }
                }
            }
        }
    }
}
