using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Володин Артем
//
//Написать метод подсчета количества цифр числа.

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = number;
            int i = 0;
            while (number2 != 0) {
                number2 = number2 / 10;
                i++;
            }
            Console.WriteLine("Число знаков: " + i);
            Console.ReadLine();
        }
    }
}
