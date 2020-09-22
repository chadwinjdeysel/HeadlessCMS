using ContentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Data
{
    public interface ICMSRepository
    {
        public Task<IEnumerable<Field>> GetFieldsForModel(Guid id);

        public Task<IEnumerable<Content>> GetContentForModel(Guid id);

        public Task<int> GetIndex(Guid id);
    }
}
