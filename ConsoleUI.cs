using System;

namespace CyberSecurityChatbot
{
    public class ConsoleUI
    {
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("==============================================");
            Console.WriteLine("   CYBERSECURITY AWARENESS CHATBOT");
            Console.WriteLine("==============================================");
            Console.WriteLine("        Stay Safe Online 🔒");
            Console.WriteLine("==============================================");

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
   _____       _                 
  / ____|     | |                
 | |     _   _| |__   ___ _ __   
 | |    | | | | '_ \ / _ \ '__|  
 | |____| |_| | |_) |  __/ |     
  \_____|\__,_|_.__/ \___|_|     
");

            Console.ResetColor();
        }
    }
}