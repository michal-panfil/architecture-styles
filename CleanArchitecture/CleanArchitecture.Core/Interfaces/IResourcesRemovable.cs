namespace CleanArchitecture.Core.Interfaces
{
    public interface IResourcesRemovable
    {
        Task RemoveResources(IEnumerable<Guid> resourceIds);
    }
}
