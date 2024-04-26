using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PlayerManager4;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool _alphabetic;
        public CompareByName(Boolean alphabetic)
        {
            _alphabetic = alphabetic;
        }

        public static CompareByName AscendingByName { get { return new CompareByName(true); } }
        public static CompareByName DescendingByName { get { return new CompareByName(false); } }
        public static CompareByName DescendingByScore { get { return new CompareByName(false); } }
        public int Compare(Player player1, Player player2)
        {
            if (_alphabetic)
            {
                return string.Compare(player1.Name, player2.Name, StringComparison.Ordinal);
            }
            else
            {
                return string.Compare(player2.Name, player1.Name, StringComparison.Ordinal);
            }
        }
    }
}