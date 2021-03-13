using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1
{
    public static class Peremennyye
    {
        // Решение уравнения (5 * a + b * b) / (b - a)

        public static double SolutionEquation(double a, double b)
        {
            if (a==b)
            {
                throw new Exception("Не возможно решить уравнение т.к. B-A = 0 ");                
            }
            else
            {
                return (5 * a + b * b) / (b - a);
            }
        }

        // Поменять местами А и В

        public static void ToSwap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        // Деление А на В

        public static double Division(double a, double b)
        {
            if (b == 0)
            {
                throw new Exception("Не возможно решить уравнение т.к. b = 0 ");
            }
            else
            {
                return a / b;
            }
        }

        // Решение линейного уравнения стандартного вида

        public static double SolutionLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("Не возможно решить уравнение т.к. a = 0 ");
            }
            else
            {
                return (c - b) / a;
            }
        }

        // Решение уравнения по кооординатам
        
        public static (double, double) SolutionEquationСoordinates(double x1, double y1, double x2, double y2)
        {
            if (x1 == x2)
            {
                throw new Exception("Не возможно решить уравнение т.к. x1 - x2 = 0");
            }
            else
            {
                double a, b;
                a = (y1 - y2) / (x1 - x2);
                b = y2 - a * x2;
                return (a, b);
            }
        }
    }
}
