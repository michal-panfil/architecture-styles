using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Models
{
    public class ResourceGroup
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public int LocationId { get; set; }
        public virtual Location Location { get; set; } = new Location();
        public IEnumerable<string> Tags { get; set; } = new List<string>();
        public Guid SubscriptionId { get; set; }
        public virtual Subscription Subscription { get; set; } = new Subscription();

    }
}
