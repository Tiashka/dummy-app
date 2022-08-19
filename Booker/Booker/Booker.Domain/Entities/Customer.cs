using System;
using System.Collections.Generic;

namespace Booker.Domain.Entities
{
    public class Customer
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public long Contact { get; set; }
    }
}