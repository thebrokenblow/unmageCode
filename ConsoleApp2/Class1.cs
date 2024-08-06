using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    internal class Class1
    {
        public string Name { get; set; }    
        public Class1(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Имя: {Name}";
        }
    }
}
