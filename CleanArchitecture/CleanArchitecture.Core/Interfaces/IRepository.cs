using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<T> GetById(Guid id);
        Task<IQueryable<T>> Get();
        Task<T> Add(T entity);
        Task Delete(T entity);
        Task Update(T entity);

    }
    
}
