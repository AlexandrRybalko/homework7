﻿using System;
using System.Collections.Generic;

namespace Homework7ClassLibrary
{
    public class PlayerNotepad : Player
    {
        private List<int> UsedNumbers = new List<int>();
        public override int GuessTheWeight()
        {
            Random random = new Random();
            int result = random.Next(40, 141);
            while (UsedNumbers.Contains(result))
            {
                result = random.Next(40, 141);
            }
            UsedNumbers.Add(result);
            return result;
        }
        public PlayerNotepad(string name)
        {
            Name = name;
        }
    }
}
