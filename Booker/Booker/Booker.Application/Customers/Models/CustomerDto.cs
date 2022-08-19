using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Application.Customers.Models
{
    public class CustomerDto
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public long Contact { get; set; }
    }
}
