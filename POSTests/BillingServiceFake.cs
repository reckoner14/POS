using POS.Services;

namespace POSTests
{
    public class BillingServiceFake : IBillingService
    {
        public double GetTotalBill()
        {
            return 170;
        }
    }
}
