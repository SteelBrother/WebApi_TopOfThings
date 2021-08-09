using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiCrud.Models;

namespace WebApiCrud.Data
{
    public interface IApiRepository<TEntity> where TEntity : class, IEntity
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Insert(TEntity entity);
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}