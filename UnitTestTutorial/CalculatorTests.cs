using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTutorial
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void Add_FourAndSix_ReturnsTen()
        {
            //Arrange
            decimal a = 4;
            decimal b = 6;
            //Act
            var resultado = Calculator.Add(a, b);
            //Assert
            Assert.AreEqual(10, resultado);
        }

        [TestMethod]
        public void Substract_EqualValues_ReturnZero()
        {
            decimal a = 8;
            decimal b = a;

            var resultado = Calculator.Substract(a, b);

            Assert.AreEqual(0, resultado);
        }
        [TestMethod]
        public void Multiply_AnyValueAndZero_ReturnsZero()
        {
            decimal a = 56;
            decimal b = 0;

            var resultado = Calculator.Multiply(a, b);

            Assert.AreEqual(0, resultado);
        }

        [TestMethod]
        public void Multiply_ThreeAndFour_ReturnsTwelve()
        {
            decimal a = 3;
            decimal b = 4;

            var resultado = Calculator.Multiply(a, b);

            Assert.AreEqual(12, resultado);
        }

        [TestMethod]
        public void Divide_ByZero_ThrowsException()
        {
            decimal a = 34;
            decimal b = 0;

            var message = string.Empty;

            try
            {
                Calculator.Divide(a, b);
            }
            catch(Exception ex)
            {
                message = ex.Message;
            }

            Assert.AreEqual("No se puede dividir entre cero.", message);
        }

        [TestMethod]
        public void Divide_TwentyAndTwo_ReturnsTen()
        {
            decimal a = 20;
            decimal b = 2;

            var resultado = Calculator.Divide(a, b);

            Assert.AreEqual(10, resultado);
        }
    }
}
