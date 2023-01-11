using Microsoft.AspNetCore.Mvc;
using POS.Controllers;
using POS.Services;
using Xunit;

namespace POSTests
{
    public class BillingControllerTests
    {
        private readonly BillingController _controller;
        private readonly IBillingService _service;

        public BillingControllerTests() 
        {
            _service = new BillingServiceFake();
            _controller = new BillingController(_service);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }
    }
}
