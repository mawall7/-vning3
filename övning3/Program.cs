using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;


namespace övning3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bird a1 = new Bird("somebird",1.1, 10);
            //Dog a2 = new Dog("somedog", 2, 20,"fetch");
            var listanimals = new List<Animal> { };
            listanimals.Add(new Dog("fido", 5, 2, "roll over"));
            listanimals.Add(new Swan("swanen", 2, 3));
            listanimals.Add(new Wolfman("wirm", 3, 4));

            foreach (var a in listanimals)
            {
                var typeofa = a.GetType().Name;
                Console.WriteLine(typeofa);
                a.DoSound();
                Console.WriteLine(typeofa);
                /*if (typeofa == "Wolfman")
                /{
                    try { a.Talk();}
                    catch { break; }

                    
                }*/

                List<Dog> dogs = new List<Dog> {};
                Dog dog1 = new Dog("pudel", 2,3,"apport");
                Dog dog2 = new Dog("schäfer", 1, 4, "walkbeside");
                Horse h1 = new Horse("russ",2,4);
                dogs.Add(dog1);
                dogs.Add(dog2); // (h1) 
                //F. 9) Listan pekar till Dog och för att Dog bara har access till objektmedlemmar av sin egen klass och i sina överklasser dvs. basklassen Animal, men Horse är på samma nivå. 
                //F. 10) Behöver vara av typen Animal eftersom det är basklassen och överklassen till både dog och Horse.

                foreach  (var item in listanimals) //11)
                {
                    Console.WriteLine(item.Stats());
                    if(a is Dog)//if (a.GetType().Name == "Dog")
                    {
                        try
                        {
                            //Dog t = (Dog)item; // 17) går inte att skriva ut eftersom listan är ett object av klassen Animal och ej är ett Dog objekt och ett animla objekt kan inte gå nedåt till en subklass men en subklass medan subklassern kommer åt basklassens metoderkonverterar explicit Animal objektet till ett Dog objekt
                            Console.WriteLine((a as Dog).writee()); //Går också att skiva explicit Console.WriteLine(t.writee());//Console.WriteLine(t.writee());
                        }
                        catch
                        {
                            continue;
                        }
                    }
                    
                   // Console.WriteLine(item.writee());  //funkar inte
                }
                //F. 13) metoden Stats() är en metod som tillhör djurets klass och är virtuell i djurklassen men finns även i djurens subklasser och körs då med de parametrarna som angivits där istället för bara basklassens. 

                foreach (var item in dogs)
                {
                    Console.WriteLine(item.Stats());
                    
                }

            }
            //Person person1 = new Person();
            //person1.FName = "Sarah"; // finns ingen åtkomst till privata fält variabler då behöver de vara public eller hellre vara private oh använda get och set
            // person1.LName = "Nilsson";
            //person1.setAge(6);
            //person1.FName = "ct";
            //Console.WriteLine(person1.FName);
            /*try
            {
                var ps = new PersonHandler();
                var person1 = ps.CreatePerson(10, "Kalle", "Andersson", 3, 500);
                ps.Setage(person1, 10);
                
            }
            catch (Exception)
            {
                Console.WriteLine("please enter age again");
               
                
            }*/




        }
    }
}
