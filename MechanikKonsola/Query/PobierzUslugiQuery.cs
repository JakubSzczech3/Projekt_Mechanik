using MechanikKonsola.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanikKonsola.Query
{
    public class PobierzUslugiQuery {
        public List<Uslugi> Pobieranie() {
            using (var context = new AppDBContext()) {

                return context.Uslugi.ToList();

            }
        }

    }



}
