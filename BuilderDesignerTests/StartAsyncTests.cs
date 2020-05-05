using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAsync;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestAsync.Tests
{
    [TestClass()]
    public class StartAsyncTests
    {

        StartAsync _test = new StartAsync();

        [TestMethod()]
        public void TestNotAwaitTest1()
        {
            _test.TestNotAwait();
        }

        [TestMethod()]
        public void TestAwaitTest()
        {
            _test.TestAwait();
        }
    }
}