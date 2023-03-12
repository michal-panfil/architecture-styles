using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Services
{
    public class SimpleResourceCreator : IResourcesCreatable
    {
        public Task<IEnumerable<Guid>> CreateResources(IEnumerable<Resource> resources)
        {
            throw new NotImplementedException();
        }
    }
}
