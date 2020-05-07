using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDesigner
{
    public class ProxyDesignerTest
    {
        public void TestStaticInterfaceProxy()
        {
            IStaticOrder order = new StaticOrder();
            order.GetOrderAddress();
            order.GetOrderItemCount();


            IStaticOrder orderProxy = new StaticInterfaceProxy();
            orderProxy.GetOrderAddress();
            orderProxy.GetOrderItemCount();
        }

        public void TestStaticExternProxy()
        {
            StaticWalk walk = new StaticWalk();
            walk.Walk();
            walk.Stop();


            StaticExternProxy walkProxy = new StaticExternProxy();
            walkProxy.Walk();
            walkProxy.Stop();
        }


    }
}
