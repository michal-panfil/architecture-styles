namespace CleanArchitecture.API.Models
{
    public class ResourceDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public ResourceGroupDto ResourceGroup { get; set; } = new ResourceGroupDto();
        public IEnumerable<string> Tags { get; set; } = new List<string>();
        public string ResourceType { get; set; } = string.Empty;
    }
}
