using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlayerManager4;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        public CompareByName(Boolean Alphabetic)
        {}
        IComparer<Player> playerToCompare = new CompareByName();
        playersToList.Sort(playerToCompare);
    }
}