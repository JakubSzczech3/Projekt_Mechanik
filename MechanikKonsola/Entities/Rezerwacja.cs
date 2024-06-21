using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanikKonsola.Entities
{
    public class Rezerwacja
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime Data { get; set; }
        public int NrTelefonu { get; set; }

        public Rezerwacja(string imie, string nazwisko, DateTime data, int nrTelefonu)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Data = data;
            NrTelefonu = nrTelefonu;
        }

    }
}
