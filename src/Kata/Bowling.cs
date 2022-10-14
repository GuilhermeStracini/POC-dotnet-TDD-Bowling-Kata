namespace Kata
{
    using System.Collections.Generic;

    public class Bowling
    {
        private IList<int> pinsPerRoll;
        private int rollCounter;

        public Bowling()
        {
            pinsPerRoll = new List<int>();
        }

        public void Roll(int pins)
        {
            pinsPerRoll.Add(pins);

            if (pins == 10)
            {
                rollCounter++;
            }
        }

        public int GetScore()
        {
            return 0;
        }
    }
}
