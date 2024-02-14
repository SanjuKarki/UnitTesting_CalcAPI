using CalculatorClassLibrary;

namespace TestCalculator
{
    [TestClass]
    public class UnitTest1
    {
     
            [TestMethod]
            public void Add_ShouldReturnCorrectResult()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Add(4, 7);

                // Assert
                Assert.AreEqual(11, result);
            }
            [TestMethod]
            public void Add_ShouldReturnCorrectResultForPositiveNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Add(4, 7);

                // Assert
                Assert.AreEqual(11, result);
            }

            [TestMethod]
            public void Add_ShouldReturnCorrectResultForNegativeNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Add(-4, -4);

                // Assert
                Assert.AreEqual(-8, result);
            }

            [TestMethod]
            public void Add_ShouldReturnCorrectResultForMixedNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Add(-4, 5);

                // Assert
                Assert.AreEqual(1, result);
            }

            [TestMethod]
            public void Add_ShouldReturnCorrectResultForZero()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Add(3, 3);

                // Assert
                Assert.AreEqual(6, result);
            }

            [TestMethod]
            public void Add_ShouldReturnCorrectResultForDecimalNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Add(4.5m, 2.5m);

                // Assert
                Assert.AreEqual(7, result);
            }

            // test for modulo
            [TestMethod]
            public void Modulo_ShouldReturnCorrectResult()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Modulo(11, 2);

                // Assert
                Assert.AreEqual(1, result);
            }
            // test for subtraction logic
            [TestMethod]
            public void Subtract_ShouldReturnCorrectResultForPositiveNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Subtract(9, 5);

                // Assert
                Assert.AreEqual(4, result);
            }

            [TestMethod]
            public void Subtract_ShouldReturnCorrectResultForNegativeNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Subtract(-3, -5);

                // Assert
                Assert.AreEqual(2, result);
            }

            [TestMethod]
            public void Subtract_ShouldReturnCorrectResultForMixedNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Subtract(-3, 5);

                // Assert
                Assert.AreEqual(-8, result);
            }

            [TestMethod]
            public void Subtract_ShouldReturnCorrectResultForZero()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Subtract(6, 0);

                // Assert
                Assert.AreEqual(6, result);
            }

            [TestMethod]
            public void Subtract_ShouldReturnCorrectResultForDecimalNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Subtract(7.5m, 2.5m);

                // Assert
                Assert.AreEqual(5, result);
            }
            //test for multiply
            [TestMethod]
            public void Multiply_ShouldReturnCorrectResultForPositiveNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Multiply(4, 5);

                // Assert
                Assert.AreEqual(20, result);
            }

            [TestMethod]
            public void Multiply_ShouldReturnCorrectResultForNegativeNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Multiply(-4, -5);

                // Assert
                Assert.AreEqual(20, result);
            }

            [TestMethod]
            public void Multiply_ShouldReturnCorrectResultForMixedNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Multiply(-4, 5);

                // Assert
                Assert.AreEqual(-20, result);
            }

            [TestMethod]
            public void Multiply_ShouldReturnZeroForMultiplyingByZero()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Multiply(4, 0);

                // Assert
                Assert.AreEqual(0, result);
            }

            [TestMethod]
            public void Multiply_ShouldReturnCorrectResultForDecimalNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Multiply(4.5m, 2);

                // Assert
                Assert.AreEqual(11, result);
            }
            // test for division
            [TestMethod]
            public void Divide_ShouldReturnCorrectResultForPositiveNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Divide(6, 2);

                // Assert
                Assert.AreEqual(3, result);
            }

            [TestMethod]
            public void Divide_ShouldReturnCorrectResultForNegativeNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Divide(-6, -2);

                // Assert
                Assert.AreEqual(3, result);
            }

            [TestMethod]
            public void Divide_ShouldReturnCorrectResultForMixedNumbers()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Divide(-6, 2);

                // Assert
                Assert.AreEqual(-3, result);
            }


            [TestMethod]
            public void Divide_ShouldThrowExceptionForDivideByZero()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act & Assert
                Assert.ThrowsException<DivideByZeroException>(() => calculator.Divide(6, 0));
            }
            [TestMethod]
            public void Divide_ShouldReturnCorrectResultForFractionalResult()
            {
                // Arrange
                calculatorlib calculator = new calculatorlib();

                // Act
                decimal result = calculator.Divide(7, 2);

                // Assert
                Assert.AreEqual(4.5m, result);
            }

        }
    }