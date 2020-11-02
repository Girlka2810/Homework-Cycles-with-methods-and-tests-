using System;
using Cycles;
namespace Homework_Cycle_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число.
            //Найти число, которое является зеркальным отображением последовательности цифр заданного 
            //числа, например, задано число 123, вывести 321.
            Console.WriteLine("Число задом на перед");
            Console.WriteLine("Введите  число ");
            Console.Write("A= ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Cycles.MirrorSort.ChangePositionsOfNum(a);
            Console.WriteLine($"Число {a} в обратном порядке: {b}");
        }
    }
}
