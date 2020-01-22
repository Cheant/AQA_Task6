using System;
using System.Collections.Generic;

namespace Task6Library
{
    public abstract class Garland<TBulbType> where TBulbType : Bulb
    {
        public List<TBulbType> Bulbs = new List<TBulbType>();

        public void PrintStateOfGarland()
        {
            foreach (var bulb in Bulbs)
            {
                Console.WriteLine(bulb);
            }
        }
    }
}