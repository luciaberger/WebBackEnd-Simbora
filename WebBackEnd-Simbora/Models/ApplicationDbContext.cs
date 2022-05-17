using Microsoft.EntityFrameworkCore;

namespace WebBackEnd_Simbora.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
        }

		public DbSet<Eventos> Eventos { get; set; }
	}
}
