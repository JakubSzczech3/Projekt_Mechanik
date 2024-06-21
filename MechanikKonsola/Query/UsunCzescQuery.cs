using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanikKonsola.Query
{
    public class UsunCzescQuery
    {
        public int Id;
        public UsunCzescQuery(int ID) {
            Id = ID;
        }
        public void UsunCzesc() {
            using (var contex = new AppDBContext()) {
                if (contex.Czesci.Find(Id).IloscNaMagazynie > 0)
                {
                    contex.Czesci.Find(Id).IloscNaMagazynie -= 1;
                    contex.SaveChanges();
                }
                
            }
        
        }
    }
}
