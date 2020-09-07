using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace övning3
{
    class Wolfman: Wolf, IPerson
    {

        public Wolfman(string name, int age, int weigth) : base(name, age, weigth)
        {
        
        }

        public void Talk() => Console.WriteLine("I talk");


        override public string Stats()
        {
            string str = Age.ToString() + Name + Weight.ToString();
            return str;

        }
    }
}
//F 13) svar: vi bör lägga det i Birds
//F 14 svar:  I animals