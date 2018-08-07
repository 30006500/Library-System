using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book;

namespace Add
{
    class Program

    {
        static int menu = 0;
        static int counter = 0;
                
        static void Main(string[] args)
        {
            
            do
            {
                Console.WriteLine("1) Add a new book");
                Console.WriteLine("2) Return to the main menu");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Add.Program.NewBook();
                        break;
                    case 2:
                        break;
                    
                }

            } while (menu != 2);
        }

        public static void NewBook()
        {

            counter = counter + 1;
            Book.Book[] newbook = new Book.Book[counter];
           
            newbook[counter] = new Book.Book("", "", "", "", "", 0);
            Console.WriteLine("Please enter the title of the book");
            newbook[counter].Title = Console.ReadLine();
            Console.WriteLine("Please enter the Last name of the author");
            newbook[counter].AuthorLName = Console.ReadLine();
            Console.WriteLine("Please enter the First name of the author");
            newbook[counter].AuthorFName = Console.ReadLine();
            Console.WriteLine("Please enter the Category of the book");
            newbook[counter].Category = Console.ReadLine();
            Console.WriteLine("Please enter the Location of the book");
            newbook[counter].Location = Console.ReadLine();
            Console.WriteLine("Please enter the ISBN of the book");
            newbook[counter].ISBN = double.Parse(Console.ReadLine());
            Console.WriteLine(newbook[counter].Title);
            Console.ReadLine();
            
        }

    }
}
