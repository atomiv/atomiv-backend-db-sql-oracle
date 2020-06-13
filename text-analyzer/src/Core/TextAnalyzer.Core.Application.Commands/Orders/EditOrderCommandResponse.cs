﻿using TextAnalyzer.Core.Common.Orders;
using System;
using System.Collections.Generic;

namespace TextAnalyzer.Core.Application.Commands.Orders
{
    public class EditOrderCommandResponse
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public OrderStatus Status { get; set; }

        public List<UpdateOrderItemCommandResponse> OrderItems { get; set; }
    }

    public class UpdateOrderItemCommandResponse
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public decimal Quantity { get; set; }

        public OrderItemStatus Status { get; set; }
    }
}