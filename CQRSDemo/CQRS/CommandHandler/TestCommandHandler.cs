using CQRSDemo.CQRS.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.CommandHandler
{
    public class TestCommandHandler : IRequestHandler<TestCommand,long>
    {
    

        Task<long> IRequestHandler<TestCommand, long>.Handle(TestCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine(request.HandlerName);
            return default;
        }
    }
}
