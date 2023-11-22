Library library1 = new Library();
Book book1 = new Book(1, "Suc ve Ceza", new Authors(1, "Mohammed", "Almashhor"), DateTime.Now);
Book book2 = new Book(2, "Suc ve Ceza", new Authors(1, "Mohammed", "Almashhor"), DateTime.Now);
Book book3 = new Book(3, "Suc ve Ceza", new Authors(1, "Mohammed", "Almashhor"), DateTime.Now);
Book book4 = new Book(4, "Suc ve Ceza", new Authors(1, "Mohammed", "Almashhor"), DateTime.Now);
Book book5 = new Book(5, "Suc ve Ceza", new Authors(1, "Mohammed", "Almashhor"), DateTime.Now);
library1.CreatBook(book1);
library1.CreatBook(book2);
library1.CreatBook(book3);
library1.CreatBook(book4);
library1.CreatBook(book5);
library1.GiveBook(1);
foreach (var item in library1.GetAvaliableBook())
{
    System.Console.WriteLine(item.ToString());

}
library1.GiveBook(2);
foreach (var item in library1.GetAvaliableBook())
{
    System.Console.WriteLine(item.ToString());

}
library1.GiveBook(1);
library1.TakeBook(1);
foreach (var item in library1.GetAvaliableBook())
{
    System.Console.WriteLine(item.ToString());

}