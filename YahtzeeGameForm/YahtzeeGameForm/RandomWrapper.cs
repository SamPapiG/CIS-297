using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//from Eric Charnesky https://github.com/EricCharnesky/CIS297-Winter2019/tree/master/Yahtzee/Yahtzee
namespace YahtzeeGameForm
{
    public class RandomWrapper : IRandom
    {
        private Random random;

        public RandomWrapper()
        {
            random = new Random();
        }

        public int Next(int startingAtThisMin, int upToButNotIncludingThisMax)
        {
            return random.Next(startingAtThisMin, upToButNotIncludingThisMax);
        }
    }
}