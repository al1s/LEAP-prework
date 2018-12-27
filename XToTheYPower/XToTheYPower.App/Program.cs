using System;

namespace XToTheYPower.App
{
    public class Program
    {
        /// <summary>
        /// Calculate the power of a given number (iteratively)
        /// </summary>
        /// <param name="baseNum">A number to calculate the power of</param>
        /// <param name="power">A power</param>
        /// <returns>Result of baseNum^power</returns>
        public static int XToTheYPowerIter(int baseNum, int power)
        {
            int result = 1;
            for(int i = 1; i <= power; i++)
            {
                result *= baseNum;
            }
            return result;
        }

        /// <summary>
        /// Calculate the power of a given number (recursively)
        /// </summary>
        /// <param name="baseNum">A number to calculate the power of</param>
        /// <param name="power">A power</param>
        /// <returns>Result of baseNum^power</returns>
        public static int XToTheYPowerRecur(int baseNum, int power)
        {
            if (power == 0)
                return 1;
            if (power == 1)
                return baseNum;
            return baseNum * XToTheYPowerRecur(baseNum, power - 1);
        }
        static void Main(string[] args)
        {
            var (baseNum, power) = (2, 2);
            Console.WriteLine($"{baseNum}^{power}={XToTheYPowerIter(baseNum, power)}");
            Console.WriteLine($"{baseNum}^{power}={XToTheYPowerRecur(baseNum, power)}");
            (baseNum, power) = (2, 8);
            Console.WriteLine($"{baseNum}^{power}={XToTheYPowerIter(baseNum, power)}");
            Console.WriteLine($"{baseNum}^{power}={XToTheYPowerRecur(baseNum, power)}");
        }
    }
}
