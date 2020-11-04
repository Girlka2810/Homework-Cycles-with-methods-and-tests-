using System;
using Cycles;
namespace Homework_Cycle_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа.
            //Найти их наибольший общий делитель используя алгоритм Евклида.
            Console.WriteLine("Алгоритм Евклида");
            Console.WriteLine("Введите первое число");
            Console.Write("A= ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            Console.Write("B= ");
            int b = Convert.ToInt32(Console.ReadLine());
            string result = Cycles.CyclesMethods.SolveAlgorithmEvklida(a, b);
            Console.WriteLine(result);
        }
    }
}
