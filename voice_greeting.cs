using System;
using System.Media;

namespace ai_chats
{// start of name space 
    public class voice_greeting
    {//  start of class 
        public voice_greeting()
        {
            greet();
        }
        private void greet()
        {
            // auto get the path of the voice record 
            string paths = AppDomain.CurrentDomain.BaseDirectory;
            // then rename path 
            string fullpath = paths.Replace(@"bin\Debug\","greetings.wav");
            SoundPlayer voice_play = new SoundPlayer(fullpath);
            voice_play.Load();
            //
            voice_play.Play();

        }
    }
}