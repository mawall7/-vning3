using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Dynamic;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace övning3
{
    interface IPerson
    {
        void Talk();
    }
    class Person
    {
        private string fName; //private
        private string lName; 
        private int age;
        private double height;
        private double weight;
       public Person(int age, string fname, string lname, double height​, double weight)
        {
            Age = age;
            FName = fname;
            LName = lname;
            Height = height;
            Weight = weight;
            
        }
       
        public string FName
        {
            get { return fName; }
            set
            {
                if (this.fName.Length >= 2 || this.fName.Length <= 10)
                { fName = value; }
                

            }
        }
        //property
        public string LName
        {
            get { return lName; }
            set { lName = value; }
        }
        public int Age
        {
            get { return age; }

            set { if (value > 0)
                {
                    age = value;
                }
                else {
                    throw new ArgumentException("age has to be larger than 0") ; //age = 10000; // varför fungerar det inte med noll? sätts till noll om man inte säger något
                }
        }
                
                

        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        
    
    }
        
}
