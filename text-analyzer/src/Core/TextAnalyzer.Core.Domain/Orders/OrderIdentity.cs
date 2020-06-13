﻿using Optivem.Atomiv.Core.Domain;
using System;

namespace TextAnalyzer.Core.Domain.Orders
{
    public class OrderIdentity : Identity<Guid>
    {
        public OrderIdentity(Guid value) : base(value)
        {
        }
    }
}