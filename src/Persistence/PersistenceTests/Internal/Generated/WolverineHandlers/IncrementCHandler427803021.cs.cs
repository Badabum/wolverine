// <auto-generated/>
#pragma warning disable
using Wolverine.Marten.Publishing;

namespace Internal.Generated.WolverineHandlers
{
    // START: IncrementCHandler427803021
    public class IncrementCHandler427803021 : Wolverine.Runtime.Handlers.MessageHandler
    {
        private readonly Wolverine.Marten.Publishing.OutboxedSessionFactory _outboxedSessionFactory;

        public IncrementCHandler427803021(Wolverine.Marten.Publishing.OutboxedSessionFactory outboxedSessionFactory)
        {
            _outboxedSessionFactory = outboxedSessionFactory;
        }



        public override async System.Threading.Tasks.Task HandleAsync(Wolverine.Runtime.MessageContext context, System.Threading.CancellationToken cancellation)
        {
            var letterAggregateHandler = new PersistenceTests.Marten.LetterAggregateHandler();
            var incrementC = (PersistenceTests.Marten.IncrementC)context.Envelope.Message;
            await using var documentSession = _outboxedSessionFactory.OpenSession(context);
            var eventStore = documentSession.Events;
            
            // Loading Marten aggregate
            var eventStream = await eventStore.FetchForWriting<PersistenceTests.Marten.LetterAggregate>(incrementC.LetterAggregateId, cancellation).ConfigureAwait(false);

            letterAggregateHandler.Handle(incrementC, eventStream);
            await documentSession.SaveChangesAsync(cancellation).ConfigureAwait(false);
        }

    }

    // END: IncrementCHandler427803021
    
    
}

