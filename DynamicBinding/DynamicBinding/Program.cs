using System;

namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic excelObject = "Mosh";
            excelObject.Optimize();

            dynamic name = "Mosh";
            name = 10;
            Console.WriteLine("Name: " + name);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b; //becomes dynamic
            Console.WriteLine(c);

            int i = 5;
            dynamic d = i; //Becomes int at run-time
        }
    }
}
