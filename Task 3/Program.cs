using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Володин Артем
//
//С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int summ = 0;
            while (true)
            {
                Console.WriteLine("Введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                if(number > 0)
                {
                    if((number % 2) == 1)
                    {
                        summ = summ + number;
                    }
                }
                else if(number == 0)
                {
                    Console.WriteLine("Сумма всех нечётных положительных чисел равна: " + summ);
                    break;
                }
            }

            Console.ReadLine();
        }
    }
}
