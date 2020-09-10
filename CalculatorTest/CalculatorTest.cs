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
       public void Add_Two_Items()
        {
            // Act
            //uut.Add(5, 5);

            // Assert
            Assert.That(_uut.Add(5, 5), Is.EqualTo(10));
        }

       [Test]
       public void Add_TwoNegativeDouble_AccumulateToNegative15()
       {
           // Act
           //uut.Add(5, 5);

           // Assert
           Assert.That(_uut.Add(-10, -5), Is.EqualTo(-15));
       }

       [Test]
       public void Add_OneNegativeOnePositive_AccumulateToZero()
       {
           // Act
           //uut.Add(5, 5);

           // Assert
           Assert.That(_uut.Add(-5, 5), Is.EqualTo(0));
       }

        // SubtractTests
        [Test]
       public void Subtract_Two_Items()
       {
           // Act
           //uut.Subtract(5, 5);

           // Assert
           Assert.That(_uut.Subtract(5, 5), Is.EqualTo(0));
       }
       [Test]
       public void Subtract_TwoNegativeDouble_AccumulateToNegative5()
       {
           // Assert
           Assert.That(_uut.Subtract(-10, -5), Is.EqualTo(-5));
       }

       [Test]
       public void Subtract_OneNegativeOnePositive_AccumulateToNegative10()
       {
           // Assert
           Assert.That(_uut.Subtract(-5, 5), Is.EqualTo(-10));
       }
        [Test]
       public void Multiply_Two_Items()
       {
           // Act
           //uut.Multiply(5, 5);

           // Assert
           Assert.That(_uut.Multiply(5, 5), Is.EqualTo(25));
       }
       [Test]
       public void Multiply_TwoNegativeDouble_AccumulateTo50()
       {
           // Assert
           Assert.That(_uut.Multiply(-10, -5), Is.EqualTo(50));
       }

       [Test]
       public void Multiply_OneNegativeOnePositive_AccumulateToNegative25()
       {
           // Assert
           Assert.That(_uut.Multiply(-5, 5), Is.EqualTo(-25));
       }

       // DivideTest
       [Test]
       public void Divide_PositiveDouble_AccumulateTo1()
       {
           // Act
           _uut.Divide(5,5);

           // Assert
           Assert.AreEqual(1, _uut.Accumulator);
       }

       [Test]
       public void Divide_NegativeDouble_AccumulateToNegative1()
       {
           // Act
           _uut.Divide(5, -5);

           // Assert
           Assert.AreEqual(-1, _uut.Accumulator);
       }

       [Test]

       public void Divide_DivisorIsZero_Exception()
       {
           // Assert
           Assert.That(()=>_uut.Divide(5,0), Throws.TypeOf<DivideByZeroException>());
       }

        // PowerTests
        [Test]
       public void Power_TwoPositiveDoubles_AccumulateTo3125()
       {
           // Assert
           Assert.That(_uut.Power(5, 5), Is.EqualTo(3125));
       }

       [Test]
       public void Power_TwoNegativeDouble_ThrowException()
       {
           // Assert
            Assert.That(() => _uut.Power(-10, -5), Throws.TypeOf<ArgumentException>());
        }

       [Test]
       public void Power_OneNegativeOnePositive_AccumulateToZero()
       {
           // Assert
           Assert.That(_uut.Power(-5, 5), Is.EqualTo(-3125));
       }

       // OverloadedAddTests
        [Test]
       public void OverloadedAdd_OnePositiveDouble_AccumulateTo5()
       {
           // Act
           _uut.Add(5);
           // Assert
           Assert.AreEqual(5, _uut.Accumulator);
       }

       [Test]
       public void OverloadedAdd_OneNegativeDouble_AccumulateToNegative5()
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
       public void OverloadedSubtract_PositiveDouble_AccumulateToNegative5()
       {
           // Act
           _uut.Subtract(5);

           // Assert
           Assert.AreEqual(-5,_uut.Accumulator);
       }

       [Test]
       public void OverloadedSubtract_OneNegativeDouble_AccumulateTo5()
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
       public void OverloadedMultiply_PositiveDouble_AccumulateToZero()
       {
           // Act
           _uut.Multiply(5);

           // Assert
           Assert.AreEqual(0,_uut.Accumulator);
       }

       [Test]
       public void OverloadedMultiply_NegativeDoubleAccumulatorSetTo2_AccumulateToNegative10()
       {
           // Arrange
           _uut.Add(1, 1);

           // Act
           _uut.Multiply(-5);

           // Assert
           Assert.AreEqual(-10, _uut.Accumulator);
       }

       [Test]
       public void OverloadedMultiply_PositiveDoubleAccumulatorSetTo2_AccumulateTo10()
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
       public void OverloadedDivide_PositiveDouble_AccumulateTo0()
       {
           // Act
           _uut.Divide(5);

           // Assert
           Assert.AreEqual(0, _uut.Accumulator);
       }

       [Test]
       public void OverloadedDivide_PositiveDoubleAccumulatorSetTo10_AccumulateTo2()
       {
           // Arrange
           _uut.Add(5,5);

           // Act
           _uut.Divide(5);

           // Assert
           Assert.AreEqual(2, _uut.Accumulator);
       }

       [Test]
       public void OverloadedDivide_DivisorIsZero_ThrowException()
       {
           // Arrange
           _uut.Add(2, 2);

           // Assert
           Assert.That(() => _uut.Divide(5, 0), Throws.TypeOf<DivideByZeroException>());
        }

       // OverloadedPowerTests
        [Test]
       public void OverloadedPower_TwoPowerCalls_AccumulateTo16()
       {
           // Arrange
           _uut.Add(2, 2);

           // Act
            _uut.Power(2);

           // Assert
           Assert.AreEqual(16, _uut.Accumulator);
       }

       [Test]
       public void OverloadedPower_NegativePower_ThrowException()
       {
           //Arrange
           _uut.Add(0, 2);

           // Assert
           Assert.That(() => _uut.Power(-2), Throws.TypeOf<ArgumentException>());
       }

       [Test]
       public void OverloadedPower_ExponentZero_AccumulateTo1()
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
