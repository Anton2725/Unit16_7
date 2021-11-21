using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit16_7.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Additional(100, 10) == 110);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Subtraction(300, 10) == 290);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Miltiplication(2, 4) == 8);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();

            Assert.That(calculator.Division(200, 10) == 20);
        }

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();

            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
