using System.Collections;

public class Library : IEnumerable
{
    private List<LibraryItem> libraryItems;
    public Library()
    {
        libraryItems = new List<LibraryItem>();
    }
    public void CreatBook(LibraryItem item){
        item.SetAvaliability(true);
        libraryItems.Add(item);
    }
    public void GiveBook(int id){
        System.Console.WriteLine(libraryItems.Where(book=>book.Id.Equals(id)).FirstOrDefault().ToString()+" Is given");
        //LINQ
        libraryItems.Where(book=>book.Id.Equals(id)).First().Borrow();
        //Don't create a new variable with the LINQ because it will take a new referance!!! instead of that you can use for i
       /*  for (int i = 0; i < libraryItems.Count; i++)
        {
            if (libraryItems[i].Id.Equals(id))
            {
                libraryItems[i].Borrow();
            }
            
        } */
        
    }
    public void TakeBook(int id){
        System.Console.WriteLine(libraryItems.Where(book=>book.Id.Equals(id)).FirstOrDefault()+" Is given");
     //Don't create a new variable with the LINQ because it will take a new referance!!! instead of that you can use for i
       /*  var item =libraryItems.Where(book=>book.Id.Equals(id)).FirstOrDefault();
        item.Return(); */
        libraryItems.Where(book=>book.Id.Equals(id)).First().Return();
    }
    public List<LibraryItem> GetAllBooks(){
        return libraryItems;
    }
    public List<LibraryItem> GetAvaliableBook(){
        return libraryItems.Where(book=>book.IsAvaliable==true).ToList();
    }
    public void DeleteBook(int id){
        libraryItems.Remove(libraryItems.Where(book=>book.Id.Equals(id)).FirstOrDefault());
        System.Console.WriteLine(libraryItems.Where(book=>book.Id.Equals(id)).FirstOrDefault().ToString());
    }

    public IEnumerator GetEnumerator()
    {
        return libraryItems.GetEnumerator();
    }
}