using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Add;
using View;

namespace Library
{
    public class Program
    {

        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Library System");
                Console.WriteLine();
                Console.WriteLine("1) Add Or Edit A Book");
                Console.WriteLine("2) View Details Of A Book");
                Console.WriteLine("3) Exit");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        string password = "Password";
                        Console.WriteLine("Please enter your password");
                        string pass = Console.ReadLine();
                        if (pass == password)
                        {
                            Add.Program.Main();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect Password");
                            Console.ReadLine();
                        }
                        
                    break;
                    case 2:
                        //View.Program.Main();
                        break;
                    case 3:
                        break;
                    default:
                        break;


                }
            } while (option != 3);

        }
    }
}
