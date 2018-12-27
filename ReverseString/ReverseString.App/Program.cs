using System;

namespace ReverseString.App
{
    public class Program
    {
        /// <summary>
        /// Iteratively reverse a string
        /// </summary>
        /// <param name="str">String to be reveresed</param>
        /// <returns>Reversed string</returns>
        public static string ReverseStringIterative(string str)
        {
            char[] result = new char[str.Length];
            for(int i = str.Length - 1; i >= 0; i--)
            {
                result[str.Length - i - 1] = str[i];
            }
            return new string(result);
        }

        /// <summary>
        /// Recursively reverse a string
        /// </summary>
        /// <param name="str">String to be reveresed</param>
        /// <returns>Reversed string</returns>
        public static string ReverseStringRecursion(string str)
        {
            if (str.Length == 1)
                return str[0].ToString();
            string lastChar = str[str.Length - 1].ToString();
            string restOfString = ReverseStringRecursion(str.Substring(0, str.Length - 1));
            return $"{lastChar}{restOfString}";
        }
        /// <summary>
        /// Visually present the algorithms results
        /// </summary>
        /// <param name="args">Optional (not used)</param>
        static void Main(string[] args)
        {
            string str = "Hello World!";
            Console.WriteLine($"Reversed by iterations: '{ReverseStringIterative(str)}'");
            Console.WriteLine($"Reversed by recursion: '{ReverseStringRecursion(str)}'");
        }
    }
}
