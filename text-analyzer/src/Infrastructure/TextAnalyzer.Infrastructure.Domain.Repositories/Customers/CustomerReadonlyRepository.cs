﻿using Microsoft.EntityFrameworkCore;
using TextAnalyzer.Core.Domain.Customers;
using TextAnalyzer.Infrastructure.Persistence.Common;
using System;
using System.Threading.Tasks;

namespace TextAnalyzer.Infrastructure.Domain.Repositories.Customers
{
    public class CustomerReadonlyRepository : Repository, ICustomerReadonlyRepository
    {
        public CustomerReadonlyRepository(DatabaseContext context) : base(context)
        {
        }

        public Task<bool> ExistsAsync(Guid customerId)
        {
            return Context.Customers.AsNoTracking()
                .AnyAsync(e => e.Id == customerId);
        }

        public Task<long> CountAsync()
        {
            return Context.Customers.LongCountAsync();
        }
    }
}