using System;
using Cycles;
namespace Homework_Cycle_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число(N).Выведите N - ое число ряда фибоначчи.
            //В ряду фибоначчи каждое следующее число является суммой двух предыдущих. 
            //Первое и второе считаются равными 1.
            
            Console.WriteLine("Введите число");
            int Nfibo = Convert.ToInt32(Console.ReadLine());
            string result = Cycles.FindFibonachiNumber.FibonachiNumber(Nfibo);
            Console.WriteLine(result);
        }
    }
}
