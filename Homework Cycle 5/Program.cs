using System;
using Cycles;
namespace Homework_Cycle_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 2 числа(A и B).
            //Вывести сумму всех чисел из диапазона от A до B, которые делятся на 7. 
            //(Учтите, что при вводе B может оказаться меньше A).
           
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            string sum = Cycles.CyclesMethods.FindQuantityOfAllNumbersInRangeAToBDevidedTo7(a, b);
            Console.WriteLine(sum);
        }
    }
}
