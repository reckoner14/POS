using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using POS.Model;

namespace POS.Services
{
    public class BillingService : IBillingService
    {
        public double GetTotalBill()
        {
            List<Sku> skus = new List<Sku>()
            {
                new Sku(){
                    Id = 453,
                    ItemId = 1,
                    PricePerQty = 75,
                    DealId =1
                },
                 new Sku(){
                    Id = 799,
                    ItemId = 2,
                    PricePerQty = 15,
                    DealId=2
                },
                  new Sku(){
                    Id = 125,
                    ItemId = 3,
                    PricePerQty = 20,
                    DealId =3
                }
            };

            return CalculateBill(skus);
        }

        private double CalculateBill(List<Sku> skus)
        {
            double totalPrice = 0;

            foreach (var item in skus)
            {
                int discountPrice = 0;
                switch (item.DealId)
                {
                    case 1:
                        discountPrice = item.PricePerQty - 1;
                        break;
                    case 2:
                        discountPrice = item.PricePerQty + (item.PricePerQty * 10 / 100);
                        break;
                    default:
                        break;
                }
                totalPrice += discountPrice;
            }

            totalPrice = ApplyVat(totalPrice);

            return totalPrice;
        }

        private double ApplyVat(double totalPrice)
        {
            return totalPrice + (totalPrice * 5 / 100);
        }
    }
}
