using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1
{
    public static class OneArray
    {
        // 1. Найти минимальный элемент массива
        public static int FindMinArray(int[] a)
        {
            int  min = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }

        // 2. Найти максимальный элемент массива
        public static int FindMaxArray(int[] a)
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                }
            }
            return max;
        }

        // 3. Найти индекс минимального элемента массива
        public static int FindIndMinArray(int[] a)
        {
            int min = a[0], indMin = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                    indMin = i;
                }
            }
            return indMin;
        }

        // 4. Найти индекс максимального элемента массива
        public static int FindIndMaxArray(int[] a)
        {
            int max = a[0], indMax = 0;
            for (int i = 1; i < a.Length; i++)
            {
                if (max < a[i])
                {
                    max = a[i];
                    indMax = i;
                }
            }
            return indMax;
        }

        // 5. Посчитать сумму элементов массива с нечетными индексами
        public static int FindSumArrayOddInd(int[] a)
        {
            int sum = 0;
            for (int i = 1; i < a.Length; i += 2)
            {
                sum += a[i];
            }
            return sum;
        }

        // 6. Сделать реверс массива (массив в обратном направлении)
        public static int[] ReverseArray(int[] a)
        {
            int tmp, n= a.Length; 
            for (int i = 0; i < n / 2; i++)
            {
                tmp = a[i];
                a[i] = a[n - i - 1];
                a[n - i - 1] = tmp;
            }
            return a;
        }

        // 7. Посчитать количество нечетных элементов массива
        public static int CountOddArray(int[] a)
        {
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    k += 1;
                }
            }
            return k;
        }

        // 8. Поменять местами первую и вторую половину массива, 
        //    например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        public static int[] SwapHalfArray(int[] a)
        {
            int tmp, n= a.Length;
            for (int i = 0; i != (n / 2); i++)
            {
                if (n % 2 == 0)
                {
                    tmp = a[i + n / 2];
                    a[i + n / 2] = a[i];
                    a[i] = tmp;
                }
                else
                {
                    tmp = a[i + n / 2 + 1];
                    a[i + n / 2 + 1] = a[i];
                    a[i] = tmp;
                }
            }
            return a;
        }

        // 9. Отсортировать массив по возрастанию одним из способов:  
        //    пузырьком(Bubble), выбором (Select) или вставками (Insert)) 
        public static int[] SortArrayAscending(int[] array)
        {
            int tmp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        tmp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = tmp;
                    }
                }
            }
            return array;
        }

        // 10. Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :  
        //     пузырьком(Bubble), выбором (Select) или вставками (Insert))
        public static int[] SortArrayDescending(int[] array)
        {
            int tmp;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int indexOfMax = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[indexOfMax] < array[j])
                    {
                        indexOfMax = j;
                    }
                }
                tmp = array[i];
                array[i] = array[indexOfMax];
                array[indexOfMax] = tmp;
            }
            return array;
        }
    }
}
