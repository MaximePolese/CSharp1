using HelloWorld;

namespace CalculatorTests
{
    public class FakeUser : IUser
    {
        private string _name;

        public FakeUser(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }
    }
}