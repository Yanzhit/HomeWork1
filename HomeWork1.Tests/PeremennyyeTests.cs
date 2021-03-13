using NUnit.Framework;

namespace HomeWork1.Tests
{
    public class PeremennyyeTests
    {
        // Ğåøåíèå óğàâíåíèÿ (5 * a + b * b) / (b - a)
        [TestCase(1, 2, 9)]
        [TestCase(2, 5, 11.66)]
        [TestCase(4, 3, -29)]
        public void SolutionEquationTest(double a, double b, double expected)
        {
            double actual = Peremennyye.SolutionEquation(a, b);
            Assert.AreEqual(expected, actual,0.01d);
        }

        [TestCase(4, 4)]
        [TestCase(0, 0)]
        public void SolutionEquation_WhenBminusA_To0ShouldExcetion(double a, double b)
        {
            try
            {
                Peremennyye.SolutionEquation(a, b);
            }
            catch 
            {
                Assert.Pass();
            }            
            Assert.Fail();
        }

        // Ïîìåíÿòü ìåñòàìè À è Â
        [TestCase(123, 456, 456, 123)]
        [TestCase(0, 10, 10, 0)]
        [TestCase(16, 98, 98, 16)]
        public void ToSwapTest(int a, int b, int expectedA, int expectedB)
        {
            Peremennyye.ToSwap(ref a, ref b);
            int actualA = a;
            int actualB = b;
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        // Äåëåíèå À íà Â
        [TestCase(36, 6, 6)]
        [TestCase(25, 5, 5)]
        [TestCase(8, -2, -4)]
        public void DivTest(double a, double b, double expected)
        {
            double actual = Peremennyye.Division(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(8, 0)]
        [TestCase(0, 0)]
        public void Division_WhenBEqualTo0ShouldExcetion(double a, double b)
        {
            try
            {
                Peremennyye.Division(a, b);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        // Ğåøåíèå ëèíåéíîãî óğàâíåíèÿ ñòàíäàğòíîãî âèäà
        [TestCase(2, 4, 8, 2)]
        [TestCase(5, 19, 4, -3)]
        [TestCase(-8, 2, 5, -0.375)]
        public void SolutionLinearEquationTest(double a, double b, double c, double expected)
        {
            double actual = Peremennyye.SolutionLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 4, 8)]
        public void SolutionLinearEquation_WhenAEqualTo0ShouldExcetion(double a, double b, double c)
        {
            try
            {
                Peremennyye.SolutionLinearEquation(a, b, c);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }

        // Ğåøåíèå óğàâíåíèÿ ïî êîîîğäèíàòàì

        [TestCase(7, 10, 3, 2, 2, -4)]
        [TestCase(7, 5, 4, 2, 1, -2)]
        [TestCase(10, 3, 8, 6, -1.5, 18)]
        public void SolutionEquationÑoordinatesTest(double x1, double y1, double x2, double y2, double expectedA, double expectedB)
        { 
            var ab= Peremennyye.SolutionEquationÑoordinates(x1,y1,x2,y2);
            double actualA = ab.Item1;
            double actualB = ab.Item2;
            Assert.AreEqual(expectedA, actualA);
            Assert.AreEqual(expectedB, actualB);
        }

        [TestCase(7, 10, 7, 2)]
        [TestCase(0, 10, 0, 2)]
        public void SolutionEquationÑoordinates_WhenX1MinusX2EqualTo0ShouldExcetion(double x1, double y1, double x2, double y2)
        {
            try
            {
                Peremennyye.SolutionEquationÑoordinates(x1, y1, x2, y2);
            }
            catch
            {
                Assert.Pass();
            }
            Assert.Fail();
        }
    }
}