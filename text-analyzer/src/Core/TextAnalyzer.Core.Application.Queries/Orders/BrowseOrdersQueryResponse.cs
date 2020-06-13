﻿using TextAnalyzer.Core.Common.Orders;
using System;
using System.Collections.Generic;

namespace TextAnalyzer.Core.Application.Queries.Orders
{
    public class BrowseOrdersQueryResponse
    {
        public List<BrowseOrdersRecordQueryResponse> Records { get; set; }

        public long TotalRecords { get; set; }
    }

    public class BrowseOrdersRecordQueryResponse
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public DateTime OrderDate { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public decimal TotalPrice { get; set; }
    }
}