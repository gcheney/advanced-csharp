using System;

namespace LambdaExpressions
{
    class Program
    {
        private const int Factor = 5;

        static void Main(string[] args)
        {
            // () => ....
            // x => ....
            //(x, y, z) => ....
            Func<int, int> square = num => num * num;
            int number = 5;
            Console.WriteLine(square(number));

            Func<int, int, int> multiplier = (m, n) => n * (m * Factor);
            var result = multiplier(10, 1);
            Console.WriteLine(result);

            //Using book repository
            var books = new BookRepository().GetBooks();

            var cheapBooks = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

            Console.ReadKey();
        }

        //Replaced by lamdba Predicate<T>
        static bool IsCheapBook(Book book)
        {
            return book.Price < 10;
        }

        //Replaced by Lambda expression
        static int Square(int number)
        {
            return number * number;
        }
    }
}
