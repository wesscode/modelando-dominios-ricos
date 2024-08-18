using MediatR;
using NerdStore.Core.Messages;
using NerdStore.Core.Messages.CommonMessages.Notifications;

namespace NerdStore.Core.Communication.Mediator
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatorHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> EnviarComando<T>(T comando) where T : Command //command é uma intenção de mudança.
        {
            return await _mediator.Send(comando);
        }

        public async Task PublicarEvento<T>(T evento) where T : Event //evento é uma notificação.
        {
            await _mediator.Publish(evento);
        }

        public async Task PublicarNotificacao<T>(T notificacao) where T : DomainNotification
        {
            await _mediator.Publish(notificacao);
        }
    }
}
