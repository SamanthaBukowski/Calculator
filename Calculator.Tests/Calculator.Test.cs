using Microsoft.VisualStudio.TestTools.UnitTesting;
using Services;

namespace Tests
{
    [TestClass]
    public class Calculate
    {
        private readonly Calculator _calculator;

        public Calculate()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Should_Add()
        {
            var result = _calculator.Add(1, 1);
            Assert.AreEqual(result, 2, "1 + 1 should be 2.");
        }

        [TestMethod]
        public void Should_Subract()
        {
            var result = _calculator.Subtract(1, 1);
            Assert.AreEqual(result, 0, "1 - 1 should be 0.");
        }

        
        [TestMethod]
        public void Should_Divide()
        {
            var result = _calculator.Divide(15, 3);
            Assert.AreEqual(result, 5, "15 / 3 should be 5.");
        }

                [TestMethod]
        public void Should_Multiply()
        {
            var result = _calculator.Multiply(3, 3);
            Assert.AreEqual(result, 9, "3 * 3 should be 9.");
        }
        [TestMethod]
        public void Should_Give_Average()
        {
            var result = _calculator.Average(4,10);
            Assert.AreEqual(result, 7, "(4+10)/2 should be 7.");
        }
    
        

        
    }
}

