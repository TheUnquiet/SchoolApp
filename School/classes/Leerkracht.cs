using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.classes
{
    internal class Leerkracht : Persoon
    {
        public Leerkracht(string naam) : base(naam)
        {
        }

        public void StelUVoor()
        {
            Console.WriteLine("Hallo ik geef les.");

        }

        public void Lesgeven()
        {
            Console.WriteLine("Ik ben les aan het geven.");
        }
    }
}