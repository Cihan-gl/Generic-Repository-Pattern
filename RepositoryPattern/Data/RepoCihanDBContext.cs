using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Model;

namespace RepositoryPattern.Data
{
    public class RepoCihanDBContext : DbContext
    {
        public RepoCihanDBContext(DbContextOptions<RepoCihanDBContext> options) : base(options) { }

        public DbSet<Personel> Personeller { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>().HasData(
                 new Personel { Id = Guid.NewGuid(), AdıveİkinciAdı = "Cihan", Soyadı = "Güler", Telefon = "05335187892", Eposta = "Cihancik@gmail.com" }
            );


        }


    }
}
