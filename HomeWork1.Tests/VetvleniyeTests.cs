using NUnit.Framework;

namespace HomeWork1.Tests
{
    public class VetvleniyeTests
    {
        //Пользователь вводит 2 числа (A и B). Если A>B, подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B.
        [TestCase(5, 3, 8)]
        [TestCase(2, 2, 4)]
        [TestCase(4, 10, -6)]
        [TestCase(4, 4, 4)]
        public void Solution1Test(double a, double b, double expected)
        {
            double actual = Vetvleniye.Solution1(a, b);
            Assert.AreEqual(expected, actual);
        }

        // Пользователь вводит 2 числа (X и Y). Определить какой четверти принадлежит точка с координатами (X,Y).
        [TestCase(5, 3, "Координата принадлежит I четверти.")]
        [TestCase(-2, 2, "Координата принадлежит II четверти.")]
        [TestCase(-4, -10, "Координата принадлежит III четверти.")]
        [TestCase(4, -4, "Координата принадлежит IV четверти.")]
        [TestCase(0, 10, "Точка лежит на оси.")]
        public void DefineQuarterTest(double x, double y, string expected)
        {
            string actual = Vetvleniye.DefineQuarter(x, y);
            Assert.AreEqual(expected, actual);
        }

        //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания.
        [TestCase(1, 2, 3, "123")]
        [TestCase(5, 4, 3, "345")]
        [TestCase(1, 8, 3, "138")]
        [TestCase(1, -2, 3, "-213")]
        [TestCase(1, 0, 3, "013")]
        public void OutputAscendingTest(double a, double b, double c, string expected)
        {
            string actual = Vetvleniye.OutputAscending(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        // Пользователь вводит 3 числа (A, B и С). 
        // Выведите в консоль решение(значения X) квадратного уравнения стандартного вида, где AX2+BX+C=0.
        [TestCase(1, -4, 4, "2")]
        [TestCase(2, 1, 3, "Нет корней уравнения")]
        [TestCase(2, 5, -7, "-3,5   1")]
        public void SolutionOfQuadraticEquationTest(double a, double b, double c, string expected)
        {
            string actual = Vetvleniye.SolutionOfQuadraticEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа. 
        //Например при вводе “25” в консоль будет выведено “двадцать пять”.
        [TestCase(10,"Десять")]
        [TestCase(50, "Пятьдесят")]
        [TestCase(36, "Тридцатьшесть")]
        public void TranslateToWordsTest(int a,  string expected)
        {
            string actual = Vetvleniye.TranslateToWords(a);
            Assert.AreEqual(expected, actual);
        }
    }
}
