using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.CQRS
{
    public interface ICommandHandler<in TCommand> : IRequestHandler<TCommand, Unit>
        where TCommand : IRequest<Unit>;
    public interface ICommandHandler<in TCommand, TResponse> : IRequestHandler<TCommand,TResponse>
        where TResponse : notnull
         where TCommand : IRequest<TResponse>
    {
    }
}
