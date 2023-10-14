using System.Linq.Expressions;
using WEB_API.Models;

namespace WEB_API.Repository.IRepository
{
    public interface IVillaRepository
    {
        Task<List<Villa>> GetAllAsync(Expression<Func<Villa,bool>> filter = null);
        Task<Villa> GetAsync(Expression<Func<Villa,bool>> filter = null, bool tracked= true);
        Task CreateAsync(Villa entity);
        Task RemoveAsync(Villa entity);
        Task SaveAsync();
    }
}
