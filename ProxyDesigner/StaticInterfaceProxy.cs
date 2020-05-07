using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDesigner
{

    public interface IStaticOrder
    {
        int GetOrderItemCount();

        string GetOrderAddress();
    }


    public class StaticOrder : IStaticOrder
    {
        public string GetOrderAddress()
        {
            Console.WriteLine("执行结果：广州");
            return "广州";
        }

        public int GetOrderItemCount()
        {
            Console.WriteLine("执行结果：10");
            return 10;
        }
    }


    public class StaticInterfaceProxy : IStaticOrder
    {
        StaticOrder _order = new StaticOrder();
        public string GetOrderAddress()
        {
            Console.WriteLine($"开始执行{nameof(GetOrderAddress)}");
            var getValue=_order.GetOrderAddress();
            Console.WriteLine($"结束执行{nameof(GetOrderAddress)}");
            return getValue;
        }

        public int GetOrderItemCount()
        {
            Console.WriteLine($"开始执行{nameof(GetOrderItemCount)}");
            var getValue = _order.GetOrderItemCount();
            Console.WriteLine($"结束执行{nameof(GetOrderItemCount)}");
            return getValue;
        }
    }
}
