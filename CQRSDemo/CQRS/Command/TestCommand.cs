using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.Command
{
    public class TestCommand:IRequest<long>
    {
        public string HandlerName { get; set; }


    }
}
