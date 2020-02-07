using System;

namespace Animal_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Pig p = new Pig();
            p.PigSays();
            Pig p2 = new Pig("Babe", "OINK OINK");
            p2.PigSays();

            Dog d = new Dog();
            d.DogSays();

            Horse h = new Horse();
            h.HorseSays();

            Cow c = new Cow();
            c.CowSays();

        }


    }
}
