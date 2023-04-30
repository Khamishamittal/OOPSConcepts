using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class SingleInheritance
    {
        public string Name = "Parent class";
        public void ParentClass()
        {
            Console.WriteLine("I AM THE KING");
        }
    }
        class ChildClass : SingleInheritance
        {
            public int RollNo = 2;

            public void Class2()
            {
                Console.WriteLine("I am derived ");
            }
        }
    }

