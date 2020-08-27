using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public abstract class Promotion
    {
        public int ProductCount { get; set; }
        public int PromotionPrice { get; set; }
        public Dictionary<string, int> ProductsCount => GetCount();
        public int Price { get; set; }
        public Order OrderDetails { get; set; }
        public abstract int GetTotalPrice();

        public Dictionary<string, int> GetCount()
        {
            Dictionary<string, int> productsCount = new Dictionary<string, int>();

            foreach (Product pr in OrderDetails.Products)
            {
                switch (pr.Id)
                {
                    case "A":
                    case "a":
                        if (productsCount.ContainsKey("A"))
                        {
                            productsCount["A"] = productsCount["A"] + 1;
                        }
                        else
                        {
                            productsCount.Add("A", 1);
                        }
                        break;
                    case "B":
                    case "b":
                        if (productsCount.ContainsKey("B"))
                        {
                            productsCount["B"] = productsCount["B"] + 1;
                        }
                        else
                        {
                            productsCount.Add("B", 1);
                        }
                        break;
                    case "C":
                    case "c":
                        if (productsCount.ContainsKey("C"))
                        {
                            productsCount["C"] = productsCount["C"] + 1;
                        }
                        else
                        {
                            productsCount.Add("C", 1);
                        }
                        break;
                    case "D":
                    case "d":
                        if (productsCount.ContainsKey("D"))
                        {
                            productsCount["D"] = productsCount["D"] + 1;
                        }
                        else
                        {
                            productsCount.Add("D", 1);
                        }
                        break;
                }
            }

            return productsCount;
        }
    }
}
