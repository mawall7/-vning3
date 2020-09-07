using System;
using System.Collections.Generic;
using System.Text;

namespace övning3
{
    class Worm: Animal
    {
        private int numberofscales;
        public Worm(string name, int age, double weigth) : base(name,age, weigth) 
        {

        }
        public int Numberofsscales 
        { 
            get
            {
                return numberofscales;
            }
            set { numberofscales = value; }
        }
        public override void DoSound()
        {
            Console.WriteLine("tsss");

        }

        override public string Stats()
        {
            string str = Age.ToString() + Name + Weight.ToString() + numberofscales;
            return str;

        }

    }

}
