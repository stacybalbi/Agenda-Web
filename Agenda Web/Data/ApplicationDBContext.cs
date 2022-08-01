using Agenda_Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda_Web.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
            //:base(options) se utiliza para las migraciones de la bd 


        }

        //Instanciar los modelos
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Teléfono> Teléfono { get; set; }
        public DbSet<Email> Email { get; set; }

        //Hay que agregar todos los modelos porque si no se crea una migración vacia y no se guardara nada en la bd
    }
}
