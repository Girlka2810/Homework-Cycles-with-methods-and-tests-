using System;
using Cycles;
namespace Homework_Cycle_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа.
            //Сообщите, есть ли в написании двух чисел одинаковые цифры. 
            //Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
            Console.WriteLine("Есть ли одинаковые числа?");
            Console.Write("Введите 1-ое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите 2-ое число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            string result = Cycles.FindTheSameNumber.InformAboutSameNumber(a, b);
            Console.WriteLine(result);
            }
        }
    }



