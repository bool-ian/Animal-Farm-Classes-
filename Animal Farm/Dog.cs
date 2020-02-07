using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Farm
{
    class Dog
    {
        private string dogSound;
        private string name;
        public Dog() //default constructor
        {
            dogSound = "Bark";
            name = "Murphy";
        }

        public Dog(string n, string s)
        {
            dogSound = s;
            name = n;
        }


        public void DogSays()
        {
            Console.WriteLine($"Hello, my name is {name} and I say: {dogSound}");
        }
    }
}
