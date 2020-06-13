﻿using TextAnalyzer.Core.Common.Orders;
using System;

namespace TextAnalyzer.Core.Application.Commands.Orders
{
    public class SubmitOrderCommandResponse
    {
        public Guid Id { get; set; }

        public OrderStatus Status { get; set; }
    }
}
