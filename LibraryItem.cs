
public abstract class LibraryItem : IBooks
{

    public int Id { get  ; set  ; }
    public string? Title { get  ; set  ; }
    public Authors Author { get  ; set  ; }
    public DateTime PublishYear { get  ; set  ; }
    public bool IsAvaliable { get; set; }
    /* public bool IsAvaliable { get=> isAvaliable ; set=> isAvaliable= SetAvaliability(value)  ; }//Another way
    private bool isAvaliable; */

    protected LibraryItem(int id, string? title, Authors author, DateTime publishYear)
    {
        Id = id;
        Title = title;
        Author = author;
        PublishYear = publishYear;
    }
    public void Borrow(){
        if (IsAvaliable.Equals(true))
        {
            System.Console.WriteLine("You can borrow the book");
            SetAvaliability(false);
        }
        else
        {
            System.Console.WriteLine("The wanted book is not avaliable currently");
        }
    }
    public void Return(){ //  public void Return() => SetAvaliablity(true)  lambda
        System.Console.WriteLine("The book is returned succefully!!!");
        SetAvaliability(true);
        
    }
    /* public int CompareTo(object? obj)
    {
        var other = obj as LibraryItem;
        return this.PublishYear.CompareTo(other.PublishYear);
    } */

    public void SetAvaliability(bool avaliable)
    {
        IsAvaliable =avaliable;
    }
    public override string ToString()
    {
        return $"Book's Id:{Id}\tBook's Title:{Title}\tBook's Author:{Author.ToString()}\tBook's Publish Year:{PublishYear}";
    }

    public int CompareTo(LibraryItem? other)
    {
        return this.PublishYear.CompareTo(other.PublishYear);
    }
}