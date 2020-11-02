using System;
using Cycles;
namespace Homework_cycle_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводит целое положительное число, которое является кубом числа N.
            //Найдите число N методом половинного деления. 
            Console.WriteLine("Половинное деление");
            Console.WriteLine("Введите целое положительное число N");
            Console.Write("N= ");
            double n = Convert.ToInt32(Console.ReadLine());
            double coubicroot = Cycles.FindCubicRoot.SolutionOfCubicRoot(n);
            Console.Write("Result: ");
            Console.WriteLine(coubicroot);
        }
    }
}
