using System;
using System.Drawing;
using ColorThiefDotNet;

namespace ColorExtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to drag and drop an image file in the console
            Console.WriteLine("From which image should I extract a color palette?");
            var imagePath = Console.ReadLine();

            // Create a Bitmap variable
            Bitmap bitmap = new Bitmap(imagePath.Trim('"'));

            // Create the ColorThief object and extract the colors
            ColorThief colorExtractor = new ColorThief();
            var extractedColors = colorExtractor.GetPalette(bitmap);

            // Iterate through extracted colors to retrieve the hex code, and print it
            Console.WriteLine("Here are our extracted colors");
            foreach(var color in extractedColors)
            {
                Console.WriteLine(color.Color.ToHexString());
            }

            Console.ReadKey();
        }
    }
}
