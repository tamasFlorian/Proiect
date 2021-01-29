using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    class Medicament
    {
        private String denumire;

        private string substanta;

        public Medicament(String a, String b)
        {
            denumire = a;
            substanta = b;
        }

        public String getDenumire()
        {
            return denumire;
        }

        public void setDenumire(String denumire)
        {
            this.denumire = denumire;
        }
    }
}
