using MechanikKonsola.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanikKonsola.Comands
{
    public class DodajRezerwacjeHandler
    {
        public DodajRezerwacjeKomenda command;

        public DodajRezerwacjeHandler(DodajRezerwacjeKomenda command)
        {
            this.command = command;
        }
        public bool Handle() {
            using (var context = new AppDBContext())
            {
                
                int dlugoscListy = context.Rezerwacje.Where(r => r.Data == command.Data).ToList().Count;

                if (dlugoscListy >= 4) { return false; }
                Rezerwacja rezerwacja = new Rezerwacja(command.Imie, command.Nazwisko, command.Data, command.NrTelefonu);
                context.Rezerwacje.Add(rezerwacja);
                context.SaveChanges();
                return true;
            }
        }  
    }
}
