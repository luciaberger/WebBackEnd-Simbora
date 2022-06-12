using Microsoft.EntityFrameworkCore;

namespace WebBackEnd_Simbora.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }

        public DbSet<Evento> Eventos { get; set; }

        public DbSet<Comentarios> Comentario { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
