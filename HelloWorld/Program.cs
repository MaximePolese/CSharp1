using System;

namespace HelloWorld
{
    internal class Program
    {
        // private void quit()
        // {
        //     return keyInfo.Key != ConsoleKey.Q;
        // }
        public static void Main(string[] args)
        {
            string userName = Environment.UserName;
            Message message = new Message(9, 13, 18)
            {
                HelloMessage = userName
            };

            ConsoleKeyInfo keyInfo;
            string exit = "";

            do
            {
                Console.WriteLine("Press 'Q' to quit or press 'Enter' to continue");
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine(message.HelloMessage);
                }

                exit = Console.ReadLine();
            } while (exit != "exit");
        }
    }
}