using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Data
{
    public interface IDataRepository
    {
        void Add<T>(T entity) where T : class;
        void Edit<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<T> Get<T>(Guid id) where T : class;
        Task<IEnumerable<T>> GetList<T>() where T : class;

        Task<bool> SaveAll();
    }
}
