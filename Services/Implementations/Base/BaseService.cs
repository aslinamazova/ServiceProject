using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Service.DAL;
using Service.Models.Common;
using Service.Services.Interfaces.BaseService;

namespace Service.Services.Implementations.Base
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _context;
        private DbSet<T> _dbSet;
        public BaseService(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<ICollection<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public T GetById(int id)
        {
            T entity=_dbSet.Find(id);
            if (entity== null)
            {
                throw new NullReferenceException();
            }
            return entity;

        }

        //public T Update(T entity)
        //{
        //  return _dbSet.Update(entity);
           
        //}
    }
}
