using System;
using HelloWorld;

namespace CalculatorTests
{
    public class FakeTime : ITime
    {
        private DateTime _fakeTime;

        public FakeTime(int fakeDay, int fakeHour)
            : this(2023, 12, fakeDay, fakeHour, 0, 0)
        {
        }

        public FakeTime(int year, int month, int fakeDay, int fakeHour, int minute, int second)
        {
            _fakeTime = new DateTime(year, month, fakeDay, fakeHour, minute, second);
        }

        public int GetDay()
        {
            return _fakeTime.Day;
        }

        public int GetHour()
        {
            return _fakeTime.Hour;
        }
    }
}