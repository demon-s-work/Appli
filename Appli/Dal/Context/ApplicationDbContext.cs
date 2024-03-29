using Appli.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace Appli.Dal.Context
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext() : base()
		{
			Database.EnsureCreated();
		}
		
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			Database.EnsureCreated();
		}
		
		public DbSet<Note> Notes { get; set; }
	}
}