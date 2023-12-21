using System;

namespace HelloWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string userName = Environment.UserName;
            Message message = new Message(9, 13, 18)
            {
                HelloMessage = userName
            };

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

            // string exit = "";
            // while (exit != "exit")
            // {
            //     Console.WriteLine("Write 'exit' to quit or press 'Enter' to continue");
            //     exit = Console.ReadLine();
            //     if (exit != "exit")
            //     {
            //         Console.WriteLine(message.HelloMessage);
            //     }
            // }
        }
    }
}