using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork1
{
    public static class TwoArray
    {
        // 1. Найти минимальный элемент массива
        public static int FindMinTwoArray(int[,] array, int rows, int columns)
        {
            if (array.Length == 0)
            {
                throw new Exception("Массив пустой");
            }
            else
            {
                int min = array[0, 0];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (min > array[i, j])
                        {
                            min = array[i, j];
                        }
                    }
                }
                return min;
            }
        }

        // 2. Найти максимальный элемент массива
        public static int FindMaxTwoArray(int[,] array, int rows, int columns)
        {
            if (array.Length == 0)
            {
                throw new Exception("Массив пустой");
            }
            else
            {
                int max = array[0, 0];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (max < array[i, j])
                        {
                            max = array[i, j];
                        }
                    }
                }
                return max;
            }
        }

        // 3. Найти индекс минимального элемента массива
        public static (int, int) FindIndMinTwoArray(int[,] array, int rows, int columns)
        {
            if (array.Length == 0)
            {
                throw new Exception("Массив пустой");
            }
            else
            {
                int min = array[0, 0], indexOfMinRows = 0, indexOfMinColumns = 0; ;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (min > array[i, j])
                        {
                            min = array[i, j];
                            indexOfMinRows = i;
                            indexOfMinColumns = j;
                        }
                    }
                }
                return (indexOfMinRows, indexOfMinColumns);
            }
        }

        // 4. Найти индекс максимального элемента массива
        public static (int, int) FindIndMaxTwoArray(int[,] array, int rows, int columns)
        {
            if (array.Length == 0)
            {
                throw new Exception("Массив пустой");
            }
            else
            {
                int max = array[0, 0], indexOfMaxRows = 0, indexOfMaxColumns = 0; ;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (max < array[i, j])
                        {
                            max = array[i, j];
                            indexOfMaxRows = i;
                            indexOfMaxColumns = j;
                        }
                    }
                }
                return (indexOfMaxRows, indexOfMaxColumns);
            }
        }

        // 5. Найти количество элементов массива, которые больше всех своих соседей одновременно
        public static int FindCountMaxTwoArray(int[,] array, int rows, int columns)
        {
            if (array.Length == 0)
            {
                throw new Exception("Массив пустой");
            }
            else
            {
                int k = 0, indMaxRows = rows - 1, indMaxColumns = columns - 1;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        // соседи угловых элементов массива.
                        if (i == 0 && j == 0)
                        {
                            if (array[i, j] > array[i + 1, j] &&
                                array[i, j] > array[i, j + 1] &&
                                array[i, j] > array[i + 1, j + 1])
                            {
                                k += 1;
                                Console.Write($"{array[i, j]}");
                                Console.WriteLine();
                            }
                        }
                        if (i == 0 && j == indMaxColumns)
                        {
                            if (array[i, j] > array[i, j - 1] &&
                                array[i, j] > array[i + 1, j - 1] &&
                                array[i, j] > array[i + 1, j])
                            {
                                k += 1;
                                Console.Write($"{array[i, j]}");
                                Console.WriteLine();
                            }
                        }
                        if (i == indMaxRows && j == 0)
                        {
                            if (array[i, j] > array[i - 1, j] &&
                                array[i, j] > array[i - 1, j + 1] &&
                                array[i, j] > array[i, j + 1])
                            {
                                k += 1;
                                Console.Write($"{array[i, j]}");
                                Console.WriteLine();
                            }
                        }
                        if (i == indMaxRows && j == indMaxColumns)
                        {
                            if (array[i, j] > array[i - 1, j] &&
                                array[i, j] > array[i - 1, j - 1] &&
                                array[i, j] > array[i, j - 1])
                            {
                                k += 1;
                                Console.Write($"{array[i, j]}");
                                Console.WriteLine();
                            }
                        }
                        // соседи верхнего ряда массива.
                        if (i == 0 && j != 0 && j != indMaxColumns)
                        {
                            if (array[i, j] > array[i, j - 1] &&
                                array[i, j] > array[i + 1, j - 1] &&
                                array[i, j] > array[i + 1, j] &&
                                array[i, j] > array[i + 1, j + 1] &&
                                array[i, j] > array[i, j + 1])
                            {
                                k += 1;
                                Console.Write($"{array[i, j]}");
                                Console.WriteLine();
                            }
                        }
                        // соседи левого ряда массива.
                        if (j == 0 && i != 0 && i != indMaxRows)
                        {
                            if (array[i, j] > array[i - 1, j] &&
                                array[i, j] > array[i - 1, j + 1] &&
                                array[i, j] > array[i, j + 1] &&
                                array[i, j] > array[i + 1, j + 1] &&
                                array[i, j] > array[i + 1, j])
                            {
                                k += 1;
                                Console.Write($"{array[i, j]}");
                                Console.WriteLine();
                            }
                        }
                        // соседи правого ряда массива.
                        if (j == indMaxColumns && i != 0 && i != indMaxRows)
                        {
                            if (array[i, j] > array[i - 1, j] &&
                                array[i, j] > array[i - 1, j - 1] &&
                                array[i, j] > array[i, j - 1] &&
                                array[i, j] > array[i + 1, j - 1] &&
                                array[i, j] > array[i + 1, j])
                            {
                                k += 1;
                                Console.Write($"{array[i, j]}");
                                Console.WriteLine();
                            }
                        }
                        // соседи нижнего ряда массива.
                        if (i == indMaxRows && j != 0 && j != indMaxColumns)
                        {
                            if (array[i, j] > array[i, j - 1] &&
                                array[i, j] > array[i - 1, j - 1] &&
                                array[i, j] > array[i - 1, j] &&
                                array[i, j] > array[i - 1, j + 1] &&
                                array[i, j] > array[i, j + 1])
                            {
                                k += 1;
                                Console.Write($"{array[i, j]}");
                                Console.WriteLine();
                            }
                        }
                        // соседи центральной части массива.
                        if (i != 0 && j != 0 && i != indMaxRows && j != indMaxColumns)
                        {
                            if (array[i, j] > array[i - 1, j - 1] &&
                                array[i, j] > array[i - 1, j] &&
                                array[i, j] > array[i - 1, j + 1] &&
                                array[i, j] > array[i, j + 1] &&
                                array[i, j] > array[i + 1, j + 1] &&
                                array[i, j] > array[i + 1, j] &&
                                array[i, j] > array[i + 1, j - 1] &&
                                array[i, j] > array[i, j - 1])
                            {
                                k += 1;
                                Console.Write($"{array[i, j]}");
                                Console.WriteLine();
                            }
                        }
                    }
                }
                return k;
            }
        }

        // переписать метод для прямоугольных массивов

        // 6. Отразите массив относительно его главной диагонали
        public static int[,] FlipArrayRelativeMainDiagonal(int[,] array, int rows, int columns)
        {
            if (array.Length == 0)
            {
                throw new Exception("Массив пустой");
            }
            else
            {
                int[,] a = new int[columns, rows];
                for (int i = 0; i < columns; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        a[i, j] = array[j, i];
                    }
                }
                return a;
            }
        }
       
    }
}
