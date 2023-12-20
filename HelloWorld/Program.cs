using System;

namespace HelloWorld
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var userName = Environment.UserName;

            var message = new Message(9, 13, 18);
            message.HelloMessage = userName;

            ConsoleKeyInfo keyInfo;
            do
            {
                Console.WriteLine("Press 'Q' to quit or press 'Enter' to continue");
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(message.HelloMessage);
                }
            } while (keyInfo.Key != ConsoleKey.Q);
        }
    }
}