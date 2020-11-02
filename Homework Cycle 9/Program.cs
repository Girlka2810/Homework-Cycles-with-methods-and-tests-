using System;
using Cycles;
namespace Homework_Cycle_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число.Найти количество нечетных цифр этого числа.
            Console.WriteLine("Количество нечетных чисел");
            Console.WriteLine("Введите  число ");
            Console.Write("A= ");
            int a = Convert.ToInt32(Console.ReadLine());
            int oddNum = Cycles.OddNumberInNumber.FindQuantOfOddNumber(a);
            Console.WriteLine($"Количество нечетных чисел в числе {a} : {oddNum}");

        }
    }
}
