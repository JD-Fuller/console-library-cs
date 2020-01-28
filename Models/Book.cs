using System.Collections.Generic;

namespace console_library.Models
{
  public class Book
  {

    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; } = true;



    /// Constructor
    public Book(string title, string author)
    {
      //When defining parameters for Book constructor, we have to declare both the data type and teh name of the parameter
      Title = title;
      Author = author;
    }


  }
}