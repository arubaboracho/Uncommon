﻿using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace Xciles.Uncommon.Handler
{
    public class UncommonHttpClientHandler : HttpClientHandler
    {
        public UncommonHttpClientHandler()
        {
            AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
        }

        //public override bool SupportsAutomaticDecompression
        //{
        //    get { return true; }
        //}

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            // todo add gzip compression when sending
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
