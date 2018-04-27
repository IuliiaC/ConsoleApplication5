using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main()
        {
            var fruitArray = new string[] { "apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry"};
            string findap = "ap";
            string symbolA = "a";
            string symbolB = "p";



            for (int i = 0; i < fruitArray.Length; i++)
            {
                string m = fruitArray[i];
               bool b = m.Contains(findap);
                if (b)
                {
                    Console.WriteLine("подходит " + fruitArray[i] + "lalala");
                }
            }
            Console.ReadLine();
        }
    }
}
