using System;
using System.Collections.Generic;
using System.Text;

namespace övning3
{
    class Hedgehog:Animal
    {
        private int spinelength;
        public Hedgehog(string name, int age, double weigth) : base(name, age, weigth) 
        {

        }

        public int Spinelength
        {
            get
            {
                return spinelength;
            }
            set { spinelength = value; }
        }

        public override void DoSound()
        {
            Console.WriteLine("iii");
        }
    }
}
