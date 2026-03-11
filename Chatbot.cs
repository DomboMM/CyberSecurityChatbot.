using System;

namespace CyberSecurityChatbot
{
    public class Chatbot
    {
        public string UserName { get; set; }

        public void StartChat()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("\nEnter your name: ");
            UserName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(UserName))
            {
                UserName = "User";
            }

            Console.WriteLine($"\nHello {UserName}! I'm your Cybersecurity Awareness Assistant.");
            Console.WriteLine("You can ask me about:");
            Console.WriteLine("1 Password safety");
            Console.WriteLine("2 Phishing");
            Console.WriteLine("3 Safe browsing");
            Console.WriteLine("4 My purpose");
            Console.WriteLine("5 Or type 'exit' to quit.\n");

            ChatLoop();
        }

        private void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nYou: ");

                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Bot: Please enter a question.");
                    continue;
                }

                if (input == "exit")
                {
                    Console.WriteLine("Bot: Goodbye! Stay safe online.");
                    break;
                }

                Respond(input);
            }
        }

        private void Respond(string input)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (input.Contains("how are you"))
            {
                Console.WriteLine("Bot: I'm functioning perfectly and ready to help keep you safe online!");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("Bot: My purpose is to educate people about cybersecurity threats and how to avoid them.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("Bot: Use strong passwords with uppercase letters, numbers, and symbols.");
                Console.WriteLine("Bot: Avoid using the same password for multiple accounts.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("Bot: Phishing emails try to trick you into revealing personal information.");
                Console.WriteLine("Bot: Always check the sender's email address and avoid suspicious links.");
            }
            else if (input.Contains("safe browsing") || input.Contains("browsing"))
            {
                Console.WriteLine("Bot: Only visit secure websites (https).");
                Console.WriteLine("Bot: Avoid clicking on unknown advertisements or links.");
            }
            else if (input.Contains("what can i ask"))
            {
                Console.WriteLine("Bot: You can ask about password safety, phishing, safe browsing, or cybersecurity tips.");
            }
            else
            {
                Console.WriteLine("Bot: I didn't quite understand that. Could you rephrase?");
            }
        }
    }
}