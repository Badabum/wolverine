// <auto-generated/>
#pragma warning disable

namespace Internal.Generated.WolverineHandlers
{
    // START: HttpMessage4Handler102738066
    public class HttpMessage4Handler102738066 : Wolverine.Runtime.Handlers.MessageHandler
    {


        public override System.Threading.Tasks.Task HandleAsync(Wolverine.Runtime.MessageContext context, System.Threading.CancellationToken cancellation)
        {
            var httpMessage4 = (WolverineWebApi.HttpMessage4)context.Envelope.Message;
            WolverineWebApi.MessageHandler.Handle(httpMessage4);
            return System.Threading.Tasks.Task.CompletedTask;
        }

    }

    // END: HttpMessage4Handler102738066
    
    
}

