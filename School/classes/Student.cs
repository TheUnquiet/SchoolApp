using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.classes
{
    internal class Student : Persoon
    {

        public Student(string naam) : base(naam)
        {
        }

        public void StelUVoor()
        {
            Console.WriteLine("Hallo, ik ben een student");
        }

        public void Lesvolgen()
        {
            Console.WriteLine("Ik ben les aan het volgen.");
        }
    }
}
