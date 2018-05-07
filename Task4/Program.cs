using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            var bannanaColor = new string[] { "a. Red", "b. Green", "c. Yellow", "d. Blue", "e. Purple" };
            bool answerIsCorrect = false;

            Console.WriteLine("What is the color of Banana?");
            int i = 0;
            foreach (var elem in bannanaColor)
            {
                Console.WriteLine(elem);
                i++;
            };
            do
            {
                Console.WriteLine("Write a letter with correct answer:");
                string answer1 = Console.ReadLine();
                if (answer1 != "c")
                {
                    Console.WriteLine("No it's not. Retry (y/n)?");
                    string answer2 = Console.ReadLine();
                    if (answer2.ToLower() == "n")
                    {
                        Console.WriteLine("Well, I see. You don't know the correct answer");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Yes! It's Yellow!");
                    answerIsCorrect = true;
                }

            } while (answerIsCorrect != true);
            Console.ReadLine();
        }
    }
}