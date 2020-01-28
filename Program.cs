using System;
using System.Collections.Generic;
using console_library.Models;


namespace console_library
{
  class Program
  {
    static void Main(string[] args)
    {

      Library library = new Library("Boise Idaho", "Boise Public Library");

      Book fightClub = new Book("Fight Club", "Chuck Palahniuk");
      Book hatchet = new Book("The Hatchet", "Gary Paulsen");
      Book hobbit = new Book("The Hobbit", "J.R.R. Tolkien");

      Book huckleBerryFinn = new Book("Huckleberry Finn", "Mark Twain");

      library.AddBook(new List<Book>() { fightClub, hatchet, hobbit });

      foreach (Book b in library.Books)
      {
        System.Console.Write(b.Title);
      }










    }
  }
}
