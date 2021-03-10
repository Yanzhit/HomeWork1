using NUnit.Framework;

namespace HomeWork1.Tests
{
    public class PeremennyyeTests
    {
        // Решение уравнения (5 * a + b * b) / (b - a)
        [TestCase(1, 2, 9)]
        [TestCase(2, 2, 9)]
        [TestCase(4, 3, -29)]
        public void SolutionEquationTest(double a, double b, double expected)
        {
            double actual = Peremennyye.SolutionEquation(a, b);
            Assert.AreEqual(expected, actual);
        }

        // Деление А на В
        [TestCase(36, 6, 6)]
        [TestCase(25, 0, 0)]
        [TestCase(8, -2, -4)]
        public void DivTest(double a, double b, double expected)
        {
            double actual = Peremennyye.Division(a, b);
            Assert.AreEqual(expected, actual);
        }

        // Решение линейного уравнения стандартного вида
        [TestCase(2, 4, 8, 2)]
        [TestCase(5, 19, 4, -3)]
        [TestCase(0, 2, 5, 0)]
        public void SolutionLinearEquationTest(double a, double b, double c, double expected)
        {
            double actual = Peremennyye.SolutionLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

    }
}