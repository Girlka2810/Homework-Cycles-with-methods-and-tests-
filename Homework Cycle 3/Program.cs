using System;
using Cycles;
namespace Homework_Cycle_3
{
    class Program
        
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число(A).
            //Найдите количество положительных целых чисел, квадрат которых меньше A.
            
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Числа квадрат которых меньше " + a);
            int quantity = Cycles.CyclesMethods.FindQuantityOfNumbersWhichPowLessThanA(a);
            Console.WriteLine("Количество положительных чисел: " + quantity);
        }   
    }
}
