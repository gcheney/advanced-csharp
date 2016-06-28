using System;

namespace Generics
{
    public class Utilities
    {
        public static int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        //T has constraints
        public static T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public static void DoSomething<T>(T value) where T : IComparable, new()
        {
            var obj = new T(); //T must have a default constructor
        }
    }
}
