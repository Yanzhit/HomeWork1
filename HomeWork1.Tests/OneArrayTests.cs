using NUnit.Framework;

namespace HomeWork1.Tests
{
    public class OneArrayTests
    {
        // 1. Найти минимальный элемент массива
        [TestCase(new int[] {1, 2, 3, 4, 5},1)]
        [TestCase(new int[] {9, 8, 7, 6, 0},0)]
        [TestCase(new int[] {15, 4, 3, 20, 5},3)]
        public void FindMinArrayTest(int[] a, int expected)
        {
            int actual = OneArray.FindMinArray(a);
            Assert.AreEqual(expected, actual);
        }

        // 2. Найти максимальный элемент массива
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new int[] { 9, 8, 7, 6, 0 }, 9)]
        [TestCase(new int[] { 15, 4, 3, 20, 5 }, 20)]
        public void FindMaxArrayTest(int[] a, int expected)
        {
            int actual = OneArray.FindMaxArray(a);
            Assert.AreEqual(expected, actual);
        }

        // 3. Найти индекс минимального элемента массива
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0)]
        [TestCase(new int[] { 9, 8, 7, 6, 0 }, 4)]
        [TestCase(new int[] { 15, 4, 3, 20, 5,0,8}, 5)]
        public void FindIndMinArrayTest(int[] a, int expected)
        {
            int actual = OneArray.FindIndMinArray(a);
            Assert.AreEqual(expected, actual);
        }

        // 4. Найти индекс максимального элемента массива
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
        [TestCase(new int[] { 9, 8, 7, 6, 0 }, 0)]
        [TestCase(new int[] { 15, 4, 3, 20, 5, 0, 8 }, 3)]
        public void FindIndMaxArrayTest(int[] a, int expected)
        {
            int actual = OneArray.FindIndMaxArray(a);
            Assert.AreEqual(expected, actual);
        }

        // 5. Посчитать сумму элементов массива с нечетными индексами
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 6)]
        [TestCase(new int[] { 9, 8, 7}, 8)]
        [TestCase(new int[] { 15, 4, 3, 20, 5, 0, 8 }, 24)]
        public void FindSumArrayOddIndTest(int[] a, int expected)
        {
            int actual = OneArray.FindSumArrayOddInd(a);
            Assert.AreEqual(expected, actual);
        }

        // 6. Сделать реверс массива (массив в обратном направлении)
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 89, 45, 34 }, new int[] { 34,45,89})]
        [TestCase(new int[] { 10,90,34,12,67,12 }, new int[] { 12,67,12,34,90,10})]
        public void ReverseArrayTest(int[] a, int[] expected)
        {
            int[] actual = OneArray.ReverseArray(a);
            Assert.AreEqual(expected, actual);
        }

        // 7. Посчитать количество нечетных элементов массива
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new int[] { 1357 }, 1)]
        [TestCase(new int[] { 11,13,0,17,21 }, 4)]
        public void CountOddArrayTest(int[] a, int expected)
        {
            int actual = OneArray.CountOddArray(a);
            Assert.AreEqual(expected, actual);
        }

        // 8. Поменять местами первую и вторую половину массива, 
        //    например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312.
        [TestCase(new int[] { 1,2,3,4 }, new int[] { 3,4,1,2 })]
        [TestCase(new int[] { 1,2,3,4,5 }, new int[] { 4,5,3,1,2 })]
        public void SwapHalfArrayTest(int[] a, int[] expected)
        {
            int[] actual = OneArray.SwapHalfArray(a);
            Assert.AreEqual(expected, actual);
        }

        // 9. Отсортировать массив по возрастанию одним из способов:  
        //    пузырьком(Bubble), выбором (Select) или вставками (Insert)) 
        //    Пузырьком(Bubble):
        [TestCase(new int[] { 9,5,7,2,3,6}, new int[] { 2,3,5,6,7,9})]
        [TestCase(new int[] { 0,4,5,1,2,3,9 }, new int[] { 0,1,2,3,4,5,9})]
        [TestCase(new int[] { -3,7,-4,0,2}, new int[] {-4,-3,0,2,7})]
        public void SortArrayAscendingTest(int[] a, int[] expected)
        {
            int[] actual = OneArray.SortArrayAscending(a);
            Assert.AreEqual(expected, actual);
        }

        // 10. Отсортировать массив по убыванию одним из способов, (отличным от способа в 9-м задании) :  
        //     пузырьком(Bubble), выбором (Select) или вставками (Insert))
        //     Выбором (Select):
        [TestCase(new int[] { 9, 5, 7, 2, 3, 6 }, new int[] {9,7,6,5,3,2})]
        [TestCase(new int[] { 0, 4, 5, 1, 2, 3, 9 }, new int[] {9,5,4,3,2,1,0})]
        [TestCase(new int[] { -3, 7, -4, 0, 2 }, new int[] {7,2,0,-3,-4})]
        public void SortArrayDescendingTest(int[] a, int[] expected)
        {
            int[] actual = OneArray.SortArrayDescending(a);
            Assert.AreEqual(expected, actual);
        }

        // Массив пустой
        [TestCase(new int[] {})]
        public void ArrayIsNull(int[] a)
        {
            try
            {
                OneArray.FindMinArray(a);
                OneArray.FindMaxArray(a);
                OneArray.FindIndMinArray(a);
                OneArray.FindIndMaxArray(a);
                OneArray.FindSumArrayOddInd(a);
                OneArray.ReverseArray(a);
                OneArray.CountOddArray(a);
                OneArray.SwapHalfArray(a);
                OneArray.SortArrayAscending(a);
                OneArray.SortArrayDescending(a);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}
