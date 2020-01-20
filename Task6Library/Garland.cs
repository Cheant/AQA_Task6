using System;
using System.Collections.Generic;

namespace Task6Library
{
    public abstract class Garland
    {
        public List<Bulb> Bulbs = new List<Bulb>();

        public void PrintStateOfGarland()
        {
            foreach (var bulb in Bulbs)
            {
                Console.WriteLine(bulb);
            }
        }
    }
}