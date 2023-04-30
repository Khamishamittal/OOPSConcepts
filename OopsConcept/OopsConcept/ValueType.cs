using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class ValueType
    {
        //In value type two types are there
        //1) built in type
        // 2) user - defined type
        // built in type - int , float , double, byte, decimal ,short, char , bool
        // user - defined type - struct and enum
        // it will store  in a stack memory
        public void MethodvalueType()
        {
            //num_one and num_two variable are the value types.
            int num_one = 12, num_two = num_one;
            num_two++;
            Console.WriteLine(num_one);
            Console.WriteLine(num_two);

        }
    }
}
