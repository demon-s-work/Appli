using Appli.Dal.Context;
using Appli.Dal.Entities;
using Mapd.Server.Dao.Repositories.Abstractions;

namespace Mapd.Server.Dao.Repositories
{
	public class NoteRepository : OperationsRepository<Note>
	{
		public NoteRepository(ApplicationDbContext context) : base(context)
		{
		}
	}
}