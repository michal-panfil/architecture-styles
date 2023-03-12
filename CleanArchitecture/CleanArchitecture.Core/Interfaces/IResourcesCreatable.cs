using CleanArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Interfaces
{
    public interface IResourcesCreatable
    {
        Task<IEnumerable<Guid>> CreateResources(IEnumerable<Resource> resourceGroups);
    }
}
