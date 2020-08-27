using BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartPromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var order = new Order(1, new List<Product>() {
                new Product("A"),
                new Product("B"),
                new Product("C")
            });

                var totalPrice = order.GetTotalPrice();
                Console.WriteLine("Total Price of Order ="+ totalPrice);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
