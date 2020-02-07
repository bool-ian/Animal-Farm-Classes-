using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Farm
{
    class Pig
    {

        private string pigSound;
        private string name;
        public Pig() //default constructor
        {
            pigSound = "oink";
            name = "Chis P. Bacon";
        }

        public Pig(string n, string s) 
        {
            pigSound = s;
            name = n;
        }


        public void PigSays()
        {
            Console.WriteLine($"Hello, my name is {name} and I say: {pigSound}");
        }
    }
}
