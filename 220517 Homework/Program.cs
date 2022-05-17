using System;

namespace _220517_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string str = "Nurlan Faiq Emil";

            var chars = str.ToCharArray();
            var length = chars.Length;

            Console.WriteLine($"String length is: {length}");

            for (var i = length-1; i >= 0; i--)
            {
                Console.WriteLine(chars[i]);
            }

        }


    }
}
