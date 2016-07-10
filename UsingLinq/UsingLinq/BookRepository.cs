using System.Collections.Generic;

namespace UsingLinq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5.99f },
                new Book() {Title = "Title 2", Price = 7.99f },
                new Book() {Title = "Title 3", Price = 17.99f },
                new Book() {Title = "Title 4", Price = 8.00f },
                new Book() {Title = "Title 5", Price = 15.99f }
            };
        }
    }
}
