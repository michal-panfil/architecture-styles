namespace CleanArchitecture.Core.Models
{
    public class Subscription
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid TenantId { get; set; }
        public Tenant Tenant { get; set; }  
        public string DisplayName { get; set; }
    }
}
