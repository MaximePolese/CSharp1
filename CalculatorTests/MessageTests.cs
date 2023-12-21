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
        public void BonjourTest()
        {
            Message test = new Message(9, 13, 18, new FakeTime(4, 11));
            string result = test.Response();
            Assert.AreEqual("Bonjour maxime.polese", result);
        }
    }
}