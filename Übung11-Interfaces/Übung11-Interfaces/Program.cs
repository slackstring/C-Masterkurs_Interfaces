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


            Console.ReadKey();
        }
    }
}