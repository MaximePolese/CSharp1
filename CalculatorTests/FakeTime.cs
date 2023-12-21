using HelloWorld;

namespace CalculatorTests
{
    public class FakeTime : ITime
    {
        public int GetDay()
        {
            return 8;
        }

        public int GetHour()
        {
            return 4;
        }
    }
}