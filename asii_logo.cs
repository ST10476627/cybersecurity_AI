using System;
using System.Drawing;

namespace ai_chats
{// start of namespace
    public class ascii_logo
    {// stat of class
        public ascii_logo()
        {// start of constructor
            // call the ascii method 
            ascii();

        }// end constructor

        // ascii drawing method
        private void ascii()
        {
            //path of the logo [ where the logo is ]
            string path = string.Empty;
            // auto get full path 
            string fullpath=AppDomain.CurrentDomain.BaseDirectory;
            // now cobine the paths
            path = fullpath.Replace(@"bin\Debug\","logo.png");
            


            Bitmap image = new Bitmap(path);

            // Resize for better console fit
            int width = 50;
            int height =30; //(image.Height * width) / image.Width;
            Bitmap resized = new Bitmap(image, new Size(width, height));

            // Default color , you can set yours before this line
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            string asciiChars = "@#S%?*+;:,. ";

            //start by the height
            for (int y = 0; y < resized.Height; y++)
            {
                //then width
                for (int x = 0; x < resized.Width; x++)
                {
                    //color the pixel on x and y
                    Color pixel = resized.GetPixel(x, y);

                    // Convert to grayscale
                    int gray = (pixel.R + pixel.G + pixel.B) / 3;

                    // Map grayscale to ASCII
                    int index = (gray * (asciiChars.Length - 1)) / 255;

                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        }

    }// end of  class 
}// end of namespace