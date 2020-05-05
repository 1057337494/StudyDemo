using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesigner
{
    public class Address
    {
        public Address(AddressBuilder build)
        {
            City = build.City;
            Code = build.Code;
            Street = build.Street;
        }

        public string City { get; private set; }

        public string Code { get; private set; }

        public string Street { get; private set; }


    }
}
