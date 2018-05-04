
using Calculator;
using NUnit.Framework;

namespace UnitTestCalculator
{
    [TestFixture]
    public class CalculatorTestClass
    {
        Calculator.Calculator cal = new Calculator.Calculator();

        [TestCase(1,1,2)]
        [TestCase(-1, 1, 0)]
        [TestCase(1000, 122, 1122)]
        public void CanAddnumber(int x,int y,int expected)
        {
            Assert.That(cal.Add(x, y), Is.EqualTo(expected));

        }



        public void CanDivideNumber(int x,int y, int expected)
    }
}
