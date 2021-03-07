using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  double a = 2, b = 5, c=-7, x1=0, y1=-5, x2=4, y2=3;
              int n=89;
              string s1 = "123", s2 = "456";

              //Переменные
              Console.WriteLine("  Переменные");
              Console.WriteLine("1. " + Peremennyye.SolutionEquation(a, b));
              var s3 = Peremennyye.ToSwap(s1, s2);
              Console.WriteLine($"2. {s3.Item1} {s3.Item2}");
              Console.WriteLine("3. " + Peremennyye.Division(a, b));
              Console.WriteLine("4. " + Peremennyye.SolutionLinearEquation(a, b, c));
              var ab = Peremennyye.SolutionEquationСoordinates(x1, y1, x2, y2);
              Console.WriteLine($"5. {ab.Item1} {ab.Item2} ");
              Console.WriteLine();

              //Ветвление
              Console.WriteLine("  Ветвление");
              Console.WriteLine("1. " + Vetvleniye.Solution1(a,b));
              Console.WriteLine("2. " + Vetvleniye.DefineQuarter(x1,y1));
              Console.WriteLine("3. " + Vetvleniye.OutputAscending(a,b,c));
              Console.WriteLine("4. " + Vetvleniye.SolutionOfQuadraticEquation(a, b, c));
              Console.WriteLine("5. " + Vetvleniye.TranslateToWords(n));
              Console.WriteLine();

              //Циклы
              Console.WriteLine("  Циклы");
              Console.WriteLine("1. " + Tsikly.Pow(2, 5));
              Console.WriteLine("2. " + Tsikly.DivA(250));
              Console.WriteLine("3. " + Tsikly.CountMensheA(10));
              Console.WriteLine("4. " + Tsikly.MaxDelitelA(100));
              Console.WriteLine("5. " + Tsikly.SumDiv7(1,35));
              Console.WriteLine("6. " + Tsikly.FindNFibonachi(13));
              Console.WriteLine("7. " + Tsikly.FindDivEvklida(840,1440));
              Console.WriteLine("8. " + Tsikly.FindNBinarySearch(8));
              Console.WriteLine("9. " + Tsikly.FindCountOddNumbers(123456789));
              Console.WriteLine("10. " + Tsikly.FindNumberСonversely(12345));
              Console.WriteLine("11. " + Tsikly.FindNumberSumEvenMoreSumOdd(50));
              Console.WriteLine("12. " + Tsikly.FindSameNumbers(500, 99));
              Console.WriteLine();
              */
            // Одномерные массивы
            Console.WriteLine("  Одномерные массивы");
            int n = 10;
            int[] a = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(1, n);
                Console.Write(a[i] + " ");
            }
           
            Console.WriteLine(); /*
            Console.WriteLine("1. Минимальный элемент массива: " + OneArray.FindMinArray(a));
            Console.WriteLine("2. Максимальный элемент массива: " + OneArray.FindMaxArray(a));
            Console.WriteLine("3. Индекс минимального элемента массива: " + OneArray.FindIndMinArray(a));
            Console.WriteLine("4. Индекс максимального элемента массива: " + OneArray.FindIndMaxArray(a));
            Console.WriteLine("5. Cумма элементов массива с нечетными индексами: " + OneArray.FindSumArrayOddInd(a));
            */
            //Console.WriteLine("6. Реверс массива: ");
            //OneArray.ReverseArray(a);

            Console.WriteLine("7. Количество нечетных элементов массива: " + OneArray.CountOddArray(a));

            //Console.WriteLine("8. Поменять местами первую и вторую половину массива: ");           
            //OneArray.SwapHalfArray(a);

            //Console.WriteLine("9. Отсортировать массив по возрастанию : ");
            //OneArray.SortArrayAscending(a);

            Console.WriteLine("10. Отсортировать массив по убыванию : ");
            OneArray.SortArrayDescending(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
