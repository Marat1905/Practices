using Practices.Calc;

namespace Practices.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AdditionalMustAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Additional(10, 220), Is.EqualTo(230));
        }

        [Test]
        public void SubtractionMustAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Subtraction(100, 50), Is.EqualTo(50));
        }

        [Test]
        public void MiltiplicationMustAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Miltiplication(100, 50), Is.EqualTo(5000));
        }

        [Test]
        public void DivisionMustAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Division(100, 50), Is.EqualTo(2));
        }

        [Test]
        public void DivisionMustThrowException()
        {
            var calculatorTest = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculatorTest.Division(100, 0));
        }
    }
}
