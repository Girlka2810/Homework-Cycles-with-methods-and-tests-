using System;
using Cycles;
namespace Homework_Cycle_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит целое положительное  число(N).
            //Выведите количество чисел в диапазоне от 1 до N, 
            //сумма четных цифр которых больше суммы нечетных. 
            Console.WriteLine("Сумма четных цифр больше суммы нечетных");
            Console.WriteLine("Введите целое положительное число");
            int currentValue = Convert.ToInt32(Console.ReadLine());
            int x = Cycles.SumOfEvenNumberBigerThanSumOfOddNum.SumEvenNumMore(currentValue);
            Console.WriteLine($"Количество количество чисел в диапазоне от 1 до {currentValue} сумма четных цифр которых больше суммы нечетных равно {x}");
        }   
    }
}
