using System;

namespace Task6Library
{
    public class Validation
    {
        public static int GetValidBulbsCount()
        {
            int validatedValue;

            while (!int.TryParse(GetValueNotNullOrEmpty(), out validatedValue) || validatedValue <= 0)
            {
                Console.Clear();
                Console.WriteLine($"Entered value is invalid.{Environment.NewLine}Please enter a number of bulbs in the garlands:");
            }
            return validatedValue;
        }

        public static string GetValueNotNullOrEmpty()
        {
            var inputValue = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(inputValue))
            {
                Console.Clear();
                Console.WriteLine($"Entered value is null or empty.{Environment.NewLine}Please enter a number of bulbs in the garlands:");
                inputValue = Console.ReadLine();
            }
            return inputValue;
        }
    }
}