using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Models.Advisors
{
    public class ServiceAdvice
    {
        public decimal Confidence { get; private set; }
        public ResourceType? RecomendedService { get; private set; }
    }
}
