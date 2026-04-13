using System;
using System.Runtime.InteropServices;
namespace ai_chats
{
    public class welcome_and_username
    {
        // global variable
        private string username= string.Empty;
        // void method to welcome the user
        public void welcome()
        {// start of method
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine("WELCOME TO LUMISPARK");
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("----------------------------------");
            // rest color 
            Console.ResetColor();
        }// end of method
         // method to ask for the user name 
        public void ask_user()
        {
            // AI message and name  with text color
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("LUMI:");
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("Hello! I'm Lumi, your cybersecurity AI assistant.");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" Please enter your name");

            do { // start of do while
                //promp and text

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("User:");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                username= Console.ReadLine();  
            } while (!empty());// end of do while
          

                }// end of method ask_user
        // Boolean method to check the username if not empty
        private Boolean empty() {
            // check if not empty by if statement
            if (username != "")
            {// start of if 
                // sucess message
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("LUMI:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hey" +" "+ username);
                return true;

            }// end of if
            else
            {// start of else 
                // error messqge
                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.Write("LUMI:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Hey"+"  " + username);
                return false;
            }
        }
            
    }
}