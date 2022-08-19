using Booker.Application.Customers.Models;
using Booker.Domain;
using Booker.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Application.Queries
{
    public class GetAllCustomersQuery : IRequest<IQueryable<CustomerDto>>
    {
    }

    public class GetAllCustomersQueryHandler : IRequestHandler<GetAllCustomersQuery, IQueryable<CustomerDto>>
    {
        private readonly BookerDbContext _dbContext;

        public GetAllCustomersQueryHandler(BookerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<IQueryable<CustomerDto>> Handle(GetAllCustomersQuery request, CancellationToken cancellationToken)
        {
            List<Customer> customers = _dbContext.Customers.ToList();
            List<CustomerDto> customerDto = new List<CustomerDto>();

            foreach( var cust in customers)
            {
                customerDto.Add(new CustomerDto() { ID = cust.ID, Name = cust.Name, Contact = cust.Contact });
            }
            
            return Task.FromResult(customerDto.AsQueryable());
        }
    
    }
}
