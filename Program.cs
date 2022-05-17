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

            var revStr = string.Empty;

            for (var i = length - 1; i >= 0; i--)
            {
                revStr = revStr + str[i];
            }

            Console.WriteLine(revStr);


        }


    }
}
