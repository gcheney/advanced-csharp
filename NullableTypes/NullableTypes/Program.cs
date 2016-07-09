using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;

            Console.WriteLine("GetValueOrDefault() " + date.GetValueOrDefault());
            Console.WriteLine("HasValue: " + date.HasValue);
            //Console.WriteLine("Value: " + date.Value); //Exception!

            DateTime? date2 = new DateTime(2914, 2, 2);
            DateTime date3 = date2.GetValueOrDefault();
            DateTime? date4 = date3;
            Console.WriteLine(date4.GetValueOrDefault());


            DateTime? time = null;
            DateTime today;


            //Long way
            if (time != null)
            {
                today = time.GetValueOrDefault();
            }
            else
            {
                today = DateTime.Today;
            }

            DateTime today2 = (date != null) ? time.GetValueOrDefault() : DateTime.Today;
            //null coalescing operator
            today = time ?? DateTime.Today;

            Console.WriteLine(today);
        }
    }
}
