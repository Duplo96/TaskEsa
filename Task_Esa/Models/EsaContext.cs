using Microsoft.EntityFrameworkCore;

namespace Task_Esa.Models
{
    public class EsaContext : DbContext
    {

        public EsaContext(DbContextOptions<EsaContext> options) : base(options) { }

        public DbSet<OggettoCeleste> OggettiCelesti { get; set; }
        public DbSet<Sistema> Sistemi { get; set; }
        public DbSet<Oggetto_Sistema> Oggettos_Sistemas { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Oggetto_Sistema>().HasKey(s => new { s.SistemaRIF,s.OggettoCelesteRIF});

            modelBuilder.Entity<Oggetto_Sistema>().HasOne(os => os.ogg).WithMany(s => s.ElencoOggSis).HasForeignKey(os => os.OggettoCelesteRIF);

            modelBuilder.Entity<Oggetto_Sistema>().HasOne(os => os.sis).WithMany(s => s.ElencoOggSis).HasForeignKey(os => os.SistemaRIF);
        }
    }
}
