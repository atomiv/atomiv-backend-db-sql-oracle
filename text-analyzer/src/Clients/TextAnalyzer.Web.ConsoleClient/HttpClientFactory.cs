﻿using Microsoft.Extensions.Options;
using System;
using System.Net.Http;

namespace TextAnalyzer.Web.ConsoleClient
{
    public class HttpClientFactory : IHttpClientFactory
    {
        private readonly IOptions<AppOptions> _options;

        public HttpClientFactory(IOptions<AppOptions> options)
        {
            _options = options;
        }

        public HttpClient CreateClient(string name)
        {
            var baseAddressUrl = _options.Value.RestApi;

            var baseAddress = new Uri(baseAddressUrl);

            return new HttpClient
            {
                BaseAddress = baseAddress,
            };
        }
    }
}
