using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDesigner
{
    public class StaticWalk
    {
        public string Walk()
        {
            Console.WriteLine("执行结果：行走");
            return "行走";
        }

        public string Stop()
        {
            Console.WriteLine("执行结果：停下");
            return "停下";
        }
    }



    public class StaticExternProxy: StaticWalk
    {
        public new string Stop()
        {
            Console.WriteLine($"开始执行{nameof(Stop)}");
            var getValue = base.Stop();
            Console.WriteLine($"结束执行{nameof(Stop)}");
            return getValue;
        }

        public new string Walk()
        {
            Console.WriteLine($"开始执行{nameof(Walk)}");
            var getValue = base.Walk();
            Console.WriteLine($"结束执行{nameof(Walk)}");
            return getValue;
        }
    }
}
