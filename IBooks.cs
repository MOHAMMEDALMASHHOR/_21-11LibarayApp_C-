public interface IBooks:IComparable<LibraryItem>{
    public int Id { get; set; }
    public string? Title { get; set; }
    public Authors Author { get; set; }
    public DateTime PublishYear { get; set; }
    public bool IsAvaliable { get; set; }
   public int CompareTo(object? obj)
    {
        var other = obj as IBooks;
        return this.PublishYear.CompareTo(other.PublishYear);
    } 
    public void SetAvaliability(bool avaliable);
    }