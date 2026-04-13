using System;
using System.Media;

namespace Greeting_and_prompting
{
    public class greet_and_name
    {
        // global variable
        private string username = string.Empty;

        // welcome method
        public void welcome()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[WELCOME TO ZORA'S CHATBOT]");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=========================");
            Console.ResetColor();
        }

        // ask name method
        public void ask_name()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Zora's BOT: ");

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Enter your name: ");

                Console.ForegroundColor = ConsoleColor.Gray;
                username = Console.ReadLine();

                Console.ResetColor();

            } while (!isEmpty());
        }

        // check if name is empty
        private bool isEmpty()
        {
            if (!string.IsNullOrWhiteSpace(username))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Zora's BOT: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Hey " + username + "!");
                Console.ResetColor();

                return true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Zora's BOT: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter your name");
                Console.ResetColor();

                return false;
            }
        }

        // CHAT METHOD (FIXED AND IN CORRECT PLACE)
        public void chat()
        {
            string userInput;

            Console.WriteLine("\nStart chatting with Zora (type 'exit' to stop)\n");

            do
            {
                Console.Write("User: ");
                userInput = Console.ReadLine().ToLower();

                if (userInput.Contains("how are you"))
                {
                    Console.WriteLine("Zora: I'm just a bot, but I'm here to help you stay safe online!");
                }
                else if (userInput.Contains("purpose"))
                {
                    Console.WriteLine("Zora: My purpose is to educate you about cybersecurity.");
                }
                else if (userInput.Contains("phishing"))
                {
                    Console.WriteLine("Zora: Phishing is when scammers trick you into giving personal info.");
                }
                else if (userInput.Contains("safe browsing"))
                {
                    Console.WriteLine("Zora: Always look for 'www.' and a padlock icon to ensure safe browsing.");
                    Console.WriteLine("Zora: Avoid clicking on suspicious links or pop-ups.");
                    Console.WriteLine("Zora: Keep your browser and security software up to date.");
                }
                else if (userInput.Contains("password"))
                {
                    Console.WriteLine("Zora: Use strong, unique passwords and consider a password manager.");
                    Console.WriteLine("Zora: Enable two-factor authentication for added security.");

                }
                else if (userInput == "exit")
                {
                    Console.WriteLine("Zora: Goodbye! Stay safe online.");
                }
                else
                {
                    Console.WriteLine("Zora: I didn’t quite understand that. Could you rephrase?");
                }

            } while (userInput != "exit");
        }
    }
}