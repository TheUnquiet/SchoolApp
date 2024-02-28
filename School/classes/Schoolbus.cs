using SchoolApp.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.classes
{
    internal class Schoolbus : ISchoolbus
    {
        public string Remmen()
        {
            return "De schoolbus remt";
        }

        public string Rijden()
        {
            return "De schoolbus rijdt";
        }
    }
}
