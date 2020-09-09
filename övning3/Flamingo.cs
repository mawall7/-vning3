using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace övning3
{
    
    class Flamingo: Bird
    {
        private string leglenght = "longlegs";

        public string Leglength  { get; set; }
        public Flamingo (string name, int age, double weigth) : base(name, age, weigth)
        {
        
        }

        override public string Stats()
        {
            //string str = Age.ToString() + Name + Weight.ToString() + Leglength;
            string str = $"{base.Stats()} {Leglength}";
            return str;

        }


    }
}
    


