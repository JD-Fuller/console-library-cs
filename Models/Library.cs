using System.Collections.Generic;

namespace console_library.Models
{
  //Class is defined for Library
  public class Library
  {
    public string Location { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();

    public void AddBook(Book b)
    {
      Books.Add(b);
    }
    public void AddBook(List<Book> books)
    {
      Books.AddRange(books);
    }

    public Library(string location, string name)
    {
      Location = location;
      Name = name;
    }



    //HELPER METHOD
    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        System.Console.WriteLine($"{i + 1} {Books[i].Title}");
      }
    }


  }


}