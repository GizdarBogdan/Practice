using Microsoft.EntityFrameworkCore;

namespace MyProject.Data
{
	public class MyEventDbContext : DbContext
	{
		public DbSet<Event> Events { get; set; }	
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyDbEvents;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(p => p.PhotoBytes)
                .HasColumnName("Photo");
        }
    }
}
