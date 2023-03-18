﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Models
{
    public class ServiceProperty : TEntity
    {
        public string Type { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}
