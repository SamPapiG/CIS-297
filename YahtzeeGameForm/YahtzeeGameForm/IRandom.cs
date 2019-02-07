using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//from Eric Charnesky https://github.com/EricCharnesky/CIS297-Winter2019/tree/master/Yahtzee/Yahtzee
namespace YahtzeeGameForm
{
    public interface IRandom
    {
        int Next(int startingAtThisMin, int upToButNotIncludingThisMax);
    }
}
