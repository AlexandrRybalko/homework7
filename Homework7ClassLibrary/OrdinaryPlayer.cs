using System;

namespace Homework7ClassLibrary
{
    public class OrdinaryPlayer : Player
    {
        public override int GuessTheWeight()
        {
            Random random = new Random();
            return random.Next(40, 141);
        }
        public OrdinaryPlayer(string name)
        {
            Name = name;
        }
    }
}
