using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    // access modifiers in c# are the keyword use to specify the accessability or scope of variable of function
    public class AccessModifiers
    {
        // access in same assembly or different assembly
        public int a = 10;
        //private we can access anywere outside the class
        private void PrivateMethod()
        {
            Console.WriteLine("Private method");
        }
        // code is accessible is same class or derived class
        protected string str = " hello";
        //the access is limited to the current class or derived class
        protected internal double val = 2.4;
    }
    
    
}
