using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace youtube_etl_do_zero.Data
{
    public class RepositoryBase : IRepositoryBase
    {
        private readonly DefaultContext _context;

        public RepositoryBase(DefaultContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void AddRange<T>(IEnumerable<T> entities) where T : class
        {
            _context.AddRange(entities);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void UpdateRange<T>(IEnumerable<T> entities) where T : class
        {
            _context.UpdateRange(entities);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public void DeleteRange<T>(IEnumerable<T> entities) where T : class
        {
            _context.RemoveRange(entities);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}