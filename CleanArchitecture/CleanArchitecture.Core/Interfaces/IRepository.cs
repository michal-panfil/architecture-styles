using CleanArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IRepository<T> where T : TEntity
    {
        Task<T> GetById(Guid id);
        Task<IEnumerable<T>> Get();
        Task Add(T entity);
        void Delete(T entity);
        Task Update(T entity);

    }
    
}
