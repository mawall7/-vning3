using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Cache;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace övning3
{
    
           
    abstract class Animal
    {
        private string name;
        private double weight;
        private int age;
        

        public Animal(string name, int age, double weigth)
        {
            Name = name;
            Weight = weight;
            Age = age;
            
            
        }

        public string Name
        {
            get
            {
            return name;
            }
            set{ name = value;}
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set { weight = value; }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set {; }
        }
        public abstract void DoSound();//cannot not be instantiated
        virtual public string Stats()
        {
            string str = Age.ToString() + " " + Name +" " + Weight.ToString(); 
            return str;
            
        }
        /*public string writee()
        {
            return "hej";
        }*/ 
       


    }
}
