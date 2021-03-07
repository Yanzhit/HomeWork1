using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1
{
    public static class Vetvleniye
    {
        
        //Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
        public static double Solution1(double a, double b)
        {
            if (a > b)
            {
                return a + b;
            }
            else
            {
                if (a == b)
                {
                    return a * b;
                }
                else
                {
                    return a - b;
                }
            }
        }
        
        // Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
        public static string DefineQuarter(double x, double y)
        {
            string str="";
            if (x > 0 && y > 0)
            {
                str="Координата принадлежит I четверти.";
            }
            if (x < 0 && y > 0)
            {
                str = "Координата принадлежит II четверти.";
            }
            if (x < 0 && y < 0)
            {
                str = "Координата принадлежит III четверти.";
            }
            if (x > 0 && y < 0)
            {
                str = "Координата принадлежит IV четверти.";
            }
            if (x == 0 || y == 0)
            {
                str = "Точка лежит на оси.";
            }
            return str;
        }
        
        //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
        public static string OutputAscending(double a, double b, double c)
        {
            string str = "";
            if (a > b && a > c)
            {
                if (b > c)
                {
                    str = Convert.ToString(c) + Convert.ToString(b) + Convert.ToString(a);
                }
                else
                {
                    str = Convert.ToString(b) + Convert.ToString(c) + Convert.ToString(a);
                }
            }
            else
            {
                if (b > a && b > c)
                {
                    if (a > c)
                    {
                        str = Convert.ToString(c) + Convert.ToString(a) + Convert.ToString(b);
                    }
                    else
                    {
                        str = Convert.ToString(a) + Convert.ToString(c) + Convert.ToString(b);
                    }
                }
                else
                {
                    if (a > b)
                    {
                        str = Convert.ToString(b) + Convert.ToString(a) + Convert.ToString(c);
                    }
                    else
                    {
                        str = Convert.ToString(a) + Convert.ToString(b) + Convert.ToString(c);
                    }
                }
            }
            return str;
        }
        
        // Пользователь вводит 3 числа (A, B и С). 
        // Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.
        public static string SolutionOfQuadraticEquation(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            string x="";
            if (d == 0)
            {
                x=Convert.ToString(FindX(a,b));

            }
            else
            {
                if (d > 0)
                {
                    x = Convert.ToString(FindX1(a, b, d))+"   "+ Convert.ToString(FindX2(a, b, d));
                }
                else
                {
                    x="Нет корней уравнения";
                }
            }
            return x;
        }
        private static double FindX(double a, double b)
        {
            if (a == 0)
            {
                throw new Exception("Не возможно решить уравнение т.к. 2*a = 0");
            }
            else
            {
                return (-b) / (2 * a);
            }
        }
        private static double FindX1(double a, double b, double d)
        {
            if (a == 0)
            {
                throw new Exception("Не возможно решить уравнение т.к. 2*a = 0");
            }
            else
            {
                return (-b - Math.Sqrt(d)) / (2 * a);
            }
        }
        private static double FindX2(double a, double b, double d)
        {
            if (a == 0)
            {
                throw new Exception("Не возможно решить уравнение т.к. 2*a = 0");
            }
            else
            {
                return (-b + Math.Sqrt(d)) / (2 * a);
            }
        }

        //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. 
        //Например при вводе “25” в консоль будет выведено “двадцать пять”.
        public static string TranslateToWords(int a)
        {
            int desyatki, edinizi;
            string str="";
            desyatki = a / 10;
            edinizi = a % 10;
            if (desyatki == 1)
            {
                switch (edinizi)
                {
                    case 0:
                        str = "Десять";
                        break;
                    case 1:
                        str = "Одиннадцать";
                        break;
                    case 2:
                        str = "Двенадцать";
                        break;
                    case 3:
                        str = "Тринадцать";
                        break;
                    case 4:
                        str = "Четырнадцать";
                        break;
                    case 5:
                        str = "Пятнадцать";
                        break;
                    case 6:
                        str = "Шестнадцать";
                        break;
                    case 7:
                        str = "Семнадцать";
                        break;
                    case 8:
                        str = "Восемнадцать";
                        break;
                    case 9:
                        str = "Девятнадцать";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (desyatki)
                {
                    case 2:
                        str = "Двадцать";
                        break;
                    case 3:
                        str = "Тридцать";
                        break;
                    case 4:
                        str = "Сорок";
                        break;
                    case 5:
                        str = "Пятьдесят";
                        break;
                    case 6:
                        str = "Шестьдесят";
                        break;
                    case 7:
                        str = "Семьдесят";
                        break;
                    case 8:
                        str = "Восемьдесят";
                        break;
                    default:
                        str = "Девяносто";
                        break;
                }

                switch (edinizi)
                {
                    case 1:
                        str = str + "один";
                        break;
                    case 2:
                        str = str + "два";
                        break;
                    case 3:
                        str = str + "три";
                        break;
                    case 4:
                        str = str + "четыре";
                        break;
                    case 5:
                        str = str + "пять";
                        break;
                    case 6:
                        str = str + "шесть";
                        break;
                    case 7:
                        str = str + "семь";
                        break;
                    case 8:
                        str = str + "восемь";
                        break;
                    case 9:
                        str = str + "девять";
                        break;
                    default:
                        break;
                }
            }
            return str;
        }
    }
}
