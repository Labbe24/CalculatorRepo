using System;
using System.Threading;
using Calculators;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    class CalculatorTest
    {
        private Calculator _uut = null;

        [SetUp]
        public void Setup()
        {
            // Arrange
            _uut = new Calculator();
        }

        // AddTests
       [Test]
       public void Add_FiveAndFive_ReturnsTen()
        {
            // Act
            double result = _uut.Add(5, 5);

            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

       [Test]
       public void Add_MinusTenAndMinusFive_ReturnsMinusFifteen()
       {
           // Act
           double result = _uut.Add(-10, -5);

           // Assert
           Assert.That(result, Is.EqualTo(-15));
       }

       [Test]
       public void Add__MinusFiveAndFive_ReturnsZero()
       {
           // Act
           double result = _uut.Add(-5, 5);

           // Assert
           Assert.That(result, Is.EqualTo(0));
       }

        // SubtractTests
        [Test]
       public void Subtract_FiveAndFive_ReturnsZero()
       {
           // Act
           double result = _uut.Subtract(5, 5);

           // Assert
           Assert.That(result, Is.EqualTo(0));
       }
       [Test]
       public void Subtract_MinusTenAndMinusFive_ReturnsMinusFive()
       {
            // Act
            double result = _uut.Subtract(-10, -5);

            // Assert
            Assert.That(result, Is.EqualTo(-5));
       }

       [Test]
       public void Subtract_MinusFiveAndFive_ReturnsMinusTen()
       {
           // Act

           double result = _uut.Subtract(-5, 5);
           // Assert
           Assert.That(result, Is.EqualTo(-10));
       }
        [Test]
       public void Multiply_FiveAndFive_ReturnsTwentyFive()
       {
           // Act
           double result = _uut.Multiply(5, 5);

           // Assert
           Assert.That(result, Is.EqualTo(25));
       }
       [Test]
       public void Multiply_MinusTenAndMinusFive_ReturnsFifty()
       {
           // Act
           double result = _uut.Multiply(-10, -5);

           // Assert
           Assert.That(result, Is.EqualTo(50));
       }

       [Test]
       public void Multiply_MinusFiveAndFive_ReturnsMinusTwentyFive()
       {
           // Act
           double result = _uut.Multiply(-5, 5);

           // Assert
           Assert.That(result, Is.EqualTo(-25));
       }

       // DivideTest
       [Test]
       public void Divide_FiveAndFive_ReturnsOne()
       {
           // Act
           double result = _uut.Divide(5,5);

           // Assert
           Assert.That(result, Is.EqualTo(1));
       }

       [Test]
       public void Divide_FiveAndMinusFive_ReturnsMinusOne()
       {
           // Act
           _uut.Divide(5, -5);

           // Assert
           Assert.AreEqual(-1, _uut.Accumulator);
       }

       [Test]

       public void Divide_FiveAndZero_Exception()
       {
           // Act&Assert
           Assert.That(()=>_uut.Divide(5,0), Throws.TypeOf<DivideByZeroException>());
       }

        // PowerTests
        [Test]
       public void Power_FiveAndFive_ReturnsThreeThousandOneHundredTwentyFive()
       {
           // Act
           double result = _uut.Power(5,5);
           // Assert
            Assert.That(result, Is.EqualTo(3125));
       }

       [Test]
       public void Power_MinusTenAndMinusFive_Exception()
       {
            // Act&Assert
            Assert.That(() => _uut.Power(-10, -5), Throws.TypeOf<ArgumentException>());
        }

       [Test]
       public void Power_MinusFiveAndFive_ReturnsMinusThreeThousandOneHundredTwentyFive()
       {
           // Act
           double result = _uut.Power(-5, 5);

           // Assert
           Assert.That(result, Is.EqualTo(-3125));
       }

       // OverloadedAddTests
        [Test]
       public void OverloadedAdd_Five_AccumulateTo5()
       {
           // Act
           _uut.Add(5);

           // Assert
           Assert.AreEqual(5, _uut.Accumulator);
       }

       [Test]
       public void OverloadedAdd_MinusFive_AccumulateToMinus5()
       {
           // Act
           _uut.Add(-5);

           // Assert
           Assert.AreEqual(-5, _uut.Accumulator);
       }

       [Test]
       public void OverloadedAdd_Zero_AccumulateToZero()
       {
           // Act
           _uut.Add(0);

           // Assert
           Assert.AreEqual(0, _uut.Accumulator);
       }

       // OverloadedSubtractTests
        [Test]
       public void OverloadedSubtract_Five_AccumulateToMinusFive()
       {
           // Act
           _uut.Subtract(5);

           // Assert
           Assert.AreEqual(-5,_uut.Accumulator);
       }

       [Test]
       public void OverloadedSubtract_MinusFive_AccumulateToFive()
       {
           // Act
           _uut.Subtract(-5);

           // Assert
           Assert.AreEqual(5, _uut.Accumulator);
       }

       [Test]
       public void OverloadedSubtract_Zero_AccumulateToZero()
       {
           // Act
           _uut.Subtract(0);

           // Assert
           Assert.AreEqual(0, _uut.Accumulator);
       }
        
       // OverloadedMultiplyTests
        [Test]
       public void OverloadedMultiply_Five_AccumulateToZero()
       {
           // Act
           _uut.Multiply(5);

           // Assert
           Assert.AreEqual(0,_uut.Accumulator);
       }

       [Test]
       public void OverloadedMultiply_MinusFiveAccumulatorSetToTwo_AccumulateToMinusTen()
       {
           // Arrange
           _uut.Add(1, 1);

           // Act
           _uut.Multiply(-5);

           // Assert
           Assert.AreEqual(-10, _uut.Accumulator);
       }

       [Test]
       public void OverloadedMultiply_FiveAccumulatorSetToTwo_AccumulateToTen()
       {
           // Arrange
           _uut.Add(1, 1);

           // Act
           _uut.Multiply(5);

           // Assert
           Assert.AreEqual(10, _uut.Accumulator);
       }

       // OverloadedDivideTests
        [Test]
       public void OverloadedDivide_Five_AccumulateToZero()
       {
           // Act
           _uut.Divide(5);

           // Assert
           Assert.AreEqual(0, _uut.Accumulator);
       }

       [Test]
       public void OverloadedDivide_FiveAccumulatorSetToTen_AccumulateToTwo()
       {
           // Arrange
           _uut.Add(5,5);

           // Act
           _uut.Divide(5);

           // Assert
           Assert.AreEqual(2, _uut.Accumulator);
       }

       [Test]
       public void OverloadedDivide_ZeroAccumulatorSetToFour_ThrowException()
       {
           // Arrange
           _uut.Add(2, 2);

           // Assert
           Assert.That(() => _uut.Divide(0), Throws.TypeOf<DivideByZeroException>());
        }

       // OverloadedPowerTests
        [Test]
       public void OverloadedPower_TwoAccumulatorSetToFour_AccumulateToSixTeen()
       {
           // Arrange
           _uut.Add(2, 2);

           // Act
            _uut.Power(2);

           // Assert
           Assert.AreEqual(16, _uut.Accumulator);
       }

       [Test]
       public void OverloadedPower_MinusTwoAccumulatorSetToTwo_Exception()
       {
           //Arrange
           _uut.Add(0, 2);

           // Assert
           Assert.That(() => _uut.Power(-2), Throws.TypeOf<ArgumentException>());
       }

       [Test]
       public void OverloadedPower_ZeroAccumulatorSetToFour_AccumulateToOne()
       {
           // Arrange
           _uut.Add(2, 2);

            // Act
            _uut.Power(0);

           // Assert
           Assert.AreEqual(1, _uut.Accumulator);
       }


    }
}
