using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Order
    {
        public int OrderID { get; set; }
        public List<Product> Products { get; set; }
        public List<Promotion> PromotionList { get; set; }

        public Order(int _oid, List<Product> _prods)
        {
            this.OrderID = _oid;
            this.Products = _prods;

            PromotionList = new List<Promotion>();
            PromotionList.Add(new APromotion(this));
            PromotionList.Add(new BPromotion(this));
            PromotionList.Add(new CDPromotion(this));
        }

        public int GetTotalPrice()
        {
            var totalPrice = PromotionList.Select(obj => obj.GetTotalPrice()).Sum();

            return totalPrice;
        }
    }
}
