using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Володин Артем
//
//Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
//программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

namespace Task_4
{
    class Program
    {
        private static bool Check(string Login, string Pass, int count)
        {
            if(Login == "root" & Pass == "GeekBrains")
            {
                return true;
            }
            else if(count > 0)
            {
               return false;
            }
            else
            {
               return false;
            }

        }


        static void Main(string[] args)
        {
            int counter = 3;
            do
            {
                Console.WriteLine("Введите логин: ");
                string UserLogin = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string UserPass = Console.ReadLine();

                counter--;
                if (Check(UserLogin, UserPass, counter) == false & counter > 0)
                {
                    Console.WriteLine("\nЛогин и пароль НЕверны." +
                   "\nУ вас осталось " + counter + " попыток." +
                   "\nНажмите enter, чтобы повторно ввести логин/пароль.");
                    Console.ReadLine();
                } else if(Check(UserLogin, UserPass, counter) == true)
                {
                    Console.WriteLine("\nЛогин и пароль верны.");
                    Console.ReadLine();
                    break;
                } else if(counter == 0)
                {
                    Console.WriteLine("\n" +
                  "Логин и пароль НЕверны." +
                  "\nУ вас не осталось попыток.");
                    Console.ReadLine();
                }

            } while (counter > 0);

           


        }
    }
}
