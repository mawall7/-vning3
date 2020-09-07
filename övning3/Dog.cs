using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace övning3
{
    class Dog : Animal
    {
        private string trick;
        public Dog(string name, int age, double weigth, string trick) : base(name, age, weigth)
        {
            trick = Trick;
        }

        public string Trick { set; get; }

        public override void DoSound()
        {
            Console.WriteLine("voff");
        }

        override public string Stats()
        {
            string str = Age.ToString() + Name + Weight.ToString() + trick;
            return str;

        }

        public string writee()
        {
            return " det är underbart det här/ write metod från dogs";
            
        }


    }

    
}
