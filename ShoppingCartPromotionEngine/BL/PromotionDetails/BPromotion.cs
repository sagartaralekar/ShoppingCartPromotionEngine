using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BPromotion : Promotion
    {
        public BPromotion(Order order)
        {
            base.OrderDetails = order;
            base.Price = 30;
            base.PromotionPrice = 45;
        }

        public override int GetTotalPrice()
        {
            return (base.ProductsCount["B"] / 2) * base.PromotionPrice + (base.ProductsCount["B"] % 2 * Price);
        }
    }
}
