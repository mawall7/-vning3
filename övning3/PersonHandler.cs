using System;
using System.Collections.Generic;
using System.Text;

namespace övning3
{
    class PersonHandler
    {
       

        //public Person ​CreatePerson​(int age, string fname, string lname, double height​, double weight​)
        //{
        //    var person = new Person(age, fname, lname, height, weight);
        //    return person;
        //}

        public Person CreatePerson(int age, string fname, string lname, double height, double weight) //Person anger att typen är klass Person som gör att man i klassen Pers Handl kan använda klass metoden från Person
        {
            var person = new Person(age, fname, lname, height, weight);
            return person;
        }


        public void Setage(Person pers, int age)
        {

            pers.Age = age;
            // don mix this with self keyword in python
        }

        public void Setfname(Person pers,string name) 
        {
            pers.FName = name;
        }

        public void Setlname(Person pers,string lname) 
        {
            pers.LName = lname;
        }

        public void Setheight(Person pers, int height)
        {
            pers.Height = height;

        }

        public void Setweight(Person pers, int weight)
        {
            pers.Height = weight;

        }

        public Person Getperson(Person pers)
        {
            return pers;

        }
    }
}
