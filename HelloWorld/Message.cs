using System;

namespace HelloWorld
{
    public class Message
    {
        private string _helloMessage; 
        private string userName = Environment.UserName;
        private int day = (int)DateTime.Now.DayOfWeek;
        private int hour = DateTime.Now.Hour;

        public string HelloMessage
        {
            get => _helloMessage;
            set
            {
                if (day > 0 && day < 6)
                {
                    if (hour > 0 && hour < 9)
                    {
                        Console.WriteLine("Bonsoir " + userName);
                    }
                    else if (hour > 9 && hour < 13)
                    {
                        Console.WriteLine("Bonjour " + userName);
                    }
                    else if (hour > 13 && hour < 18)
                    {
                        Console.WriteLine("Bon après-midi " + userName);
                    }
                    else if (day < 5 && hour > 18 && hour < 24)
                    {
                        Console.WriteLine("Bonsoir " + userName);
                    }
                    else if (hour > 18 && hour < 24)
                    {
                        Console.WriteLine("Bon week-end " + userName);
                    }
                }
                else
                {
                    Console.WriteLine("Bon week-end " + userName);
                }
            }
        }
    }
}