using System;

namespace ai_chats
{
    public class Chats
    {
        public void StartChat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What can I help you with? or (type 'exit' to quit)");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("user: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                {
                   Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("LUMI:Goodbye thanks for using Lumispark your spark of bright ideas");
                    break;
                }

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("LUMI: What can I assist you with.");
                    continue;
                }

                ResponseClass.Respond(input);
            }
        }
    }
}