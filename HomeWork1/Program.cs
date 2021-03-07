using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Переменные
            double a = 2, b = 5, c=2, x1=2, y1=5, x2=2, y2=3;
            string s1 = "123", s2 = "456";
            
            Console.WriteLine("1. " + Variables.SolutionEquation(a, b));
            var s3 = Variables.ToSwap(s1, s2);
            Console.WriteLine($"2. {s3.Item1} {s3.Item2}");
            Console.WriteLine("3. " + Variables.Division(a, b));
            Console.WriteLine("4. " + Variables.SolutionLinearEquation(a, b, c));
            var ab = Variables.SolutionEquationСoordinates(x1, y1, x2, y2);
            Console.WriteLine($"5. {ab.Item1} {ab.Item2} ");

            //Ветвление


        }
    }
}
