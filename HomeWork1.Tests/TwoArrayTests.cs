using NUnit.Framework;

namespace HomeWork1.Tests
{
    public class TwoArrayTests
    {
        // 1. Найти минимальный элемент массива
        [TestCase(1,5,5,0)]
        public void FindMinTwoArray(int mockNumber, int rows, int columns, int expected)
        {
            int[,] arr = ArrayMock.GetMock(mockNumber);
            int actual = TwoArray.FindMinTwoArray(arr, rows, columns);
            Assert.AreEqual(expected, actual);
        }

        // 2. Найти максимальный элемент массива
        [TestCase(1, 5, 5, 9)]
        public void FindMaxTwoArray(int mockNumber, int rows, int columns, int expected)
        {
            int[,] arr = ArrayMock.GetMock(mockNumber);
            int actual = TwoArray.FindMaxTwoArray(arr, rows, columns);
            Assert.AreEqual(expected, actual);
        }

        // 3. Найти индекс минимального элемента массива
        [TestCase(1, 5, 5, 0, 2)]
        public void FindIndMinTwoArray(int mockNumber, int rows, int columns, int expectedA, int expectedB)
        {
            int[,] arr = ArrayMock.GetMock(mockNumber);
            var ab = TwoArray.FindIndMinTwoArray(arr, rows, columns);
            int actualA = ab.Item1;
            int actualB = ab.Item2;
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        //  4. Найти индекс максимального элемента массива
        [TestCase(1, 5, 5, 0, 3)]
        public void FindIndMaxTwoArray(int mockNumber, int rows, int columns, int expectedA, int expectedB)
        {
            int[,] arr = ArrayMock.GetMock(mockNumber);
            var ab = TwoArray.FindIndMaxTwoArray(arr, rows, columns);
            int actualA = ab.Item1;
            int actualB = ab.Item2;
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        //  5. Найти количество элементов массива, которые больше всех своих соседей одновременно
        [TestCase(1, 5, 5, 9)]
        public void FindCountMaxTwoArray(int mockNumber, int rows, int columns, int expected)
        {
            int[,] arr = ArrayMock.GetMock(mockNumber);
            int actual = TwoArray.FindMaxTwoArray(arr, rows, columns);
            Assert.AreEqual(expected, actual);
        }
    }



    public static class ArrayMock
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int[0,0];
            switch(number)
            {
                case 1:
                    result = new int[,]
                    {
                        {1,2,0,9,6},
                        {0,4,5,1,7},
                        {1,2,4,2,9},
                        {8,5,0,3,1},
                        {3,9,7,4,7}
                    };
                    break;
            }
            return result;
        }
    }

    /*
    // Массив пустой
    [TestCase(new int[,] {})]
    public void TwoArrayIsNull(int[,] array)
    {
        try
        {
            TwoArray.FindMinTwoArray(array);
        }
        catch
        {
            Assert.Pass();
        }
        Assert.Fail();
    }
    */
}
