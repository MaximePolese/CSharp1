using HelloWorld;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTests
{
    [TestClass]
    [TestSubject(typeof(Program))]
    public class MessageTests
    {

        [TestMethod]
        public void AddTest()
        {
            Message test = new Message(6, 12, 19);
            string result = test.Response();
            Assert.AreEqual("Bonjour maxime.polese", result);
        }
    }
}