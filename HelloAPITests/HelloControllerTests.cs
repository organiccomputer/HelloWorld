using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloAPI.Controllers;

namespace HelloAPITests
{
    [TestClass]
    public class HelloControllerTests
    {
        [TestMethod]
        public void HelloControllerGetTest()
        {
            var controller = new HelloController();
            var result = controller.Get();

            Assert.AreEqual("Hello World", result);
        }
    }
}
