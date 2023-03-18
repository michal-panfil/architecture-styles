namespace CleanArchitecture.Core.Models
{
    public class ResourceType : TEntity
    {
        public string Name { get; set; } = String.Empty;
        public string LongName { get; set; } = String.Empty;
    }
}
