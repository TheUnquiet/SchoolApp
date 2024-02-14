using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.classes
{
    internal class School
    {
        public Bibliotheek SchoolBibliotheek = new Bibliotheek();
        public List<Persoon> Personen = new List<Persoon>();
        public List<KlasLokaal> Klaslokalen = new List<KlasLokaal>();
        public Schoolbus DeSchoolbus = new Schoolbus();
    }
}
