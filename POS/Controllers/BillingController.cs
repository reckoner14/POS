using Microsoft.AspNetCore.Mvc;
using POS.Services;

namespace POS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillingController : Controller
    {
        private readonly IBillingService _billingService;

        public BillingController(IBillingService billingService)
        {
            _billingService = billingService;
        }

        [HttpGet(Name = "GetTotalBill")]
        public IActionResult Get()
        {
            double TotalBill = _billingService.GetTotalBill();
            
            return Ok(TotalBill);
        }
    }
}
