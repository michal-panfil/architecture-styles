using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Services
{
    public class GenericRepository<T> : IRepository<T> where T : TEntity
    {
        private DbSet<T> table = null ;
        public async Task Add(T entity)
        {
            await this.table.AddAsync(entity);
        }

        public void Delete(T entity)
        {
             this.table.Remove(entity);
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await this.table.ToListAsync();
        }

        public async Task<T> GetById(Guid id)
        {
            return await this.table.FirstOrDefaultAsync(t => t.Id == id);
        }

        public void Update(T entity)
        {
            this.table.Update(entity);
        }
    }
}
