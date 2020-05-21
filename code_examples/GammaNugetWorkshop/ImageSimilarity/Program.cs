using System;
using DupImageLib;

namespace ImageSimilarity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Let's retrieve the path to the first image to compare
            Console.WriteLine("Drag and drop the first image you wanna compare :");
            var firstImagePath = Console.ReadLine().Trim('"');

            // And the second
            Console.WriteLine("Now drag the second image :");
            var secondImagePath = Console.ReadLine().Trim('"');

            // Calculate hash for the first image
            ImageHashes firstHasher = new ImageHashes();
            var firstImageHash = firstHasher.CalculateDctHash(firstImagePath);

            // And the second
            ImageHashes secondHasher = new ImageHashes();
            var secondImageHash = secondHasher.CalculateDctHash(secondImagePath);

            // Now compare the hashes and print that all in the console
            var similarityScore = DupImageLib.ImageHashes.CompareHashes(firstImageHash, secondImageHash);

            Console.WriteLine("First image hash is " + firstImageHash.ToString());
            Console.WriteLine("Second image hash is " + secondImageHash.ToString());
            Console.WriteLine("Similarity score is " + similarityScore.ToString());

            Console.ReadKey();
        }
    }
}
