using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Bat : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "KiKi";
        }
        public readonly int NumberOfNipples
        {
            get { return 4; }
        }
    }
}