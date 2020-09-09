using System;
using System.Collections.Generic;
using System.Text;

namespace övning3
{
    class Pelican : Bird
    {
        private string weirdbeek = "yes";

        public string WeirdBeek { get; private set; }
        public Pelican(string name, int age, double weigth)
          : base(name, age, weigth)
        {

        }

        override public string Stats()
        {
            //string str = Age.ToString() + Name + Weight.ToString() + weirdbeek;
            string str = $"{base.Stats()} {WeirdBeek}";

            return str;

        }
    }
}
