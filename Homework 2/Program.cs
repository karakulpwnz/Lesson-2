using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Володин Артем
//
//Написать метод, возвращающий минимальное из трех чисел.

namespace Task_1
{
    class Program
    {
        static void Print(int number)
        {
            Console.WriteLine("Минимальное число: " + number);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a <= b & a <= c)
            {
                Print(a);
            }
            else if (b <= a & b <= c)
            {
                Print(b);
            }
            else if (c <= a & c <= b)
            {
                Print(c);
            }

        }
    }
}
