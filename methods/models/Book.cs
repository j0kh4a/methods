

namespace methods.models;
class Book
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    public void Print()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void Add(Book book)
    {
        books.Add(book);
    }

    public void Remove(string isbn)
    {
        books.RemoveAll(b => b.ISBN == isbn);
    }

    public void Show()
    {
        foreach (var b in books)
        {
            b.Print();
        }
    }
}
