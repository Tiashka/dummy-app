using System;
using System.Collections.Generic;

namespace Booker.Domain.Entities
{
    public class Movie
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool isRented { get; set; }
        public Guid? CustomerID { get; set; }
        // assigned virtual so its lazy loaded by EFCore
        public virtual Customer? Rentee { get; set; }
    }
}