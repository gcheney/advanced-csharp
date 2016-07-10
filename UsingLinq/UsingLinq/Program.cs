using System;
using System.Collections.Generic;
using System.Linq;

namespace UsingLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var oneBook = books.Single(b => b.Title == "Title 1");
            Console.WriteLine(oneBook.Title);

            oneBook = books.FirstOrDefault(b => b.Title == "Title 2");
            Console.WriteLine(oneBook.Title);

            //Old way before Linq
            var nonLinqBooks = new List<string>();
            foreach (Book book in books)
            {
                if (book.Price < 10)
                {
                    nonLinqBooks.Add(book.Title);
                }
            }

            //LINQ Query operators
            var cheaperBooks = from b in books
                               where b.Price < 10
                               orderby b.Title
                               select b.Title;

            //LINQ extension methods
            var cheapBooks = books
                                .Where(b => b.Price < 10)
                                .OrderBy(b => b.Title)
                                .Select(b => b.Title);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book);
            }

            var pagedBooks = books.Skip(2).Take(3);

            foreach (var pagedBook in pagedBooks)
            {
                Console.WriteLine(pagedBook.Title);
            }

            var count = books.Count();
            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var total = books.Sum(b => b.Price);
            var avg = books.Average(b => b.Price);

            Console.WriteLine(count + " " + maxPrice + " " + minPrice
                + " " + total);
        }
    }
}
