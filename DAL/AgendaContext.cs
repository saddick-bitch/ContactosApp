using System.Data.Entity;
using EL;

namespace DAL
{
    public class AgendaContext : DbContext
    {
        public AgendaContext() : base("AgendaDB") // El nombre de tu cadena en App.config
        {
        }

        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<TipoContacto> TipoContactos { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<ContactoEtiqueta> ContactoEtiquetas { get; set; }
        public DbSet<Pais> Paises { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ContactoEtiqueta>()
                .HasKey(ce => new { ce.ContactoId, ce.EtiquetaId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
