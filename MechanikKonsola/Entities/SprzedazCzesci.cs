using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanikKonsola.Entities
{
    public class SprzedazCzesci
    {
        public int Id {get; set;}
        public string NazwaCzesci { get; set;}
        public int IloscNaMagazynie { get; set;}
        public int Cena { get; set; }

        public SprzedazCzesci(string nazwaCzesci, int iloscNaMagazynie, int cena)
        {
            NazwaCzesci = nazwaCzesci;
            IloscNaMagazynie = iloscNaMagazynie;
            Cena = cena;
        }
    }
}
