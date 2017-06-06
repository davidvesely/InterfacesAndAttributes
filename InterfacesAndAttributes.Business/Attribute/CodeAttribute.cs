using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAttributes.Business
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class CodeAttribute : Attribute
    {
        private string _code;

        public CodeAttribute(string code)
        {
            _code = code;
        }

        public string Code => _code;
    }
}
