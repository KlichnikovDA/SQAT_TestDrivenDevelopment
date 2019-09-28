using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HSE.SQAT.CalculatorApp.Tests
{
    // На доработку тестов потрачено ~ 2 часа 40 минут
    [TestClass]
    public class CalculatorTests
    {
        #region Functions
        [TestMethod]
        [TestCategory("Functions")]
        public void FunctionPlus()
        {
            PressPlusTwoItem(1, 2);
        }

        [TestMethod]
        [TestCategory("Functions")]
        public void FunctionMinus()
        {
            PressMinusThreeItem();
        }

        [TestMethod]
        [TestCategory("Functions")]
        public void FunctionMultiply()
        {
            PressMultiplyTwoItem(2, 1);
        }

        [TestMethod]
        [TestCategory("Functions")]
        public void FunctionDivide()
        {
            PressDivideTwoItem(1, 2);
        }
        #endregion Functions

        #region InputData
        [DataTestMethod]
        [TestCategory("InputData")]
        [DataRow(0, 3)]
        [DataRow(2.5, 1.5)]
        [DataRow(5, -2)]
        [DataRow(-5, 8)]
        public void PressPlusTwoItem(double value1, double value2)
        {
            // Arrange.

            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressPlus();
            calculator.PressDisplay(value2);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [TestCategory("InputData")]
        [DataRow(2, 1)]
        [DataRow(-1, -2)]
        [DataRow(0.5, 4)]
        public void PressMultiplyTwoItem(double value1, double value2)
        {
            // Arrange.

            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMultiply();
            calculator.PressDisplay(value2);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("InputData")]
        public void PressDivideMultiplyTwoItem()
        {
            // Arrange.
            var value1 = 1;
            var value2 = 17;
            var value3 = 34;
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressDivide();
            calculator.PressDisplay(value2);
            calculator.PressMultiply();
            calculator.PressDisplay(value3);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("InputData")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void PressDivideZeroTwoItem()
        {
            // Arrange.
            var value1 = 1;
            var value2 = 0;
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressDivide();
            calculator.PressDisplay(value2);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            Assert.Fail();
        }

        [TestMethod]
        [TestCategory("InputData")]
        [ExpectedException(typeof(DivideByZeroException))]
        public void PressDivideZeroZero()
        {
            // Arrange.
            var value1 = 0;
            var value2 = 0;
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressDivide();
            calculator.PressDisplay(value2);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            Assert.Fail();
        }

        [DataTestMethod]
        [TestCategory("InputData")]
        [DataRow(1, 2)]
        [DataRow(-1, -2)]
        [DataRow(4, 8)]
        [DataRow(0.25, 0.5)]
        public void PressDivideTwoItem(double value1, double value2)
        {
            // Arrange.

            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressDivide();
            calculator.PressDisplay(value2);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            var expected = 0.5;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [TestCategory("InputData")]
        public void PressPlusThreeItem()
        {
            // Arrange.
            var value1 = 1;
            var value2 = 2;
            var value3 = 3;
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressPlus();
            calculator.PressDisplay(value2);
            calculator.PressPlus();
            calculator.PressDisplay(value3);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            var expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [TestCategory("InputData")]
        [DataRow(3, 2)]
        [DataRow(1, 0)]
        [DataRow(-1.6, -2.6)]
        public void PressMinusTwoItem(double value1, double value2)
        {
            // Arrange.

            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMinus();
            calculator.PressDisplay(value2);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("InputData")]
        public void PressMinusThreeItem()
        {
            // Arrange.
            var value1 = 3;
            var value2 = 2;
            var value3 = 2;
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMinus();
            calculator.PressDisplay(value2);
            calculator.PressMinus();
            calculator.PressDisplay(value3);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            var expected = -1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("InputData")]
        public void PressPlusMinusThreeItem()
        {
            // Arrange.
            var value1 = 3;
            var value2 = 2;
            var value3 = 2;
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressPlus();
            calculator.PressDisplay(value2);
            calculator.PressMinus();
            calculator.PressDisplay(value3);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("InputData")]
        public void PressMinusPlusThreeItem()
        {
            // Arrange.
            var value1 = 3;
            var value2 = 2;
            var value3 = 1;
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMinus();
            calculator.PressDisplay(value2);
            calculator.PressPlus();
            calculator.PressDisplay(value3);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            var expected = 2;
            Assert.AreEqual(expected, actual);
        }
        #endregion InputData

        #region OutputData
        [TestMethod]
        [TestCategory("OutputData")]
        public void OutPositiveValue()
        {
            PressMinusPlusThreeItem();
        }

        [TestMethod]
        [TestCategory("OutputData")]
        public void OutNegativeValue()
        {
            PressMinusThreeItem();
        }

        [TestMethod]
        [TestCategory("OutputData")]
        public void OutZero()
        {
            // Arrange.
            var value1 = 1;
            var value2 = 1;
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMinus();
            calculator.PressDisplay(value2);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
        #endregion OutputData

        #region AllowableRange
        [TestMethod]
        [TestCategory("AllowableRange")]
        public void RangePlus()
        {
            PressPlusTwoItem(1, 2);
        }

        [TestMethod]
        [TestCategory("AllowableRange")]
        public void RangeMinus()
        {
            PressMinusThreeItem();
        }

        [TestMethod]
        [TestCategory("AllowableRange")]
        public void RangeMultiply()
        {
            PressMultiplyTwoItem(2, 1);
        }

        [TestMethod]
        [TestCategory("AllowableRange")]
        public void RangeDivideAllowable()
        {
            PressDivideTwoItem(1, 2);
        }

        [TestMethod]
        [TestCategory("AllowableRange")]
        public void RangeDivideNonAllowable()
        {
            PressDivideZeroTwoItem();
        }
        #endregion AllowableRange

        #region LengthInputData
        [TestMethod]
        [TestCategory("LengthInputData")]
        public void PresPlusZeroItem()
        {
            // Arrange.
            
            // Act.
            var calculator = new Calculator();
            var actual = calculator.Display;
            // Assert.
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("LengthInputData")]
        public void PresPlusOneItem()
        {
            // Arrange.
            var value1 = 5;
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressEnter();
            var actual = calculator.Display;
            // Assert.
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("LengthInputData")]
        public void PresPlusTenItem()
        {
            // Arrange.
            var array = new double[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            // Act.
            var calculator = new Calculator();
            foreach (var item in array)
            {
                calculator.PressDisplay(item);
                calculator.PressPlus();
            }
            var actual = calculator.Display;
            // Assert.
            var expected = 55;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [TestCategory("LengthInputData")]
        public void PresPlusHundredItem()
        {
            // Arrange.

            // Act.
            var calculator = new Calculator();
            Random rnd = new Random(42);
            double expected = 0;
            for (int i = 0; i < 100; i++)
            {
                var item = (double) rnd.Next(100);
                expected += item;
                calculator.PressDisplay(item);
                calculator.PressPlus();
            }
            var actual = calculator.Display;
            // Assert.
            Assert.AreEqual(expected, actual);
        }
        #endregion LengthInputData

        #region OrderInputData
        [TestMethod]
        [TestCategory("OrderInputData")]
        public void OrderPlus()
        {
            // Arrange.
            var value1 = 2;
            var value2 = 3;
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressPlus();
            calculator.PressDisplay(value2);
            calculator.PressEnter();
            var actual1 = calculator.Display;
            calculator.PressDisplay(value2);
            calculator.PressPlus();
            calculator.PressDisplay(value1);
            calculator.PressEnter();
            var actual2 = calculator.Display;
            // Assert.
            Assert.AreEqual(actual1, actual2);
        }

        [TestMethod]
        [TestCategory("OrderInputData")]
        public void OrderMultiply()
        {
            // Arrange.
            var value1 = 2;
            var value2 = 3;
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMultiply();
            calculator.PressDisplay(value2);
            calculator.PressEnter();
            var actual1 = calculator.Display;
            calculator.PressDisplay(value2);
            calculator.PressMultiply();
            calculator.PressDisplay(value1);
            calculator.PressEnter();
            var actual2 = calculator.Display;
            // Assert.
            Assert.AreEqual(actual1, actual2);
        }

        [TestMethod]
        [TestCategory("OrderInputData")]
        public void OrderMinus()
        {
            // Arrange.
            var value1 = 2;
            var value2 = 3;
            // Act.
            var calculator = new Calculator();
            calculator.PressDisplay(value1);
            calculator.PressMinus();
            calculator.PressDisplay(value2);
            calculator.PressEnter();
            var actual1 = calculator.Display;
            calculator.PressDisplay(value2);
            calculator.PressMinus();
            calculator.PressDisplay(value1);
            calculator.PressEnter();
            var actual2 = calculator.Display * (-1);
            // Assert.
            Assert.AreEqual(actual1, actual2);
        }
        #endregion OrderInputData
    }
}
