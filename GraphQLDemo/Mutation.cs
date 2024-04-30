public class Mutation
{
    public Book AddBook(string title, string author)
    {
        var newBook = new Book { Title = title, Author = author };
        Query.books.Add(newBook);
        return newBook;
    }
}
