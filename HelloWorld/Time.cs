using System;

namespace HelloWorld
{
    public class Time : ITime
    {
        public int GetDay()
        {
            return (int)DateTime.Now.DayOfWeek;
        }

        public int GetHour()
        {
            return DateTime.Now.Hour;
        }
    }
}