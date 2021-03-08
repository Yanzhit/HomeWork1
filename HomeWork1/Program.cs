using System;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
              double a = 2, b = 5, c=-7, x1=0, y1=-5, x2=4, y2=3;
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
             
            // Одномерные массивы
            Console.WriteLine("  Одномерные массивы");
            int m = 10;
            int[] mas = new int[m];
            Random random = new Random();
            for (int i = 0; i < m; i++)
            {
                mas[i] = random.Next(1, m);
                Console.Write(mas[i] + " ");
            }
           
            Console.WriteLine(); 
            Console.WriteLine("1. Минимальный элемент массива: " + OneArray.FindMinArray(mas));
            Console.WriteLine("2. Максимальный элемент массива: " + OneArray.FindMaxArray(mas));
            Console.WriteLine("3. Индекс минимального элемента массива: " + OneArray.FindIndMinArray(mas));
            Console.WriteLine("4. Индекс максимального элемента массива: " + OneArray.FindIndMaxArray(mas));
            Console.WriteLine("5. Cумма элементов массива с нечетными индексами: " + OneArray.FindSumArrayOddInd(mas));
            Console.WriteLine("7. Количество нечетных элементов массива: " + OneArray.CountOddArray(mas));
            
            Console.WriteLine("6. Реверс массива: ");
            OneArray.ReverseArray(mas);
            OneArray.OutPut(mas);

            Console.WriteLine("8. Поменять местами первую и вторую половину массива: ");           
            OneArray.SwapHalfArray(mas);
            OneArray.OutPut(mas);

            Console.WriteLine("9. Отсортировать массив по возрастанию : ");
            OneArray.SortArrayAscending(mas);
            OneArray.OutPut(mas);

            Console.WriteLine("10. Отсортировать массив по убыванию : ");
            OneArray.SortArrayDescending(mas);
            OneArray.OutPut(mas);
            
            Console.WriteLine();

            // Двумерные массивы
            Console.WriteLine("  Двумерные массивы");
            
            int rows=5, columns = 5;
            int[,] array = new int[rows, columns];
            Random rand = new Random();
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = rand.Next(10, 50);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine();

            Console.WriteLine("1. Минимальный элемент массива: " + TwoArray.FindMinTwoArray(array, rows, columns));
            Console.WriteLine("2. Максимальный элемент массива: " + TwoArray.FindMaxTwoArray(array, rows, columns));
            Console.WriteLine("3. Индекс минимального элемента массива: " + TwoArray.FindIndMinTwoArray(array, rows, columns));
            Console.WriteLine("4. Индекс минимального элемента массива: " + TwoArray.FindIndMaxTwoArray(array, rows, columns));
            Console.WriteLine("5. Кол-во эл-в массива, которые больше всех своих соседей: " + TwoArray.FindCountMaxTwoArray(array, rows, columns));

            Console.WriteLine("6. Отразить массив относительно его главной диагонали: ");

            int[,] ar = TwoArray.FlipArrayRelativeMainDiagonal(array, rows, columns);
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(ar[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
