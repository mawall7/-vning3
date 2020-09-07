using System;
using System.Collections.Generic;
using System.Text;

namespace övning3
{
    class Bird : Animal
    {
        private string beektype; 
        public Bird(string name, int age, double weigth):base(name, age, weigth) 
        {
            
        }
        

        public override void DoSound()
        {
            Console.WriteLine("tjitjit"); 
        }
        public string Beektype { get; set; }

        override public string Stats()
        {
            string str = Age.ToString() + Name + Weight.ToString() + beektype;
            return str;

        }

    }
}