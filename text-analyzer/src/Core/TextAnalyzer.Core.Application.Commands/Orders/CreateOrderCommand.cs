﻿using Optivem.Atomiv.Core.Application;
using System;
using System.Collections.Generic;

namespace TextAnalyzer.Core.Application.Commands.Orders
{
    public class CreateOrderCommand : IRequest<CreateOrderCommandResponse>
    {
        public Guid CustomerId { get; set; }

        public List<CreateOrderItemCommand> OrderItems { get; set; }
    }

    public class CreateOrderItemCommand
    {
        public Guid ProductId { get; set; }

        public int Quantity { get; set; }
    }
}