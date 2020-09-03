using System;
using System.Threading;
using Calculators;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    class CalculatorTest
    {
       [Test]
       public void Add_Two_Items()
        {
            // Arrange
            var uut = new Calculator();

            // Act
            //uut.Add(5, 5);

            // Assert
            Assert.That(uut.Add(5, 5), Is.EqualTo(10));
        }

       [Test]
       public void Subtract_Two_Items()
       {
           // Arrange
           var uut = new Calculator();

           // Act
           //uut.Subtract(5, 5);

           // Assert
           Assert.That(uut.Subtract(5, 5), Is.EqualTo(0));
       }
       [Test]
       public void Multiply_Two_Items()
       {
           // Arrange
           var uut = new Calculator();

           // Act
           //uut.Multiply(5, 5);

           // Assert
           Assert.That(uut.Multiply(5, 5), Is.EqualTo(25));
       }
       [Test]
       public void Power()
       {
           // Arrange
           var uut = new Calculator();

           // Act
           //uut.Add(5, 5);

           // Assert
           Assert.That(uut.Power(5, 5), Is.EqualTo(3125));

       }
    }
}
