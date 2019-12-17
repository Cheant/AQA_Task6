using System;
using Task6Library;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("HH:mm:ss"));
            Console.WriteLine(DateTime.Now.ToString("mm"));

            int x = Convert.ToInt32(DateTime.Now.ToString("mm"));
            Console.WriteLine(x);

            Console.ReadKey();
        }
    }
}
