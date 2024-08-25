using NerdStore.Core.Messages;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoRascunhoIniciadoEvent : Event
    {
        public Guid ClientId { get; private set; }
        public Guid PedidoId { get; private set; }

        public PedidoRascunhoIniciadoEvent(Guid clientId, Guid pedidoId)
        {
            AggregateId = pedidoId;
            ClientId = clientId;
            PedidoId = pedidoId;
        }
    } 
}