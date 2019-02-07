using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YahtzeeGameForm
{
    public class ScoreCard
    {

        public int Ones { get; set; }
        public int Twos { get; set; }
        public int Threes { get; set; }
        public int Fours { get; set; }
        public int Fives { get; set; }
        public int Sixes { get; set; }
        public int UpperTotal { get; set; }
        public int ThreeOfAKind { get; set; }
        public int FourOfAKind { get; set; }
        public int FullHouse { get; set; }
        public int SmallStraight { get; set; }
        public int LargeStraight { get; set; }
        public int Chance { get; set; }
        public int Yahtzee { get; set; }
        public int LowerTotal { get; set; }
        public int TotalScore { get; set; }



        //ScoreCard constructor
        public ScoreCard(Dice DiceTime)
        {
            Chance = 0;
            Ones = 0;
            Twos = 0;
            Threes = 0;
            Fours = 0;
            Fives = 0;
            Sixes = 0;
            UpperTotal = 0;
            LowerTotal = 0;
            TotalScore = 0;

            //this.dice = dice;
            //if (DiceTime.GetDieValue(0) == 1 || DiceTime.GetDieValue(1) == 1 || DiceTime.GetDieValue(2) == 1 || DiceTime.GetDieValue(3) == 1 || DiceTime.GetDieValue(4) == 1)
            //{

            //}
        }
        //calculating logic and snippets of code from https://www.codeproject.com/Articles/8657/A-Simple-Yahtzee-Game
        //calculating Ones
        public int CalculateOnes(Dice DiceTime)
        {
            Ones = 0;
            if (DiceTime.GetDieValue(1) == 1)
            {
                Ones++;
            }

            if (DiceTime.GetDieValue(2) == 1)
            {
                Ones++;
            }

            if (DiceTime.GetDieValue(3) == 1)
            {
                Ones++;
            }

            if (DiceTime.GetDieValue(4) == 1)
            {
                Ones++;
            }

            if (DiceTime.GetDieValue(5) == 1)
            {
                Ones++;
            }


            return Ones;
        }

        //calculating Twos
        public int CalculateTwos(Dice DiceTime)
        {
            Twos = 0;
            if (DiceTime.GetDieValue(1) == 2)
            {
                Twos += 2;
            }

            if (DiceTime.GetDieValue(2) == 2)
            {
                Twos += 2;
            }

            if (DiceTime.GetDieValue(3) == 2)
            {
                Twos += 2;
            }

            if (DiceTime.GetDieValue(4) == 2)
            {
                Twos += 2;
            }

            if (DiceTime.GetDieValue(5) == 2)
            {
                Twos += 2;
            }
            return Twos;
        }

        //calculating Threes
        public int CalculateThrees(Dice DiceTime)
        {
            Threes = 0;
            if (DiceTime.GetDieValue(1) == 3)
            {
                Threes += 3;
            }

            if (DiceTime.GetDieValue(2) == 3)
            {
                Threes += 3;
            }

            if (DiceTime.GetDieValue(3) == 3)
            {
                Threes += 3;
            }

            if (DiceTime.GetDieValue(4) == 3)
            {
                Threes += 3;
            }

            if (DiceTime.GetDieValue(5) == 3)
            {
                Threes += 3;
            }


            return Threes;
        }

        //calculating Fours
        public int CalculateFours(Dice DiceTime)
        {
            Fours = 0;
            if (DiceTime.GetDieValue(1) == 4)
            {
                Fours += 4;
            }

            if (DiceTime.GetDieValue(2) == 4)
            {
                Fours += 4;
            }

            if (DiceTime.GetDieValue(3) == 4)
            {
                Fours += 4;
            }

            if (DiceTime.GetDieValue(4) == 4)
            {
                Fours += 4;
            }

            if (DiceTime.GetDieValue(5) == 4)
            {
                Fours += 4;
            }


            return Fours;
        }

        //calculating Fives
        public int CalculateFives(Dice DiceTime)
        {
            Fives = 0;
            if (DiceTime.GetDieValue(1) == 5)
            {
                Fives += 5;
            }

            if (DiceTime.GetDieValue(2) == 5)
            {
                Fives += 5;
            }

            if (DiceTime.GetDieValue(3) == 5)
            {
                Fives += 5;
            }

            if (DiceTime.GetDieValue(4) == 5)
            {
                Fives += 5;
            }

            if (DiceTime.GetDieValue(5) == 5)
            {
                Fives += 5;
            }


            return Fives;
        }

        //calculating Sixes
        public int CalculateSixes(Dice DiceTime)
        {
            Sixes = 0;
            if (DiceTime.GetDieValue(1) == 6)
            {
                Sixes += 6;
            }

            if (DiceTime.GetDieValue(2) == 6)
            {
                Sixes += 6;
            }

            if (DiceTime.GetDieValue(3) == 6)
            {
                Sixes += 6;
            }

            if (DiceTime.GetDieValue(4) == 6)
            {
                Sixes += 6;
            }

            if (DiceTime.GetDieValue(5) == 6)
            {
                Sixes += 6;
            }


            return Sixes;
        }

        //calculate total for Upper numbers
        public int CalculateUpperTotal(Dice DiceTime)
        {
            //UpperTotal = Score.Ones + Score.Twos + Score.Threes + Score.Fours + Score.Fives + Score.Sixes;
            UpperTotal = Ones + Twos + Threes + Fours + Fives + Sixes;

            return UpperTotal;
        }


        //calculate Three of a kind 
        public int CalculateThreeOfAKind(Dice DiceTime)
        {
            //temporary array
            int[] temp = new int[5];
            temp[0] = DiceTime.GetDieValue(1);
            temp[1] = DiceTime.GetDieValue(2);
            temp[2] = DiceTime.GetDieValue(3);
            temp[3] = DiceTime.GetDieValue(4);
            temp[4] = DiceTime.GetDieValue(5);

            //boolean for if ThreeOfAKind is true or false
            bool isThreeOfAKind = false;

            for (int index = 1; index <= 6; index++)
            {
                int count = 0;
                for (int innerIndex = 0; innerIndex < 5; innerIndex++)
                {
                    if (temp[innerIndex] == index)
                        count++;

                    if (count > 2)
                        isThreeOfAKind = true;
                }
            }

            if (isThreeOfAKind)
            {
                for (int k = 0; k < 5; k++)
                {
                    ThreeOfAKind += temp[k];
                }
            }

            return ThreeOfAKind;
        }

        //calculate Four of a kind 
        public int CalculateFourOfAKind(Dice DiceTime)
        {
            //temporary array
            int[] temp = new int[5];
            temp[0] = DiceTime.GetDieValue(1);
            temp[1] = DiceTime.GetDieValue(2);
            temp[2] = DiceTime.GetDieValue(3);
            temp[3] = DiceTime.GetDieValue(4);
            temp[4] = DiceTime.GetDieValue(5);

            //bollean for if its Four of a kind or not
            bool isFourOfAKind = false;

            for (int index = 1; index <= 6; index++)
            {
                int count = 0;
                for (int innerIndex = 0; innerIndex < 5; innerIndex++)
                {
                    if (temp[innerIndex] == index)
                        count++;

                    if (count > 3)
                        isFourOfAKind = true;
                }
            }

            if (isFourOfAKind)
            {
                for (int k = 0; k < 5; k++)
                {
                    FourOfAKind += temp[k];
                }
            }

            return FourOfAKind;
        }
        

        //calculate Full House
        public int CalculateFullHouse(Dice DiceTime)
        {
            //int Sum = 0;

            int[] i = new int[5]; //temperary array


            i[0] = DiceTime.GetDieValue(1);
            i[1] = DiceTime.GetDieValue(2);
            i[2] = DiceTime.GetDieValue(3);
            i[3] = DiceTime.GetDieValue(4);
            i[4] = DiceTime.GetDieValue(5);

            Array.Sort(i);

            if ((((i[0] == i[1]) && (i[1] == i[2])) && // Three of a Kind
                 (i[3] == i[4]) && // Two of a Kind
                 (i[2] != i[3])) ||
                ((i[0] == i[1]) && // Two of a Kind
                 ((i[2] == i[3]) && (i[3] == i[4])) && // Three of a Kind
                 (i[1] != i[2])))
            {
                FullHouse = 25;
            }

            return FullHouse;
        }

        //calculate small straight
        public int CalculateSmallStraight(Dice DiceTime)
        {
            

            int[] index = new int[5];

            index[0] = DiceTime.GetDieValue(1);
            index[1] = DiceTime.GetDieValue(2);
            index[2] = DiceTime.GetDieValue(3);
            index[3] = DiceTime.GetDieValue(4);
            index[4] = DiceTime.GetDieValue(5);

            Array.Sort(index);

            //problems if there are doubles
            //move any doubles to the end
            for (int j = 0; j < 4; j++)
            {
                int temp = 0;
                if (index[j] == index[j + 1])
                {
                    temp = index[j];

                    for (int k = j; k < 4; k++)
                    {
                        index[k] = index[k + 1];
                    }

                    index[4] = temp;
                }
            }

            if (((index[0] == 1) && (index[1] == 2) && (index[2] == 3) && (index[3] == 4)) ||
                ((index[0] == 2) && (index[1] == 3) && (index[2] == 4) && (index[3] == 5)) ||
                ((index[0] == 3) && (index[1] == 4) && (index[2] == 5) && (index[3] == 6)) ||
                ((index[1] == 1) && (index[2] == 2) && (index[3] == 3) && (index[4] == 4)) ||
                ((index[1] == 2) && (index[2] == 3) && (index[3] == 4) && (index[4] == 5)) ||
                ((index[1] == 3) && (index[2] == 4) && (index[3] == 5) && (index[4] == 6)))
            {
                SmallStraight = 30;
            }

            return SmallStraight;
        }

        //calculate large straight
        public int CalculateLargeStraight(Dice DiceTime)
        {
            int[] i = new int[5];

            i[0] = DiceTime.GetDieValue(1);
            i[1] = DiceTime.GetDieValue(2);
            i[2] = DiceTime.GetDieValue(3);
            i[3] = DiceTime.GetDieValue(4);
            i[4] = DiceTime.GetDieValue(5);

            // Sort a section of the array using the default comparer
            Array.Sort(i);

            if (((i[0] == 1) &&
                 (i[1] == 2) &&
                 (i[2] == 3) &&
                 (i[3] == 4) &&
                 (i[4] == 5)) ||
                ((i[0] == 2) &&
                 (i[1] == 3) &&
                 (i[2] == 4) &&
                 (i[3] == 5) &&
                 (i[4] == 6)))
            {
                LargeStraight = 40;
            }

            return LargeStraight;
        }

        //calculating Yahtzee
        public int CalculateYahtzee(Dice DiceTime)
        {
            if (DiceTime.GetDieValue(1) == DiceTime.GetDieValue(2) && DiceTime.GetDieValue(2) == DiceTime.GetDieValue(3) &&
                DiceTime.GetDieValue(3) == DiceTime.GetDieValue(4) && DiceTime.GetDieValue(4) == DiceTime.GetDieValue(5))
            {
                //Yahtzee = DiceTime.GetDieValue(1) + DiceTime.GetDieValue(2) + DiceTime.GetDieValue(3) + DiceTime.GetDieValue(4) +
                       // DiceTime.GetDieValue(5);
                Yahtzee = 50;
            }

            return Yahtzee;
        }

   
        //use this for Chance when calculating lower nunmbers
        public int CalculateChance(Dice DiceTime)
        {
            Chance = Ones + Twos + Threes + Fours + Fives + Sixes;

            return Chance;
        }

        //calculate lower total
        public int CalculateLowerTotal()
        {
            LowerTotal = ThreeOfAKind + FourOfAKind + FullHouse + SmallStraight + LargeStraight + Yahtzee + Chance;

            return LowerTotal;
        }

    }
}
