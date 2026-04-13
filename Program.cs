using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ai_chats
{// start of name
    public class Program
    {// start of class
       public static void Main(string[] args)
        {// start of main
            // creating an instance 
            new voice_greeting() { };
            // creat an instance for asii_logo class
            // with conductor
            new ascii_logo() {  };
            // creating an instance for the welcome_and_username class
            // with an opbject name welcome_and collect
            welcome_and_username welcome_and_collect = new welcome_and_username();
            welcome_and_collect.welcome();
           welcome_and_collect.ask_user();
            new ResponseClass() { };
             Chats chat= new Chats();
            chat.StartChat();
        }// end of main
    }// end of class
}// end of n
