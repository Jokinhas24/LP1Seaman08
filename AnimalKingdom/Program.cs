using System;
using Random

namespace AnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            array string Animals = new array();

            for (int i = 0; i < 10; i++)
            {
                Animals.add(random.Next(Cat; Dog; Bat; Bee))
            }
            foreach (animal in Animals)
            {
                Console.WriteLine(animal)
                Console.WriteLine($"This animal sounds like {animal.Sound()}")

                if animal in IMammal
                {
                    Console.WriteLine($"This animal has {animal.Get.NumberOfNipples()} nipples.")
                }
                if animal in ICanFly
                {
                    Console.WriteLine($"This animal has {animal.Get.NumberOfWings()} wings.")
                }
            }
        }
    }
}
