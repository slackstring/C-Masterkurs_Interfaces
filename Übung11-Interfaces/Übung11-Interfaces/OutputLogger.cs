using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Übung11_Interfaces
{
    internal class OutputLogger : ILogger
    {
        public void Log(string message)
        {
           Debug.WriteLine(message);
        }
    }
}
