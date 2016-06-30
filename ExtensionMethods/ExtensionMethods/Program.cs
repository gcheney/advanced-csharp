using System;
using System.Linq;
using System.Collections.Generic;

namespace ExtenssionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is very long blah blah blah...";
            var shortednPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() { 1, 3, 5, 6, 7, 8 };
            var max = numbers.Max();

            Console.WriteLine(shortednPost + " " + max);
            Console.ReadKey();
        }
    }
}
