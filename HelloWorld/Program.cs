using System;

namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            var userName = Environment.UserName;
            Console.WriteLine("Bonjour " + userName);
            
            var now = DateTime.Now;
            Console.WriteLine(now);
            
            var day = (int)DateTime.Now.DayOfWeek;
            var hour = DateTime.Now.Hour;
            // var day = 0;
            // var hour = 21;
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