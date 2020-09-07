using System;
using System.Collections.Generic;
using System.Text;

namespace övning3
{
    class Horse:Animal
    {
        private string coloring;
        public Horse(string name, int age, double weight) : base(name, age, weight) 
        {

        }

    public string Coloring
    {
        get
        {
            return coloring;
        }
        set { coloring = value; }
    }
        public override void DoSound()
        {
            Console.WriteLine("wooooo");
        }


    }
}
