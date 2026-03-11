using System;
using System.Media;

namespace CyberSecurityChatbot
{
    public class AudioPlayer
    {
        public static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer("greeting.wav"); // make sure path is correct
                player.PlaySync(); // play synchronously
                Console.WriteLine("Greeting played successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing greeting: {ex.Message}");
            }
        }
    }
}