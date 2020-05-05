using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuilderDesigner;
using System;
using System.Collections.Generic;
using System.Text;

[TestClass]
public class DesignerTests
{
    [TestMethod]
    public void TestBuildDesigner()
    {
        var build = new AddressBuilder();
        build.SetCity("广州");
        build.SetCode("510000");
        build.SetStreet("广州");
        var addr = build.Build();
    }

}