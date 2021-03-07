using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1
{
    public static class Tsikly
    {
        // 1. Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
        public static double Pow(double a, double b)
        {
            double c=1;
            for (int i = 0; i < b; i++)
            {
                c = c * a;
            }
            return c;
        }

        // 2. Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
        public static string DivA(int a)
        {
            string str = "";
            if (a == 0)
            {
                throw new Exception("Error A = 0 ");
            }
            else
            { 
                for (int i = a; i <= 1000; i += a)
                {
                    str = str + Convert.ToString(i) + " ";
                }
            }
            return str;
        }

        // 3. Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
        public static int CountMensheA(int a)
        {
            int k = 0;
            for (int i = 1; i * i < a; i++)
            {
                k++;
            }
            return k;
        }

        // 4. Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
        public static int MaxDelitelA(int a)
        {
            int d = 0;
            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    d = i;
                }
            }
            return d;
        }

        // 5. Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, 
        //    которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
        public static int SumDiv7(int a, int b)
        {
            int s = 0;
            if (b > a)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i % 7 == 0)
                    {
                        s += i;
                    }
                }
            }
            else
            {
                for (int i = b; i <= a; i++)
                {
                    if (i % 7 == 0)
                    {
                        s += i;
                    }
                }
            }
            return s;
        }

        // 6. Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. 
        public static int FindNFibonachi(int n)
        {
            int f1 = 1, f2 = 1, f3;
            for (int i = 3; i <= n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            return f2;
        }

        // 7. Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
        public static int FindDivEvklida(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            return a;
        }

        // 8. Пользователь вводит целое положительное число, которое является кубом целого числа N. 
        //    Найдите число N методом половинного деления.
        public static ulong FindNBinarySearch(ulong a)
        {
            ulong mid = 0, min = 0, max=a;
            while (min <= max)
            {
                mid = (min + max) / 2;
                if (mid * mid * mid > a)
                {
                    max = mid - 1;
                }
                else
                {
                    if (mid * mid * mid < a)
                    {
                        min = mid + 1;
                    }
                    else
                    {
                        min = max + 1;
                    }
                }
            }
            if (mid * mid * mid != a)
            {
                throw new Exception("Число A не является кубом целого числа ");
            }
            else
            {
                return mid;
            }
        }

        // 9. Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
        public static int FindCountOddNumbers(int a)
        {
            int k = 0;
            while (a != 0)
            {
                int tmp = a % 10;
                if (tmp % 2 != 0)
                {
                    k++;
                }
                a /= 10;
            }
            return k;
        }

        // 10. Пользователь вводит 1 число. 
        //     Найти число, которое является зеркальным отображением последовательности цифр заданного числа, 
        //     например, задано число 123, вывести 321.
        public static long FindNumberСonversely(long n)
        {
            long a = n, b = 0;
            while (a != 0)
            {
                b = b * 10 + a % 10;
                a = a / 10;
            }
            return b;
        }
        
        // 11. Пользователь вводит целое положительное  число (N). 
        //     Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 
        public static string FindNumberSumEvenMoreSumOdd(int n)
        {
            int a, b, sumEven, sumOdd;
            string str="";
            for (int i = 1; i <= n; i++)
            {
                b = i;
                sumEven = 0;
                sumOdd = 0;
                while (b != 0)
                {
                    a = b % 10;
                    b = b / 10;
                    if (a % 2 == 0)
                    {
                        sumEven += a;
                    }
                    else
                    {
                        sumOdd += a;
                    }
                }
                if (sumEven > sumOdd)
                {
                    str += i + " ";
                }
            }
            return str;
        }
        

        // 12. Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. 
        //     Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
        public static string FindSameNumbers(int a, int b)
        {
            int mod1, mod2, div2, k = 0;
            string str;
            while (a != 0)
            {
                mod1 = a % 10;
                a = a / 10;
                div2 = b;
                while (div2 != 0)
                {
                    mod2 = div2 % 10;
                    div2 = div2 / 10;
                    if (mod1 == mod2)
                    {
                        k = 1;
                    }
                }

            }
            if (k == 1)
            {
                str="Да";
            }
            else
            {
                str = "Нет";
            }
            return str;
        }
    }
}
