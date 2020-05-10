using CQRSDemo.CQRS.Nofication;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.NoficationHandler
{
    public class TestNoficationHandlerV1 : INotificationHandler<TestNofication>
    {
        public Task Handle(TestNofication notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("TestNoficationHandlerV1执行" + notification.Name);
            return Task.CompletedTask;
        }
    }
}
