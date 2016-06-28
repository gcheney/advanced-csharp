using System;

namespace Generics
{
    class Program
    {
        //types of contraints

        //where T : IComparable
        //where T : Product 
        //where T : struct 
        //where T : class
        //where T : new()

        static void Main(string[] args)
        {
            var book = new Book { ISBN = "1111", Title = "C# Advanced"};

            var books = new GenericList<Book>();
            books.Add(book);

            Console.WriteLine(books.GetSize());
            Console.WriteLine(books[0].Title);

            books[0] = new Book() { ISBN = "22", Title = "New Book" };
            var newBook = books.Get(0);

            Console.WriteLine(newBook.Title + " " + newBook.ISBN);

            //multiple generic parameters
            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("ISBN", new Book());

            //using egeneric method
            Console.WriteLine(Utilities.Max<int>(5, 10));

            //contraint to paticular class
            var calculator = new DicountCalculator<Product>();
            var product = new Product() { Price = 12.99, Name = "TV"};
            var discount = calculator.CalculateDiscount(product);
            Console.WriteLine("Discount: $" + discount);

            //using Nullable class
            var number = new Nullable<int>(5);
            Console.WriteLine("Has Value? " + number.HasValue);
            Console.WriteLine("Value: " + number.GetNullOrDefault());

            Console.ReadKey();
        }
    }
}
