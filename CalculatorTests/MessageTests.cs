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
        public void MorningTest()
        {
            Message test = new Message(9, 13, 18, new FakeTime(4, 9), new FakeUser("IronMan"));
            string result = test.Response();
            Assert.AreEqual("Bonjour IronMan", result);
        }

        [TestMethod]
        public void AfternoonTest()
        {
            Message test = new Message(9, 13, 18, new FakeTime(4, 13), new FakeUser("IronMan"));
            string result = test.Response();
            Assert.AreEqual("Bon après-midi IronMan", result);
        }

        [TestMethod]
        public void NightTest()
        {
            Message test = new Message(9, 13, 18, new FakeTime(4, 18), new FakeUser("IronMan"));
            string result = test.Response();
            Assert.AreEqual("Bonsoir IronMan", result);
        }

        [TestMethod]
        public void WeekEndTest()
        {
            Message test = new Message(9, 13, 18, new FakeTime(5, 22), new FakeUser("IronMan"));
            string result = test.Response();
            Assert.AreEqual("Bon week-end IronMan", result);
        }
    }
}