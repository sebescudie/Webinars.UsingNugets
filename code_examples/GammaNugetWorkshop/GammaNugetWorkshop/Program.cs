using System;
using StringExtensionLibrary;

namespace GammaNugetWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            // Capitalize a string
            Console.WriteLine(StringExtensions.Capitalize("vvvv gamma"));

            // Create SHA256
            Console.WriteLine(StringExtensions.CreateHashSha256("encrypt me"));

            // Remove prefix
            Console.WriteLine(StringExtensions.RemovePrefix("pre_Hello", "pre_", true));

            // Reverse slash
            Console.WriteLine(StringExtensions.ReverseSlash("reverse/slash", 0));

            // Validate IPV4
            Console.WriteLine(StringExtensions.IsValidIPv4("192.168.1.256"));

            Console.ReadKey();
        }
    }
}
