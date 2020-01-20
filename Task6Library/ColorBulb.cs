namespace Task6Library
{
    public class ColorBulb : Bulb
    {
        public Color Color { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\t" + Color.ToString();
        }
    }
}