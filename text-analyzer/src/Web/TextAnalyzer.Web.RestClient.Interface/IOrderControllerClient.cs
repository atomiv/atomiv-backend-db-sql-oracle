﻿using Optivem.Atomiv.Core.Common.Http;
using TextAnalyzer.Core.Application.Commands.Orders;
using TextAnalyzer.Core.Application.Queries.Orders;
using System.Threading.Tasks;

namespace TextAnalyzer.Web.RestClient.Interface
{
    public interface IOrderControllerClient : IHttpControllerClient
    {
        #region Commands

        Task<ObjectClientResponse<ArchiveOrderCommandResponse>> ArchiveOrderAsync(ArchiveOrderCommand request, HeaderData header);

        Task<ObjectClientResponse<CancelOrderCommandResponse>> CancelOrderAsync(CancelOrderCommand request, HeaderData header);

        Task<ObjectClientResponse<CreateOrderCommandResponse>> CreateOrderAsync(CreateOrderCommand request, HeaderData header);

        Task<ObjectClientResponse<EditOrderCommandResponse>> EditOrderAsync(EditOrderCommand request, HeaderData header);

        Task<ObjectClientResponse<SubmitOrderCommandResponse>> SubmitOrderAsync(SubmitOrderCommand request, HeaderData header);

        #endregion

        #region Queries

        Task<ObjectClientResponse<BrowseOrdersQueryResponse>> BrowseOrdersAsync(BrowseOrdersQuery request, HeaderData header);

        Task<ObjectClientResponse<FilterOrdersQueryResponse>> FilterOrdersAsync(FilterOrdersQuery request, HeaderData header);

        Task<ObjectClientResponse<ViewOrderQueryResponse>> ViewOrderAsync(ViewOrderQuery request, HeaderData header);

        #endregion
    }
}
