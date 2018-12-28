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
        /// <summary>
        /// Get the product of all numbers in the list (divide-and-conquer)
        /// </summary>
        /// <param name="numbers">List of numbers</param>
        /// <returns>Product of numbers</returns>
        public static int MultiplyListRecur(List<int> numbers)
        {
            if (numbers.Count == 1)
                return numbers[0];
            return numbers[0] * MultiplyListRecur(numbers.GetRange(1, numbers.Count - 1));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
