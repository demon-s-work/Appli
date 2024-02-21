using Appli.Dal.Context;

namespace Mapd.Server.Dao.Repositories.Abstractions
{
	public abstract class BaseRepository
	{
		protected readonly ApplicationDbContext Context;

		protected BaseRepository(ApplicationDbContext context)
		{
			Context = context;
		}

		protected async Task SaveChangesAsync()
		{
			await Context.SaveChangesAsync();
		}
	}
}