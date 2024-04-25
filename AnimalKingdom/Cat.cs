namespace AnimalKingdom
{
    public class Cat : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
        int IMammal.NumberOfNipples
        {
            get { return 6; }
        }
    }
}
