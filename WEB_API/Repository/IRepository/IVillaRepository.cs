using System.Linq.Expressions;
using WEB_API.Models;

namespace WEB_API.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}
