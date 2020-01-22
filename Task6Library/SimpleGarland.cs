using System;

namespace Task6Library
{
    public class SimpleGarland : Garland<Bulb>
    {
        public SimpleGarland(int bulbsCount)
        {
            for (int i = 0; i < bulbsCount; i++)
            {
                if (DateTime.Now.Minute % 2 == 0)
                {
                    if (i % 2 == 0)
                    {
                        Bulbs.Add(new Bulb() { BulbID = i + 1, State = State.Off });
                    }
                    else
                    {
                        Bulbs.Add(new Bulb() { BulbID = i + 1, State = State.On });
                    }
                }
                else
                {
                    Bulbs.Add(new Bulb() { BulbID = i + 1, State = (State)(i % 2) });
                }
            }
        }
    }
}