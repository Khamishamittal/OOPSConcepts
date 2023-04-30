using System.Globalization;

namespace OopsConcept
{
    class Program
    {
        public static void Main(string[] args)
        {
            //ClassName name = new ClassName();
            //name.WithoutImplementationMethod();
            ////name.PrintName();
            ////name.PrintType("Khamisha");
            //Constructor obj = new Constructor();
            //obj.WithoutImplementationMethod();
            ////this is enum
            //Console.WriteLine(Project.akash);
            //int count = (int)Project.akash;
            //Console.WriteLine(count);

            //TypeCasting obj = new TypeCasting();
            //obj.Method();
            //ValueType obj = new ValueType();
            //obj.MethodvalueType();
            //Encapsulation encapsulation = new Encapsulation();
            //Console.WriteLine(encapsulation.Name);

            ChildClass child = new ChildClass();
            child.ParentClass();
            Console.WriteLine(child.RollNo);
            Console.WriteLine(child.Name);
            child.Class2();

            // It will hold the key until the key is pressed
            Console.ReadKey();

        }
    }
}