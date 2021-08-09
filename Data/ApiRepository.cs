using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiCrud.Models;

namespace WebApiCrud.Data
{
    public class ApiRepository<TEntity> : IApiRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly DataContext _dbctx;
        public ApiRepository(DataContext dbctx)
        {
            _dbctx = dbctx;
        }
        public async Task Delete(TEntity entity)
        {
            _dbctx.Set<TEntity>().Remove(entity);
            await _dbctx.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _dbctx.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _dbctx.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Insert(TEntity entity)
        {
            _dbctx.Set<TEntity>().Add(entity);
            await _dbctx.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _dbctx.Set<TEntity>().Update(entity);
            await _dbctx.SaveChangesAsync();
        }
    }
}
