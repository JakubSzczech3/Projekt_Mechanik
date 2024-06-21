using MechanikKonsola.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanikKonsola.Query
{
    public class PobierzCzesciQuery
    {
        public List<SprzedazCzesci> Pobieranie()
        {
            using (var context = new AppDBContext())
            {

                return context.Czesci.ToList();

            }
        }


    }
}
