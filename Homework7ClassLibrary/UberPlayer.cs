namespace Homework7ClassLibrary
{
    public class UberPlayer : Player
    {
        private int currentNumber = 40;

        public override int GuessTheWeight()
        {
            return currentNumber++;
        }
        public UberPlayer(string name)
        {
            Name = name;
        }
    }
}
