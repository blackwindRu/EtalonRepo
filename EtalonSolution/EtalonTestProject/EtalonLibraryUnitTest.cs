using System;
using EtalonLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EtalonTestProject
{
    [TestClass]
    public class EtalonLibraryUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var tester = (EtalonNamedObject)EtalonFactory.Instance();
            var name = tester.Name;
            const string expectedName = "DefaultName";
            Assert.AreEqual(expectedName, name);
        }
    }
}
