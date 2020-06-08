using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To PhoneBook");
            Console.WriteLine("*--------------------------------------*");
            Console.WriteLine("");
            Console.WriteLine("Add a Contact");
            Console.WriteLine("Delete a Contact");
            Console.WriteLine("Update a Contatct");
            Console.WriteLine("Search by Name");
            Console.WriteLine("Search by Number");
            Console.WriteLine("");
            Console.Write("Please Select Option");
            string option = Console.ReadLine();
        }
    }
}
