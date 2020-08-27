using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class CDPromotion : Promotion
    {
        public CDPromotion(Order order)
        {
            base.OrderDetails = order;
            base.PromotionPrice = 45;
        }

        public override int GetTotalPrice()
        {
            int totalPriceofCD = 0;

            var productCount = base.ProductsCount;

            if (productCount.ContainsKey("C") && productCount.ContainsKey("D") 
                && productCount["C"] > 0 && productCount["D"] > 0)
            {
                while (productCount["C"] > 0 && productCount["D"] > 0)
                {
                    totalPriceofCD += 30;
                    productCount["C"] = productCount["C"] -1;
                    productCount["D"] = productCount["D"] - 1;
                }
            }

            if (productCount.ContainsKey("C"))
                totalPriceofCD += (productCount["C"] * 20);

            if(productCount.ContainsKey("D"))
                totalPriceofCD += (productCount["D"] * 15);

            return totalPriceofCD;
        }
    }
}
