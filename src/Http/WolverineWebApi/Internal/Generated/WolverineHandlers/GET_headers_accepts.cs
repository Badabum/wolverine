// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: GET_headers_accepts
    public class GET_headers_accepts : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _options;

        public GET_headers_accepts(Wolverine.Http.WolverineHttpOptions options) : base(options)
        {
            _options = options;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var headerUsingEndpoint = new WolverineWebApi.HeaderUsingEndpoint();
            var accepts = ReadSingleHeaderValue(httpContext, "accepts");
            var result_of_GetETag = headerUsingEndpoint.GetETag(accepts);
            await WriteString(httpContext, result_of_GetETag);
        }

    }

    // END: GET_headers_accepts
    
    
}

