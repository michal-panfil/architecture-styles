namespace CleanArchitecture.Core.Models
{
    public class ResourceType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string LongName { get; set; } = String.Empty;
    }
}
