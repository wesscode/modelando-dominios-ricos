using FluentValidation.Results;
using MediatR;

namespace NerdStore.Core.Messages
{
    public class Command : Message, IRequest<bool>
    {
        public DateTime Timestemp { get; private set; }
        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestemp = DateTime.Now;
        }

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
