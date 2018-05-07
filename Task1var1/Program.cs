using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1var1
{
    class Program
    {
        static void Main()
        {
            var fruitArray = new string[] { "apple", "avocado", "banana", "apricot", "jackfruit", "cherimoya", "papaya", "pineapple", "lime", "lemon", "grape", "orange", "grapefruit", "strawberry" };
            string findap = "ap";
            Console.WriteLine("Suitable: ");
            for (int i = 0; i < fruitArray.Length; i++)
            {
                string m = fruitArray[i];
                if (!m.Contains(findap))
                {
                    Console.WriteLine(m);
                }
            }
            Console.ReadLine();
        }
    }
}
