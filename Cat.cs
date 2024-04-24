﻿namespace AnimalKingdom
{
    public class Cat : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
        public readonly int NumberOfNipples
        {
            get { return 6; }
        }
    }
}
