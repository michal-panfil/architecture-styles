namespace CleanArchitecture.API.Models
{
    public class ResourceGroupDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Location { get; set; } = String.Empty;
    }
}
