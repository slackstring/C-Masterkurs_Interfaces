using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Übung11_Interfaces;

namespace AufgabeModul11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface ITier
            /*
            ITier[] array = new ITier[3];
            array[0] = new Hund("Männlich",10);
            array[1] = new Katze("Weiblich", 4);
            array[2] = new Maus("Männlich", 1);
            foreach (ITier tier in array)
            {
                Console.WriteLine("Geschlecht: " + tier.Geschlecht);
                Console.WriteLine("Alter: " + tier.Alter);
                tier.Fressen();
                tier.Trinken();
                Console.WriteLine();
            }
            */

            //Interface ILogger
            Person person = new Person();
            person.Name = "Gustav";
            Console.WriteLine(person.Name);
            Console.ReadKey();
        }
    }

    class Person
    {
        private ILogger logger = new ConsoleLogger();
        //Eigenschaften
        private string name;
        public string Name
        {
            get
            {
                logger.Log("Getter von Name wurde aufgerufen!");
                return name;
            }
            set
            {
                logger.Log("Setter von Name wurde aufgerufen!");
                name = value;
            }
        }
    }
}