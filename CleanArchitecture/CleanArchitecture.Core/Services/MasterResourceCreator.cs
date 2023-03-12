using CleanArchitecture.Core.Interfaces;
using CleanArchitecture.Core.Models;

namespace CleanArchitecture.Core.Services
{
    public class MasterResourceCreator : IResourcesCreatable
    {
        public Task<IEnumerable<Guid>> CreateResources(IEnumerable<Resource> resources)
        {
            throw new NotImplementedException();
        }
    }
}
