using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Product
    {
        public string Id { get; set; }
        public int Price { get; set; }


        public Product(string id)
        {
            this.Id = id;
            switch (id)
            {
                case "A":
                    this.Price = 50;

                    break;
                case "B":
                    this.Price = 30;

                    break;
                case "C":
                    this.Price = 20;

                    break;
                case "D":
                    this.Price = 15;
                    break;
            }
        }
    }
}
