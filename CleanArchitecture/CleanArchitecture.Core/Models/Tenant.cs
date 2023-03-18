namespace CleanArchitecture.Core.Models
{
    public class Tenant : TEntity
    {
        public string Name { get; set; }
        public string TenantId { get; set; }
    }
}
