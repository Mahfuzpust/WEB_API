using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WEB_API.Data;
using WEB_API.Models;
using WEB_API.Repository.IRepository;

namespace WEB_API.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;
        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public async Task<Villa> UpdateAsync(Villa entity)
        {
            _db.Villas.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        
    }
}
