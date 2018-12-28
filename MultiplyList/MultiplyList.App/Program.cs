using System;
using System.Collections.Generic;

namespace MultiplyList.App
{
    public class Program
    {
        /// <summary>
        /// Get the product of all numbers in the list (iteratively)
        /// </summary>
        /// <param name="numbers">List of numbers</param>
        /// <returns>Product of numbers</returns>
        public static int MultiplyListIter(List<int> numbers)
        {
            int result = 1;
            foreach (int number in numbers)
            {
                result *= number;
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
