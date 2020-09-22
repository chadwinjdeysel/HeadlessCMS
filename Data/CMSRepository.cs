using ContentManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContentManagementSystem.Data
{
    public class CMSRepository : ICMSRepository
    {
        private readonly AppDbContext _context;

        public CMSRepository(AppDbContext context)
        {
            this._context = context;
        }

        public async Task<IEnumerable<Content>> GetContentForModel(Guid id)
        {
            return await _context.Contents.Where(x => x.ModelId == id).Include(x => x.Field).ToListAsync();
        }

        public async Task<IEnumerable<Field>> GetFieldsForModel(Guid id)
        {
            return await _context.Fields.Where(x => x.ModelId == id).Include(x => x.Model).ToListAsync();
        }

        public async Task<int> GetIndex(Guid id)
        {
            IEnumerable<Content> contents = await _context.Contents.Where(x => x.ModelId == id).ToListAsync();

            if (contents.Count() < 1)
                return 0;


            int index = contents.Select(x => x.Index).Max();

            return index;
        }
    }
}
