namespace CleanArchitecture.Core.Models
{
    public class Resource
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public Guid ResourceGroupId { get; set; }
        public virtual ResourceGroup ResourceGroup { get; set; } = new ResourceGroup();
        public IEnumerable<string> Tags { get; set; } = new List<string>();
        public Guid ResourceTypeId { get; set; }
        public virtual ResourceType ResourceType { get; set; } = new ResourceType();
    }
}
