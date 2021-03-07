using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Переменные
            Console.WriteLine("  Переменные");
            double a = 2, b = 5, c=-7, x1=0, y1=-5, x2=4, y2=3;
            int n=89;
            string s1 = "123", s2 = "456";
            
            Console.WriteLine("1. " + Peremennyye.SolutionEquation(a, b));
            var s3 = Peremennyye.ToSwap(s1, s2);
            Console.WriteLine($"2. {s3.Item1} {s3.Item2}");
            Console.WriteLine("3. " + Peremennyye.Division(a, b));
            Console.WriteLine("4. " + Peremennyye.SolutionLinearEquation(a, b, c));
            var ab = Peremennyye.SolutionEquationСoordinates(x1, y1, x2, y2);
            Console.WriteLine($"5. {ab.Item1} {ab.Item2} ");

            //Ветвление
            Console.WriteLine("  Ветвление");
            Console.WriteLine("1. " + Vetvleniye.Solution1(a,b));
            Console.WriteLine("2. " + Vetvleniye.DefineQuarter(x1,y1));
            Console.WriteLine("3. " + Vetvleniye.OutputAscending(a,b,c));
            Console.WriteLine("4. " + Vetvleniye.SolutionOfQuadraticEquation(a, b, c));
            Console.WriteLine("5. " + Vetvleniye.TranslateToWords(n));
        }
    }
}
