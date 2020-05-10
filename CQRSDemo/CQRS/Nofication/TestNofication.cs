using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDemo.CQRS.Nofication
{
    public class TestNofication:INotification
    {
        public string Name { get; set; }
    }
}
