using System;
using System.Collections.Generic;
using System.Text;

namespace Animal_Farm
{
    class Cow
    {
        private string cowSound;
        private string name;
        public Cow() //default constructor
        {
            cowSound = "Moooo";
            name = "Bessy";
        }

        public Cow(string n, string s) //regular constructor
        {
            cowSound = s;
            name = n;
        }


        public void CowSays() //method calling both variables
        {
            Console.WriteLine($"Hello, my name is {name} and I say: {cowSound}");
        }
    }
}
