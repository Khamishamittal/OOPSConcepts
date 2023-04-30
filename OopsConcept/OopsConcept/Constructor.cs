using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Constructor:InterfaceType
    {
        
        // It is non parameterized constructor doesnot have return type and same name as class name
        public Constructor()
        {
            Console.WriteLine("Khamisha123");
        }
        // Parameterized constructor
        public Constructor(string name)
        {
            Console.WriteLine(name);

        }

        public void WithoutImplementationMethod()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Hi there");
        }
    }
}
    

