using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.PromotionDetails
{
    public class CPromotion : Promotion
    {
        public CPromotion(Order order)
        {
            base.OrderDetails = order;
            base.PromotionPrice = 45;
        }

        public override int GetTotalPrice()
        {
            int totalPriceofCD = 0;

            if (base.ProductsCount["C"] > 0 && base.ProductsCount["D"] > 0)
            {
                while (base.ProductsCount["C"] > 0 && base.ProductsCount["D"] > 0)
                {
                    totalPriceofCD += 30;
                    base.ProductsCount["C"]--;
                    base.ProductsCount["D"]--;
                }
            }

            int totalPriceofC = (base.ProductsCount["C"] * 20);
            int totalPriceofD = (base.ProductsCount["D"] * 15);

            return totalPriceofCD;
        }
    }
}
