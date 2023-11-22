
public class Book : LibraryItem
{
    public Book(int id, string? title, Authors author, DateTime publishYear) : base(id, title, author, publishYear)
    {
    }
}