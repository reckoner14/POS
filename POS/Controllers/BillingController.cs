using Microsoft.AspNetCore.Mvc;

namespace POS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BillingController : Controller
    {
        [HttpGet(Name = "GetTotalBill")]
        public IActionResult Get()
        {
            int TotalBill = 450;
            return Ok(TotalBill);
        }
    }
}
