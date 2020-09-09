using System;
using System.Collections.Generic;
using System.Text;

namespace övning3
{
    class Wolf : Animal
    {
        private string ranginpack;
        public Wolf(string name, int age, double weigth) :base(name, age, weigth) // wolf is inherited meaning the animal constructor methid is run simultaneously that needs arguments provided with base keyword!
        {
          
        }
        public override void DoSound()
        {
            Console.WriteLine("wooooo");
        }

        public string Ranginpack { get; set; }

        override public string Stats()
        {
            //string str = Age.ToString() + Name + Weight.ToString() + ranginpack;
            string str = $"{base.Stats()} {Ranginpack}";
            return str;

        }
    }
}
