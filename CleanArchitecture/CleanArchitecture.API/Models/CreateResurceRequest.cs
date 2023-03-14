namespace CleanArchitecture.API.Models
{
    public class CreateResurceRequest
    {
        public string Name { get; set; }
        public Guid ResourceGroupId { get; set; }
        public Guid ResourceTypeId { get; set; }
        public IEnumerable<string> Tags { get; set; }
        public Guid CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
