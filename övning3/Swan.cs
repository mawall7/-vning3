using System;
using System.Collections.Generic;
using System.Text;

namespace övning3
{ 
     class Swan:Bird
    {
        private int orangecolor = 1;
        public int Orangecolor { get; set; }
        public Swan(string name, int age, double weigth)
           : base(name, age, weigth)
        {

        }

        override public string Stats()
        {
            string str = Age.ToString() + Name + Weight.ToString() + orangecolor;
            return str;

        }
    }
}
