using System;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleUI.ShowLogo();

            AudioPlayer.PlayGreeting();

            Chatbot bot = new Chatbot();
            bot.StartChat();

            Console.ReadKey();
        }
    }
}// Main entry point of the chatbot