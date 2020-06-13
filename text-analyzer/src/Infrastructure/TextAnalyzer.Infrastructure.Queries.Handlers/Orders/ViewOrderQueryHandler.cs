﻿using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Optivem.Atomiv.Core.Application;
using TextAnalyzer.Core.Application.Queries.Orders;
using TextAnalyzer.Infrastructure.Persistence.Common;
using TextAnalyzer.Infrastructure.Persistence.Records;

namespace TextAnalyzer.Infrastructure.Queries.Handlers.Orders
{
    public class ViewOrderQueryHandler : QueryHandler<ViewOrderQuery, ViewOrderQueryResponse>
    {
        public ViewOrderQueryHandler(DatabaseContext context) : base(context)
        {
        }

        public override async Task<ViewOrderQueryResponse> HandleAsync(ViewOrderQuery request)
        {
            var orderId = request.Id;

            var orderRecord = await Context.Orders.AsNoTracking()
                .Include(e => e.OrderItems)
                .FirstOrDefaultAsync(e => e.Id == orderId);

            if (orderRecord == null)
            {
                throw new ExistenceException();
            }

            return GetOrder(orderRecord);
        }

        private ViewOrderQueryResponse GetOrder(OrderRecord record)
        {
            var orderItems = record.OrderItems
                .Select(GetFindOrderItemQueryResponse)
                .ToList();

            return new ViewOrderQueryResponse
            {
                Id = record.Id,
                CustomerId = record.CustomerId,
                Status = record.OrderStatusId,
                OrderItems = orderItems,
            };
        }

        private FindOrderItemQueryResponse GetFindOrderItemQueryResponse(OrderItemRecord orderItemRecord)
        {
            return new FindOrderItemQueryResponse
            {
                Id = orderItemRecord.Id,
                ProductId = orderItemRecord.ProductId,
                Quantity = orderItemRecord.Quantity,
                UnitPrice = orderItemRecord.UnitPrice,
                Status = orderItemRecord.StatusId,
            };
        }
    }
}