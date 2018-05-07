using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter correct password:");
            string passenter = Console.ReadLine();
            while (passenter != "root")
            {
                Console.WriteLine("Incorrect password. Please enter again");
                passenter = Console.ReadLine();
            }
            Console.WriteLine("Password correct.");
            Console.ReadLine();
        }
    }
}