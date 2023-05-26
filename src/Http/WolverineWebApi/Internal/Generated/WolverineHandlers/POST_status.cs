// <auto-generated/>
#pragma warning disable
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using Wolverine.Http;

namespace Internal.Generated.WolverineHandlers
{
    // START: POST_status
    public class POST_status : Wolverine.Http.HttpHandler
    {
        private readonly Wolverine.Http.WolverineHttpOptions _options;
        private readonly Microsoft.Extensions.Logging.ILogger<WolverineWebApi.StatusCodeRequest> _loggerForMessage;

        public POST_status(Wolverine.Http.WolverineHttpOptions options, Microsoft.Extensions.Logging.ILogger<WolverineWebApi.StatusCodeRequest> loggerForMessage) : base(options)
        {
            _options = options;
            _loggerForMessage = loggerForMessage;
        }



        public override async System.Threading.Tasks.Task Handle(Microsoft.AspNetCore.Http.HttpContext httpContext)
        {
            var (request, jsonContinue) = await ReadJsonAsync<WolverineWebApi.StatusCodeRequest>(httpContext);
            if (jsonContinue == Wolverine.HandlerContinuation.Stop) return;
            var result_of_PostStatusCode = WolverineWebApi.StatusCodeEndpoint.PostStatusCode(request, ((Microsoft.Extensions.Logging.ILogger)_loggerForMessage));
            httpContext.Response.StatusCode = result_of_PostStatusCode;
        }

    }

    // END: POST_status
    
    
}

