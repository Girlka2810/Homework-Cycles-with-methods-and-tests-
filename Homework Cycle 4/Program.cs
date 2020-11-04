using System;
using Cycles;
namespace Homework_Cycle_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит 1 число(A).
            //Вывести наибольший делитель(кроме самого A) числа A.
            
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Наибольший делитель числа " + a);
            int nod = Cycles.CyclesMethods.FindNOD(a);
            Console.WriteLine("Наибольший делитель: "+nod);
        }
    }
}
