namespace Task6Library
{
    public class Bulb
    {
        public int BulbID { get; set; }
        public State State { get; set; }

        public override string ToString()
        {
            return BulbID.ToString() + ". " + State.ToString();
        }
    }
}