using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLibrary;

namespace MathLibrary.Tests
{
    [TestClass]
    public sealed class Math_operation_tests
    {
        //метод тестирования функции факториала положительного числа
        [TestMethod]
        public void Factorial_PositiveNumber()
        {
            var math = new MathOperation();
            Assert.AreEqual(120, math.Factorial(5));
        }

        //метод тестирования функции факториала отрицательного числа
        [TestMethod]
        public void Factorial_NegativeNumber()
        {
            var math = new MathOperation();
            Assert.ThrowsException<ArgumentException>(() => math.Factorial(-1));
        }

        //метод тестирования функции возведения в степень
        [TestMethod]
        public void Power()
        {
            var math = new MathOperation();
            Assert.AreEqual(8, math.Power(2, 3));
        }

        //метод тестирования функции поиска корня некоторой степени из некоторого числа
        [TestMethod]
        public void Root_PositiveNumber()
        {
            var math = new MathOperation();
            Assert.AreEqual(3, math.Root(9, 2));
        }

        //метод тестирования функции поиска корня некоторой степени из отрицательного числа
        [TestMethod]
        public void Root_NegativeNumber()
        {
            var math = new MathOperation();
            Assert.ThrowsException<ArgumentException>(() => math.Root(-1, 2));
        }

        //метод тестирования функции поиска логарифма
        [TestMethod]
        public void Logarithm()
        {
            var math = new MathOperation();
            Assert.AreEqual(2, math.Logarithm(100, 10));
        }

        //метод тестирования функции поиска логарифма с недопустимыми значениями
        [TestMethod]
        public void Logarithm_InvalidValues()
        {
            var math = new MathOperation();
            Assert.ThrowsException<ArgumentException>(() => math.Logarithm(-1, 10));
            Assert.ThrowsException<ArgumentException>(() => math.Logarithm(100, 0));
            Assert.ThrowsException<ArgumentException>(() => math.Logarithm(100, 1));
        }
    }
}