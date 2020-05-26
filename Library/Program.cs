using System;

namespace Library
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library(bookOne, bookTwo, bookThree);

            Console.WriteLine(bookOne.Title, bookOne.Year, bookOne.Authors);
            Console.WriteLine(bookThree.Year);
            

            Console.WriteLine("Any Key to Quit!");
            Console.ReadLine();
        }
    }
}
