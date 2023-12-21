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
            Message test = new Message(9, 13, 18, new FakeTime(4, 11), new FakeUser("IronMan"));
            string result = test.Response();
            string name = test.GetUser.GetName();
            Assert.AreEqual("Bonjour " + name, result);
        }

        [TestMethod]
        public void AfternoonTest()
        {
            Message test = new Message(9, 13, 18, new FakeTime(4, 15), new FakeUser("IronMan"));
            string result = test.Response();
            Assert.AreEqual("Bon après-midi IronMan", result);
        }

        [TestMethod]
        public void NightTest()
        {
            Message test = new Message(9, 13, 18, new FakeTime(4, 22), new FakeUser("IronMan"));
            string result = test.Response();
            Assert.AreEqual("Bonsoir IronMan", result);
        }

        [TestMethod]
        public void WeekEndTest()
        {
            Message test = new Message(9, 13, 18, new FakeTime(6, 22), new FakeUser("IronMan"));
            string result = test.Response();
            Assert.AreEqual("Bon week-end IronMan", result);
        }
    }
}