using MechanikKonsola.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MechanikKonsola
{
    public class AppDBContext : DbContext
    {
        public DbSet<Rezerwacja> Rezerwacje { get; set; }
        public DbSet<Uslugi> Uslugi { get; set; }
        public DbSet<SprzedazCzesci> Czesci{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DOM;Initial Catalog=Mechanik;Integrated Security=True;TrustServerCertificate=True;");
        }

    }
}