using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    public class Encapsulation
    {
        //It will hide a sensitive data from a user
        //Declared field or variable  should be private
        private string name = "VIHAN";// defined field should be private
        public string Name // property
        {
            get
            {
                return name;
            }
            set
            {
                name = value; // name = value - it will set or assign value to the name
            }
        }
    }
}








