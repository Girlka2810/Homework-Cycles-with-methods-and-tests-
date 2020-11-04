using System;

namespace Cycles
{
    public class CyclesMethods
    {
        public static int RaiseAintoB(int a, int b)
        {
            int c = 1;
            for (int i = 0; i < b; i++)
            {
                c = c * a;
            }
            return c;
        }
   
        public static string FindNumbersDivededInrange1To1000OnEnteredNumber(int a)
        {
            string num = "";
            for (int i = 1; i <= 1000; i += 1)
            {
                if (i % a == 0)
                {
                    num += (i + "  ");
                }
                if (a < 1 && a > 1000)
                {
                    throw new Exception("'A' sould be in range 1 to 1000");
                }
            }
            return num;
        }
   
        public static int FindQuantityOfNumbersWhichPowLessThanA (int a)
        {
           int count = 0;
            for (int i = 1; i * i <= a; i += 1)
            {
                count += 1;
            }
            return count;
        }
    
        public static int FindNOD (int a)
        {
            int nod = 0;
            for (int i = 1; i < a; i += 1)
            {
                if (a % i == 0)
                    nod = i;
            }
            return nod;
        }
    
        public static string FindQuantityOfAllNumbersInRangeAToBDevidedTo7(int a, int b)
        {
            int sum = 0;
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                        sum += i;
                }
            }
            string c;
            if (a > b)
            {
                c = ("Сумма чисел в диапозоне от " +b+" до "+a+" : " + sum);
            }
            else
            {
                c = ("Сумма чисел в диапозоне от " + a + " до " + b + " : " + sum);
            }
            return c;
        }
    
        public static string FindFibonachiNumber (int Nfibo)
        {
            int fibo1 = 1;
            int fibo2 = 1;
            for (int i = 2; i <= Nfibo; i++)
            {
                fibo1 = fibo2 - fibo1;
                fibo2 = fibo1 + fibo2;
            }
            string result =($"{Nfibo}-ое число ряда Фибоначчи: " + fibo2);
            return result;
        }
    
        public static string SolveAlgorithmEvklida(int a, int b)
        {
            int a1 = a;
            int b1 = b;
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }
            string result = ($"Наибольший делитель чисел {a1} и {b1} : {Math.Max(a, b)} ");
            return result;
        }
    
        public static double FindCubicRoot(double n)
        {
            double rightBoarder = n;
            double leftBoarder = 0;
            double midPoint = 0;

            while (rightBoarder - leftBoarder >= 0.000001)
            {
                midPoint = (leftBoarder + rightBoarder) / 2;

                if (midPoint * midPoint * midPoint == n)
                    break;
                if (midPoint * midPoint * midPoint > n)
                {
                    rightBoarder = midPoint;
                }
                else
                {
                    leftBoarder = midPoint;
                }
            }
            return midPoint;
        }
    
        public static int FindQuantOfOddNumber (int a)
        {
           int oddNum = 0;
            int evenNum = 0;
            int a1 = a;
            while (a > 0)
            {
                if (a % 2 == 0)
                    evenNum += 1;
                else
                    oddNum += 1;
                a = a / 10;
            }
            return oddNum;
        }
    
        public static int SortMirror(int a)
        {
            int b = 0;
            while (a != 0)
            {
                b = b * 10 + a % 10;
                a = a / 10;
            }
            return b;
        }
    
        public static int FindSumOfEvenNumberBigerThanSumOfOddNum(int currentValue)
        {
            int oddNumberCount = 0;
            int evenNumberCount = 0;
            int x = 0;
            for (int i = 1; i <= currentValue; i++)
            {
                int evenNumberSum = 0;
                int oddNumberSum = 0;
                int buf = i;
                while (buf % 10 != 0)
                {
                    if (buf % 2 == 0)
                    {
                        evenNumberSum += buf % 10;
                    }
                    else
                        oddNumberSum += buf % 10;
                    buf /= 10;
                }

                if (evenNumberSum > oddNumberSum)
                    x++;
            }
            return x;
        }
   
        public static string FindTheSameNumber (int a, int b)
        {
            string s="No";
            int temp = b;
            while (a != 0)
            {

                while (b != 0)
                {
                    if (a % 10 == b % 10)
                    {
                        s = "Yes";
                    }
                    b /= 10;
                }
                b = temp;
                a /= 10;
            }
            return s;
        }
    }
}


