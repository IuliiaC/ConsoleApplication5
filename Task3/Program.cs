using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum3 = 0;
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine(i);
                sum3 = sum3 + i;
            }
            Console.WriteLine("Сумма : " + sum3);
            Console.ReadLine();
        }
    }
}
