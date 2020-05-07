using ProxyDesigner;
using System;

namespace StudyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DesignerTest();
        }

        /// <summary>
        /// 设计模式测试
        /// </summary>
        public static void DesignerTest()
        {
            //代理模式测试
            var proxyTest = new ProxyDesignerTest();
            proxyTest.TestStaticInterfaceProxy();
            proxyTest.TestStaticExternProxy();


        }




    }
}
