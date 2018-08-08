using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Add;
using Book;

namespace View
{
    public class Program
    {
        public static void Main()
        {
            //Book1
            Console.WriteLine("Please enter in a book name...ie(Book1)");
            Console.ReadLine();
            Console.WriteLine("Title: {0}", Add.Program.Book1.Title);
            Console.WriteLine("Author Last Name: {0}", Add.Program.Book1.AuthorLName);
            Console.WriteLine("Author First Name: {0}", Add.Program.Book1.AuthorFName);
            Console.WriteLine("Category: {0}", Add.Program.Book1.Category);
            Console.WriteLine("Location: {0}", Add.Program.Book1.Location);
            Console.WriteLine("ISBN: {0}", Add.Program.Book1.ISBN);
        }   
    }
} //static Book.Book Book1 = new Book.Book("", "", "", "", "", 0);
