using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderDesigner
{
    public class AddressBuilder
    {
        public string City { get; private set; }

        public string Code { get; private set; }

        public string Street { get; private set; }


        public void SetCity(string city) => City = city;

        public void SetCode(string code) => Code = code;

        public void SetStreet(string street) => Street = street;

        public Address Build()
        {
            var proList = typeof(AddressBuilder).GetProperties();
            if (proList.Any(s => s.GetValue(this) == null))
            {
                throw new ArgumentNullException($"构造失败：有参数未填写");
            }

            return new Address(this);

        }

    }
}
