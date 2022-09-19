using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung11_Interfaces
{
    public class Katze : ITier
    {
        //Eigenschaften
        public string Geschlecht { get; set; }
        public int Alter { get; set; }

        //Konstruktor
        public Katze(string geschlecht, int alter)
        {
            Geschlecht = geschlecht;
            Alter = alter;
        }
        //Methoden
        public void Fressen()
        {
            Console.WriteLine("Die Katze frisst!");
        }
        public void Trinken()
        {
            Console.WriteLine("Die Katze trinkt!");
        }

    }
}
