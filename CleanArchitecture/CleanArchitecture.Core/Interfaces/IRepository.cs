using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IRepository
    {
        Task<T> GetById(Guid id);
        Task<T> GetById(Predignat p);
    }
}
