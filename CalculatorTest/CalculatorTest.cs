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

       [Test]
       public void Add_Two_Items()
        {
            // Act
            //uut.Add(5, 5);

            // Assert
            Assert.That(_uut.Add(5, 5), Is.EqualTo(10));
        }

       [Test]
       public void Subtract_Two_Items()
       {
           // Act
           //uut.Subtract(5, 5);

           // Assert
           Assert.That(_uut.Subtract(5, 5), Is.EqualTo(0));
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
       public void Power()
       {
           // Act
           //uut.Add(5, 5);

           // Assert
           Assert.That(_uut.Power(5, 5), Is.EqualTo(3125));
       }

       [Test]
       public void Sum_TwoAddCalls_AccumulateToTen()
       {
           // Act
           _uut.Add(2.5, 2.5);
           _uut.Add(5);
           // Assert
           Assert.AreEqual(10, _uut.Accumulator);
       }

       [Test]
       public void Sum_TwoSubtractCalls_AccumulateToZero()
       {
           // Act
           _uut.Subtract(10, 5);
           _uut.Subtract(5);

           // Assert
           Assert.AreEqual(0,_uut.Accumulator);
       }
    }
}
