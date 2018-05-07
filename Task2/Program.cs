using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum = sum + i;

            }
            Console.WriteLine("Сумма: " + sum);
            Console.ReadLine();
        }
    }
}