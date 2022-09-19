using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Übung11_Interfaces
{
    interface ITier
    {
        //Eigenschaften
        string Geschlecht { get; set; }
        int Alter { get; set; }

        //Methoden
        void Fressen();
        void Trinken();

    }
}
