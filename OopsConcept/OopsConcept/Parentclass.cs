using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Parentclass : Baseclass

    {
        public Parentclass()
        {
            Console.WriteLine("This is my parent class");
        }
        public void Test()
        {
            Console.WriteLine("This is parent class");

        }
    }
    public class Baseclass
    {
        public string name;
        public void Testname()
        {
            Console.WriteLine("This is a base class");
        }

    }
}

