using System;
using Task6Library;

namespace Task6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Please enter a number of bulbs in the garlands:");
            int bulbsCount = Validation.GetValidBulbsCount();

            Console.WriteLine($"{Environment.NewLine}Simple Garland:{Environment.NewLine}");
            SimpleGarland simpleGarland = new SimpleGarland(bulbsCount);
            simpleGarland.PrintStateOfGarland();

            Console.WriteLine($"{Environment.NewLine}Color Garland:{Environment.NewLine}");
            ColorGarland colorGarland = new ColorGarland(bulbsCount);
            colorGarland.PrintStateOfGarland();

            Console.ReadKey();
        }
    }
}