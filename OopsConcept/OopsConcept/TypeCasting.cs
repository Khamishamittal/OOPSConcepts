using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    //TypeCasting is used to assign value of one date type to another datatype.
    //There arw two types of casting implicit and explicit
    //Implicit : Implicity mean automatically convert a small type to large type.
    //char =>int =>long =>flaot =>double
    //Explicit : Explicit casting should be done manually.
    // Reverse of implicit convert large to small
    //double => float =>long =>int => char
    public class TypeCasting
    {
        public void Method()
        {
            int value = 10;
            double valueOne = value;
            int valueTwo = 20;
            // long add = valueOne + valueTwo;
            Console.WriteLine(value);
            Console.WriteLine(valueOne);
            double valueThree = 10.05;
            int valueFour = (int)valueThree;
            Console.WriteLine(valueFour);



        }

    }
}
