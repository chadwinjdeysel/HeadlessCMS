using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Data
{
    public class DataRepository : IDataRepository
    {
        private readonly AppDbContext _context;

        public DataRepository(AppDbContext context)
        {
            this._context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            if (entity != null)
                _context.Remove(entity);
        }

        public void Edit<T>(T entity) where T : class
        {
            _context.Set<T>().Update(entity);
        }

        public async Task<T> Get<T>(Guid id) where T : class
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetList<T>() where T : class
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }

    }
}
