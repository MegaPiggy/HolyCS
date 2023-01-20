namespace HolyCS.Hell
{
    public class Sin : System.Exception
    {
        public Sin(Heaven.Passage passage) : base(passage)
        {

        }

        public Sin(Heaven.Passage passage, Sin innerSin) : base(passage, innerSin)
        {

        }
    }
}