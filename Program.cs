using System;
using System.Text;

namespace ConvertHex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alpha = "Hello";
            Converter(alpha);
        }

        static void Converter(string alpha)
        {

            byte[] asciiBytes = Encoding.ASCII.GetBytes(alpha.ToLower());
            var hexString = BitConverter.ToString(asciiBytes);
            hexString = hexString.Replace("-", " ");

            Console.WriteLine(hexString);
        }
    }
}
