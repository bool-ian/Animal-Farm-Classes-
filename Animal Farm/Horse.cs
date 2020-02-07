using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Farm
{
    class Horse
    {
        private string horseSound;
        private string name;
        public Horse() //default constructor
        {
            horseSound = "Neigh!!";
            name = "Mr. Ed";
        }

        public Horse(string n, string s) //regular constructor
        {
            horseSound = s;
            name = n;
        }


        public void HorseSays() //method calling both variables
        {
            Console.WriteLine($"Hello, my name is {name} and I say: {horseSound}");
        }
    }
}
