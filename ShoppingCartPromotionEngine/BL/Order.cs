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
        }

        public int GetTotalPrice()
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;

            foreach (Product pr in Products)
            {
                switch (pr.Id)
                {
                    case "A":
                    case "a":
                        counterofA += 1;
                        break;
                    case "B":
                    case "b":
                        counterofB += 1;
                        break;
                    case "C":
                    case "c":
                        CounterofC += 1;
                        break;
                    case "D":
                    case "d":
                        CounterofD += 1;
                        break;
                }
            }

            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);


            int totalPriceofCD = 0; 

            if (CounterofC>0 && CounterofD>0)
            {
                while (CounterofC > 0 && CounterofD > 0)
                {
                    totalPriceofCD += 30;
                    CounterofC--;
                    CounterofD--;
                }
            }

            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD+ totalPriceofCD;

        }
    }
}
