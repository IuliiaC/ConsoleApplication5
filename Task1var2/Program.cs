using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1var2
{
    class Program
    {
        static void Main()
        {
            var fruitArray = new string[] { "Apple", "Avocado", "Banana", "Apricot", "Jackfruit", "Cherimoya", "Papaya", "Pineapple", "Lime", "Lemon", "Grape", "Orange", "Grapefruit", "Strawberry" };
            Console.WriteLine("Suitable: ");
            for (int i = 0; i < fruitArray.Length; i++)
            {
                string m = fruitArray[i].ToLower();
                if (!m.Contains("ap"))
                {
                    Console.WriteLine(fruitArray[i]);
                }
            }
            Console.ReadLine();
        }
    }
}