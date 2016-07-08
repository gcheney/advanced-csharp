using System.Collections.Generic;

namespace LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5.99 },
                new Book() {Title = "Title 2", Price = 7.99 },
                new Book() {Title = "Title 3", Price = 15.99 }
            };
        }
    }
}
