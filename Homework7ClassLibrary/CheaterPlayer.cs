﻿using System;
using System.Collections.Generic;

namespace Homework7ClassLibrary
{
    public class CheaterPlayer : Player
    {
        private List<int> UsedNumbers;
        public override int GuessTheWeight()
        {
            Random random = new Random();
            int result = random.Next(40, 141);
            while (UsedNumbers.Contains(result))
            {
                result = random.Next(40, 141);
            }
            return result;
        }
        public CheaterPlayer(string name, List<int> numbers)
        {
            Name = name;
            UsedNumbers = numbers;
        }
    }
}
