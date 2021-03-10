using NUnit.Framework;

namespace HomeWork1.Tests
{
    class TsiklyTests
    {
        // 1. Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
        [TestCase(2, 3, 8)]
        [TestCase(5, 0, 1)]
        [TestCase(4, -2, 0.0625)]
        public void PowTest(double a, double b, double expected)
        {
            double actual = Tsikly.Pow(a, b);
            Assert.AreEqual(expected, actual);
        }

        // 2. Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
        [TestCase(500, "500 1000 ")]
        [TestCase(0, "Error A = 0 ")]
        [TestCase(1001, "Error A = 0 ")]
        public void DivATest(int a, string expected)
        {
            string actual = Tsikly.DivA(a);
            Assert.AreEqual(expected, actual);
        }

        // 3. Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
        [TestCase(100, 9)]
        [TestCase(0, 0)]
        [TestCase(-5, 0)]
        public void CountMensheATest(int a, int expected)
        {
            int actual = Tsikly.CountMensheA(a);
            Assert.AreEqual(expected, actual);
        }

        // 4. Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
        [TestCase(100, 50)]
        [TestCase(0, 0)]
        [TestCase(-5, 0)]
        public void MaxDelitelATest(int a, int expected)
        {
            int actual = Tsikly.MaxDelitelA(a);
            Assert.AreEqual(expected, actual);
        }

        // 5. Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, 
        //    которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).
        [TestCase(5, 30, 70)]
        [TestCase(10, 20, 14)]
        [TestCase(-15, 0, -21)]
        public void SumDiv7Test(int a, int b, int expected)
        {
            int actual = Tsikly.SumDiv7(a,b);
            Assert.AreEqual(expected, actual);
        }

        // 6. Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. 
        [TestCase(1, 1)]
        [TestCase(10, 55)]
        [TestCase(2, 1)]
        public void FindNFibonachiTest(int n, int expected)
        {
            int actual = Tsikly.FindNFibonachi(n);
            Assert.AreEqual(expected, actual);
        }

        // 7. Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
        [TestCase(100, 50, 50)]
        [TestCase(10, 0, 0)]
        [TestCase(-9, -3, -3)]
        public void FindDivEvklidaTest(int a, int b, int expected)
        {
            int actual = Tsikly.FindDivEvklida(a,b);
            Assert.AreEqual(expected, actual);
        }

        // 8. Пользователь вводит целое положительное число, которое является кубом целого числа N. 
        //    Найдите число N методом половинного деления.
        [TestCase(125ul,5ul)]
        [TestCase(8ul,2ul)]
        [TestCase(0ul,0ul)]
        public void FindNBinarySearchTest(ulong a, ulong expected)
        {
            ulong actual = Tsikly.FindNBinarySearch(a);
            Assert.AreEqual(expected, actual);
        }

        // 9. Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
        [TestCase(12345, 3)]
        [TestCase(0, 0)]
        [TestCase(-987654321, 5)]
        public void FindCountOddNumbersTest(int a, int expected)
        {
            int actual = Tsikly.FindCountOddNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        // 10. Пользователь вводит 1 число. 
        //     Найти число, которое является зеркальным отображением последовательности цифр заданного числа, 
        //     например, задано число 123, вывести 321.
        [TestCase(123, 321)]
        [TestCase(0, 0)]
        [TestCase(-98765, -56789)]
        public void FindNumberСonverselyTest(long n, long expected)
        {
            long actual = Tsikly.FindNumberСonversely(n);
            Assert.AreEqual(expected, actual);
        }

        // 11. Пользователь вводит целое положительное  число (N). 
        //     Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 
        [TestCase(10, "2 4 6 8 ")]
        [TestCase(45, "2 4 6 8 12 14 16 18 20 21 22 24 26 28 34 36 38 40 41 42 43 44 ")]
        [TestCase(0, "0")]
        public void FindNumberSumEvenMoreSumOddTest(int n, string expected)
        {
            string actual = Tsikly.FindNumberSumEvenMoreSumOdd(n);
            Assert.AreEqual(expected, actual);
        }

        // 12. Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры. 
        //     Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ”.
        [TestCase(123, 3456789, "Да")]
        [TestCase(500, 99, "Нет")]
        [TestCase(0, -89, "Нет")]
        public void FindSameNumbersTest(int a, int b, string expected)
        {
            string actual = Tsikly.FindSameNumbers(a,b);
            Assert.AreEqual(expected, actual);
        }
    }
}
