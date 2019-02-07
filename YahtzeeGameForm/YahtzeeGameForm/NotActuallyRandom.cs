using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YahtzeeGameForm;

//from Eric Charnesky https://github.com/EricCharnesky/CIS297-Winter2019/tree/master/Yahtzee/Yahtzee
namespace YahtzeeGameForm.Tests
{
    public class NotActuallyRandom : IRandom
    {
        List<int> notRandomNumbers;
        int currentIndex;
        public NotActuallyRandom(List<int> notRandomNumbers)
        {
            this.notRandomNumbers = notRandomNumbers;
            currentIndex = 0;
        }

        public int Next(int startingAtThisMin, int upToButNotIncludingThisMax)
        {
            int valueToReturn = notRandomNumbers[currentIndex];
            currentIndex++;
            return valueToReturn;
        }
    }
}