using System;

namespace Task6Library
{
    public class ColorGarland : Garland
    {
        public ColorGarland(int bulbsCount)
        {
            for (int i = 0; i < bulbsCount; i++)
            {
                if (DateTime.Now.Minute % 2 == 0)
                {
                    if (i % 2 == 0)
                    {
                        Bulbs.Add(new ColorBulb() { BulbID = i + 1, State = State.Off, Color = (Color)(i % 4) });
                    }
                    else
                    {
                        Bulbs.Add(new ColorBulb() { BulbID = i + 1, State = State.On, Color = (Color)(i % 4) });
                    }
                }
                else
                {
                    Bulbs.Add(new ColorBulb() { BulbID = i + 1, State = (State)(i % 2), Color = (Color)(i % 4) });
                }
            }
        }
    }
}