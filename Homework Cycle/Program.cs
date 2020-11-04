using System;
using Cycles;
namespace Console_Cycle 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Cycles.CyclesMethods.RaiseAintoB(a, b);
            Console.Write("Результат: ");
            Console.WriteLine(c);
        }
    }
}
