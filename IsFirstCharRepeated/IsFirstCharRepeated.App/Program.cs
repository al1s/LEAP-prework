using System;

namespace IsFirstCharRepeated.App
{
    public class Program
    {
        public static bool IsFirstCharRepeated(string str)
        {
            string lowerCaseString = str.ToLower();
            for(int i = 1; i < lowerCaseString.Length; i++)
            {
                if (lowerCaseString[0] == (lowerCaseString[i]))
                {
                    return true;
                }
            }
            return false;
        } 
        static void Main(string[] args)
        {
            string str = "Hello World!";
            Console.WriteLine($"Is the first char in string '{str}' repeated elsewhere in the string: {IsFirstCharRepeated(str).ToString()}");
            str = "There is another t in the string";
            Console.WriteLine($"Is the first char in string '{str}' repeated elsewhere in the string: {IsFirstCharRepeated(str).ToString()}");
        }
    }
}
