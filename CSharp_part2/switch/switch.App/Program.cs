using System;

namespace Switch.App
{
    internal class Program
    {
        private enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        private static void Main(string[] args)
        {
            while (true)
            {
                string result = string.Empty;
                Console.WriteLine("Press any key to choose random month (q to quit):");
                ConsoleKeyInfo pressed = Console.ReadKey();
                Console.Write("\b \b");
                if (pressed.KeyChar.ToString() == "q")
                    break;
                Random rnd = new Random();
                int randomNumber = rnd.Next(1, 13);
                Month month = (Month)randomNumber;
                switch (randomNumber)
                {
                    case 12:
                    case 1:
                    case 2:
                        result = $"It's a Winter and the month is {month}";
                        break;
                    case 3:
                    case 4:
                    case 5:
                        result = $"It's a Spring and the month is {month}";
                        break;
                    case 6:
                    case 7:
                    case 8:
                        result = $"It's a Summer and the month is {month}";
                        break;
                    case 9:
                    case 10:
                    case 11:
                        result = $"It's a Fall and the month is {month}";
                        break;
                }
                Console.WriteLine(result);
                Console.WriteLine();
            }
        }
    }
}
