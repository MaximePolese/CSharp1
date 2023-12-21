using HelloWorld;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    [TestSubject(typeof(Program))]
    public class CalculatorTests
    {

        [TestMethod]
        public void AddTest()
        {
            Calculator test = new Calculator();
            string result = test.Add();
            Assert.AreEqual("salut", result);
        }
       
    }
}