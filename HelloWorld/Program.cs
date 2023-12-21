using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Message message = new Message(9, 13, 18);
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