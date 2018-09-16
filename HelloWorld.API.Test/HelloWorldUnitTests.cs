using Moq;
using HelloWorld.Domain.Interface;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Domain;
using HelloWorld.Domain.Entity;
using HelloWorld.API.Business;

namespace HelloWorld.API.Test
{
    [TestClass]
    public class HelloWorldUnitTests
    {
        [TestMethod]
        public void WorkHandlerReturnsMessage()
        {
            ReturnMessage expectedValue = new ReturnMessage() { MessageValue = Constants.HelloMessage };
            Mock<IDataRepository> mockRepo = new Mock<IDataRepository>();
            mockRepo.Setup(m => m.GetMessage()).Returns(expectedValue);

            WorkHandler handler = new WorkHandler(mockRepo.Object);
            IReturnMessage returnValue = handler.GetMessage();

            Assert.IsNotNull(returnValue);
            Assert.AreEqual(returnValue, expectedValue);
            Assert.AreEqual(returnValue.MessageValue, Constants.HelloMessage);
        }
    }
}
