namespace AnimalKingdom
{
    public class Dog : Animal, IMammal
    {
        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
        int IMammal.NumberOfNipples
        {
            get { return 8; }
        }
    }
}
