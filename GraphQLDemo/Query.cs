using System.Collections.Generic;

public class Query
{
    public List<Book> GetBooks() => books;

    internal static List<Book> books = new List<Book>
    {
        new Book { Title = "GraphQL for beginners", Author = "John Doe" },
        new Book { Title = "Mastering GraphQL", Author = "Jane Doe" }
    };
}
