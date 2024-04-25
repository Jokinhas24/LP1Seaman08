using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Bee : Animal, ICanFly
    {
        public override string Sound()
        {
            return base.Sound() + "Bzz";
        }
        int ICanFly.NumberOfWings
        {
            get { return 4; }
        }
    }
}