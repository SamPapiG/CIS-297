using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGameForm
{
    public class Dice
    {
        //VARIABLES
        //will have one of these at class level
        private IRandom random;
        private int[] diceValues;
        public int RollCount { get; set; }
        //public int dieNumber = 0;

        //holding dice functions, return bool values
        public bool HoldDie1 { get; set; }
        public bool HoldDie2 { get; set; }
        public bool HoldDie3 { get; set; }
        public bool HoldDie4 { get; set; }
        public bool HoldDie5 { get; set; }

        //default constructor
        public Dice(IRandom random)
        {
            this.random = random;
            diceValues = new int[5];

            //booleans for hold state of dice, constructor will set to false
            HoldDie1 = false;
            HoldDie2 = false;
            HoldDie3 = false;
            HoldDie4 = false;
            HoldDie5 = false;

            //count of the rolls, in Yahtzee, you roll 3 times
            RollCount = 0;
            //Roll();
        }

        public void Roll()
        {
           //logic needed around roll count
            if (RollCount < 3)
            {

                if (!HoldDie1)
                {
                    diceValues[0] = random.Next(1, 7);
                }
                if (!HoldDie2)
                {
                    diceValues[1] = random.Next(1, 7);
                }
                if (!HoldDie3)
                {
                    diceValues[2] = random.Next(1, 7);
                }
                if (!HoldDie4)
                {
                    diceValues[3] = random.Next(1, 7);
                }
                if (!HoldDie5)
                {
                    diceValues[4] = random.Next(1, 7);
                }
                RollCount++;
            }
        }

        //method to get die value
        public int GetDieValue(int dieNumber)
        {
            if (dieNumber < 1 || dieNumber > 5)
            {
                throw new IndexOutOfRangeException("Must use die number 1-5");
            }

            return diceValues[dieNumber - 1];
        }

        public void SetHoldDiceStatusToFalse()
        {
            //change hold dice status to false
            HoldDie1 = false;
            HoldDie2 = false;
            HoldDie3 = false;
            HoldDie4 = false;
            HoldDie5 = false;
        }
    }
}
    

