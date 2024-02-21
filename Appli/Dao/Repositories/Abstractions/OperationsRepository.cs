using Appli.Dal.Context;
using Appli.Dal.Entities.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Mapd.Server.Dao.Repositories.Abstractions
{
	public abstract class OperationsRepository<TEntity> : BaseRepository where TEntity : BaseEntity
	{
		private readonly DbSet<TEntity> _dbSet;

		protected OperationsRepository(ApplicationDbContext context) : base(context)
		{
			_dbSet = Context.Set<TEntity>();
		}

		public IQueryable<TEntity> GetAll => _dbSet.AsQueryable();

		public async Task<TEntity?> GetAsync(params object?[]? keyValues)
		{
			return await _dbSet.FindAsync(keyValues);
		}

		public async Task InsertAsync(TEntity entity)
		{
			await _dbSet.AddAsync(entity);
			await SaveChangesAsync();
		}

		public async Task Update(TEntity entity)
		{
			_dbSet.Attach(entity);
			Context.Entry(entity).State = EntityState.Modified;
			await SaveChangesAsync();
		}

		public async Task Delete(TEntity entity)
		{
			if (Context.Entry(entity).State == EntityState.Detached)
			{
				_dbSet.Attach(entity);
			}

			_dbSet.Remove(entity);
			await SaveChangesAsync();
		}
	}
}