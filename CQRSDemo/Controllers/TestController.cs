using CQRSDemo.CQRS.Command;
using CQRSDemo.CQRS.Nofication;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.Controllers
{
    [ApiController]
    [Route("api/test/{action}")]
    public class TestController: ControllerBase
    {
        private readonly IMediator _mediator;

        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public void MediatorTest(string name)
        {
            _mediator .Send(new TestCommand { HandlerName=name});
        }

        [HttpGet]
        public void MediatorPublishTest(string name)
        {
            _mediator.Publish(new TestNofication { Name = name });
        }
    }
}
