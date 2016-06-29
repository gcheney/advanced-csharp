using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();

            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrats;
            filterHandler += RemoveRedEyeFilter;

            var path = "path/to/file";
            processor.Process(path, filterHandler);

            //Other generic delegates + lamda expressions
            Func<double, double> circumference = r => 3.12 * r * r;

            Action<string> MyAction = s => Console.Write(s);

            Func<string, bool> CheckGreater = n => n.Length > 10; 

            Predicate<String> CheckGreaterThan5 = x => x.Length > 5;

            var list = new List<string>();
            list.Add("Shiv123");

            var str = list.Find(CheckGreaterThan5);

            Console.ReadKey();
        }

        //create own filter to use with delegate 
        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Remove RedEye");
        }
    }
}
