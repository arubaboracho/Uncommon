﻿using System;
using System.Net;

namespace Xciles.Uncommon.Net
{
    public class UncommonRequestException : Exception
    {
        public EUncommonRequestExceptionStatus RequestExceptionStatus { get; set; }
        public Exception Exception { get; set; }
        public ServiceExceptionResult ServiceExceptionResult { get; set; }
        public string Information { get; set; }
        public WebExceptionStatus WebExceptionStatus { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
