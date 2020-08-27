using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class APromotion : Promotion
    {
        public APromotion(Order order)
        {
            base.OrderDetails = order;
            base.Price = 50;
            base.PromotionPrice = 130;
        }

        public override int GetTotalPrice()
        {
            var totalPrice = (base.ProductsCount["A"] / 3) * base.PromotionPrice + (base.ProductsCount["A"] % 3 * Price);
            return totalPrice;
        }
    }
}
